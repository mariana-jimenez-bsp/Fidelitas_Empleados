using ActualizadorDePrecios;
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

namespace FidelitasUsuarios
{
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
            db_employee commands = new db_employee();
            commands.ViewRecord(dtgBitacora);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

            this.Close();
        }
    }
}
