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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdmin ventana = new frmAdmin();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOrganizaciones ventana = new frmOrganizaciones();
            ventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMembresias ventana = new frmMembresias();
            ventana.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmPosicion ventana = new frmPosicion();
            ventana.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmRegistros ventana = new frmRegistros();
            ventana.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmCapitulos ventana = new frmCapitulos();
            ventana.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No disponible por el momento");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmUsuarios ventana = new frmUsuarios();
            ventana.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No disponible por el momento");
        }

        private void btnCerrarS_Click(object sender, EventArgs e)
        {
            frmLogin ventana = new frmLogin();
            ventana.Show();
            this.Close();
        }
    }
}
