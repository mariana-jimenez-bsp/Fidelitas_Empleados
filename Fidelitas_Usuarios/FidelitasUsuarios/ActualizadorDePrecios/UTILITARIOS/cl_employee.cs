using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FidelitasUsuarios.Classes
{
    public class clSchemes
    {

        public clSchemes(string pname)
        {
            this.name = pname;
        }

        public string name { get; set; }
    }

    public class clEmployee
    {
        public string EmployeeCode { get; set; }
        public string EmployeeCenter { get; set; }
        public string PayrollCode { get; set; }
        public string NumPayroll { get; set; }
    }
    public class clBitacora
    {
        public string ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public string Empleado { get; set; }
        public string Fecha { get; set; }
    }
}
