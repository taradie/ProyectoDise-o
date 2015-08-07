using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Laboratorio
{
    public partial class frmMuestra : Form
    {
        public frmMuestra()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = 5;
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into MUESTRA  values ('{0}','{1}','{2}')",
                cod, txtRequerimientos.Text, txtDescripcionMuestra), clasConexion.funConexion());
                comando.ExecuteNonQuery();
                MessageBox.Show("Exito!");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
