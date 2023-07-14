using FidelitasUsuarios.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FidelitasUsuarios.Connnections
{
    class db_employee
    {
        public List<clSchemes> viewSchema()
        {
            List<clSchemes> SchemesOfSystem = new List<clSchemes>();
            Prueba_FIDEDataSetTableAdapters.IAF_OBTENER_ESQUEMATableAdapter Adapter = new Prueba_FIDEDataSetTableAdapters.IAF_OBTENER_ESQUEMATableAdapter();
            Prueba_FIDEDataSet.IAF_OBTENER_ESQUEMADataTable data = Adapter.GetData();

            foreach (Prueba_FIDEDataSet.IAF_OBTENER_ESQUEMARow row in data)
            {
                clSchemes prueba = new clSchemes();
                prueba.name = row.ESQUEMA;
                SchemesOfSystem.Add(prueba);
            }

            return SchemesOfSystem;
        }
    }
}
