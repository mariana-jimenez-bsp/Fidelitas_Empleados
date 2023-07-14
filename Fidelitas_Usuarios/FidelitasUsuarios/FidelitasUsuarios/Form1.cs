using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FidelitasUsuarios.Controller;
using ClosedXML.Excel;
using FidelitasUsuarios.Classes;

namespace FidelitasUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controller_Employee schema = new Controller_Employee();
            schema.ConsultSchemas(cbxSchema);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                //imp.ImportarExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            lblRoute.Visible = true;
            lblRoute.Text = filePath;
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

                    dgvEmployee.DataSource = dt;
                }
            }
        }
        public List<clEmployee> AddEmployee()
        {
            var listaPrecio = new List<clEmployee>();
            foreach (DataGridViewRow row in dgvEmployee.Rows)
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string txtSchema = cbxSchema.SelectedItem.ToString();
            Controller_Employee employee = new Controller_Employee();
            backgroundWorker1.ReportProgress(0);
            int cantLineas = dgvEmployee.RowCount;
            short linea = 0;
            // INICIO - CODIGO DE PROCESAR DGV

            var employees = AddEmployee();
            foreach (var emp in employees)
            {
                employee.InsertEmployee(txtSchema, emp.EmployeeCode, emp.EmployeeCenter, emp.PayrollCode, emp.NumPayroll);
                linea++;
                backgroundWorker1.ReportProgress(linea * 100 / cantLineas);
            }

        }
    }
}
