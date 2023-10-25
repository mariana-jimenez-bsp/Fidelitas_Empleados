using FidelitasUsuarios.Classes;
using FidelitasUsuarios.Connnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FidelitasUsuarios.Controller
{
    class Controller_Employee
    {
        db_employee dbSchema = new db_employee();
        public void ConsultSchemas(ComboBox cbxshema)
        {
            List<clSchemes> SchemaList = new List<clSchemes>();

            SchemaList = dbSchema.viewSchema();

            cbxshema.Items.Clear();

            foreach (var schema in SchemaList)
            {
                cbxshema.Items.Add(schema.name);
            }
        }

        public string InsertEmployee(string Schema, string EmployeeCode, string EmployeeCenter, string PayrollCode, string NumPayroll)
        {
            string resultcode;
            try
            {
                resultcode = dbSchema.InsertEmployee(Schema, EmployeeCode, EmployeeCenter, PayrollCode, NumPayroll);

                return "1";
            }
            catch (Exception e)
            {
                return "-1";
            }

        }
    }
}