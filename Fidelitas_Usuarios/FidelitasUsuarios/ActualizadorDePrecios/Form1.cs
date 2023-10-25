using ClosedXML.Excel;
using FidelitasUsuarios;
using FidelitasUsuarios.Classes;
using FidelitasUsuarios.Connnections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ActualizadorDePrecios
{
    public partial class Form1 : Form
    {
        db_employee commands = new db_employee();
        private static string esquema = "";

        public Form1()
        {
            InitializeComponent();
            CargarCompanias();
            cmbEsquemas.DropDownStyle = ComboBoxStyle.DropDownList;
            DateTime fechFinal = new DateTime(2024, 01, 15);
            DateTime fechActu = DateTime.Now;
            DateTime fechAdver = new DateTime(2024, 01, 10);
            if (fechActu == fechAdver || fechActu <= fechFinal)
            {
                TimeSpan ts = fechFinal - fechActu;

                int diferencia = ts.Days;
                if (diferencia == 5)
                {
                    MessageBox.Show("La Licencia del Sistema POS Web vence en " + diferencia + " días. Contacte al distribuidor autorizado, o cualquier información al correo info@bspcr.com.");
                }
            }
            else if (fechFinal.AddDays(3) < fechActu)
            {
                MessageBox.Show("Licencia vencida");
                cmbEsquemas.Enabled = false;
                btnProcesar.Enabled = false;
                btnAbrir.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        public void CargarCompanias()
        {
            List<string> listaBasesdatos = new List<string>();
            var listaEsquemas = commands.viewSchema();
            cmbEsquemas.Items.Clear();

            foreach (var item in listaEsquemas)
            {
                listaBasesdatos.Add(item.name);
            }
            cmbEsquemas.DataSource = listaBasesdatos;
        }

        public List<clEmployee> AddEmployee()
        {
            var listaPrecio = new List<clEmployee>();
            foreach (DataGridViewRow row in dgvListaPrecio.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {
                    listaPrecio.Add(new clEmployee()
                    {
                        EmployeeCode = Convert.ToString(row.Cells[0].Value),
                        EmployeeCenter = Convert.ToString(row.Cells[1].Value),
                        PayrollCode = Convert.ToString(row.Cells[2].Value),
                        NumPayroll = Convert.ToString(row.Cells[3].Value),
                    });
                }
                
            }
            return listaPrecio;
        }

        public List<clEmployee> ChangePayroll()
        {
            var payroll = new List<clEmployee>();
            foreach (DataGridViewRow row in dgvListaPrecio.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {
                    payroll.Add(new clEmployee()
                    {
                        PayrollCode = Convert.ToString(row.Cells[2].Value)
                    });
                }

            }
            return payroll;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            lblRuta.Visible = true; 
            lblRuta.Text = filePath; 
            //Open the Excel file using ClosedXML.
            using (XLWorkbook workBook = new XLWorkbook(filePath))
            {
                //Read the first Sheet from Excel file.
                IXLWorksheet workSheet = workBook.Worksheet(1);

                //Create a new DataTable.
                DataTable dt = new DataTable();

                //Loop through the Worksheet rows.
                bool firstRow = true;
                foreach (IXLRow row in workSheet.Rows())
                {
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Columns.Add(cell.Value.ToString());
                        }
                        firstRow = false;
                    }
                    else
                    {
                        //Add rows to DataTable.
                        dt.Rows.Add();
                        int i = 0;
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                            i++;
                        }
                    }

                    dgvListaPrecio.DataSource = dt;
                }
            }
        }

        private void txtProcesar_Click(object sender, EventArgs e)
        {
            //ActualizarListaPrecio();
            if ( dgvListaPrecio.Rows.Count == 0)
            {
                MessageBox.Show("¡No hay datos para procesar!", "Actualizador de Precios Masivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (backgroundWorkerProc.IsBusy != true)
                {
                    backgroundWorkerProc.RunWorkerAsync();
                    pbProcesar.Visible = true;
                }
            }
        }

        private void backgroundWorkerProc_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerProc.ReportProgress(0);
            int cantLineas = dgvListaPrecio.RowCount;
            short linea = 0;
            // INICIO - CODIGO DE PROCESAR DGV

            var employee = AddEmployee();
            foreach (var emp in employee)
            {
                commands.InsertEmployee(esquema, emp.EmployeeCode, emp.EmployeeCenter, emp.PayrollCode, emp.NumPayroll);
                linea++;
                backgroundWorkerProc.ReportProgress(linea * 100 / cantLineas);
            }
            var payrroll = ChangePayroll();
            foreach (var emp in employee)
            {
                commands.insertpayrroll(esquema, emp.PayrollCode);
            }
            

            // FIN 
        }

        private void backgroundWorkerProc_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbProcesar.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerProc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Proceso generado con éxito!", "Agregado de empleados Masivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbEsquemas_SelectedValueChanged(object sender, EventArgs e)
        {
            esquema = cmbEsquemas.SelectedValue.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitacora form = new Bitacora();
            form.Show();

            this.Close();
        }
    }
}
