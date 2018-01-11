using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Congreso_Final
{
    public partial class frmMenuUsuario : Form
    {
        public frmMenuUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrarS_Click(object sender, EventArgs e)
        {
            frmLogin ventana = new frmLogin();
            ventana.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmUsuarioModificar ventana = new frmUsuarioModificar();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSolicitudMembresia ventana = new frmSolicitudMembresia();
            ventana.Show();
            this.Hide();
        }
    }
}
