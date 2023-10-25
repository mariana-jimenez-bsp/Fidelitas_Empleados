using FidelitasUsuarios.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FidelitasUsuarios.DATOS.DataSet1TableAdapters;
using FidelitasUsuarios.DATOS;
using static FidelitasUsuarios.DATOS.DataSet1;
using System.Windows.Forms;

namespace FidelitasUsuarios.Connnections
{
    class db_employee
    {
        public List<clSchemes> viewSchema()
        {
            List<clSchemes> listaEsquemas = new List<clSchemes>();
            OBTENER_ESQUEMA_CONJUNTOTableAdapter sp = new OBTENER_ESQUEMA_CONJUNTOTableAdapter();

            var j = sp.GetData().ToList();

            foreach (DataSet1.OBTENER_ESQUEMA_CONJUNTORow item in j)
            {
                clSchemes _clEsquema = new clSchemes(item.CONJUNTO);
                listaEsquemas.Add(_clEsquema);
            }

            return listaEsquemas;
        }

        public void InsertEmployee(string Schema, string EmployeeCode, string EmployeeCenter, string PayrollCode, string NumPayroll)
        {
            try
            {
                string resultCode;

                Agregar_EmpleadosTableAdapter Adapter = new Agregar_EmpleadosTableAdapter();
                Agregar_EmpleadosDataTable data = Adapter.GetData(Schema, EmployeeCode, EmployeeCenter, PayrollCode, NumPayroll);

                foreach (Agregar_EmpleadosRow row in data)
                {
                    resultCode = row.ResultCode;
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Error al actualizar los Empleados", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insertpayrroll(string Schema, string PayrollCode)
        {
            try
            {
                string resultCode;

                Agregar_NominaTableAdapter Adapter = new Agregar_NominaTableAdapter();
                Agregar_NominaDataTable data = Adapter.GetData(Schema, PayrollCode);

                foreach (Agregar_NominaRow row in data)
                {
                    resultCode = row.ResultCode;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar estado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        public void ViewRecord(DataGridView dataGridViewBitacora)
        {
            List<clBitacora> listrecord = new List<clBitacora>();

            VerBitacoraTableAdapter Adapter = new VerBitacoraTableAdapter();
            VerBitacoraDataTable data = Adapter.GetData();

            foreach (VerBitacoraRow row in data)
            {
                clBitacora bitacora = new clBitacora();
                bitacora.ErrorNumber = row.ErrorNumber;
                bitacora.ErrorMessage = row.ErrorMessage;
                bitacora.Empleado = row.Empleado;
                bitacora.Fecha = row.Fecha;
                listrecord.Add(bitacora);
            }

            dataGridViewBitacora.Rows.Clear();

            foreach (var bitacora in listrecord)
            {
                dataGridViewBitacora.Rows.Add(bitacora.ErrorNumber,bitacora.ErrorMessage,bitacora.Empleado,bitacora.Fecha);
            }
        }

    }
}
