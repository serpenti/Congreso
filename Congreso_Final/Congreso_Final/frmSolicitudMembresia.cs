using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace Congreso_Final
{
    public partial class frmSolicitudMembresia : Form
    {

        SQLServer data = new SQLServer();
        public SqlCommand cmd;
        public SqlConnection cnn;
        string sql;

        string ruta = "";
        string archivo;
        string rutacompleta;
        public string idvalor;
        string valor = null;

        public frmSolicitudMembresia()
        {
            InitializeComponent();
        }

        public void consulta()
        {
            DataTable Datos = new DataTable();

            sql = string.Format("select pin from usuarios where pin={0}", frmLogin.userLogin);
            Datos = data.listaTabla(sql);

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro ningun Usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtPin.Text = Datos.Rows[0][0].ToString();

            }
        }

        public void consulta2()
        {
            DataTable Datos = new DataTable();

            sql = string.Format("select costo from tipo_membresias where id_tipo={0}", comboBox1.SelectedValue);
            Datos = data.listaTabla(sql);

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("Error en la consulta", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblPrecio.Text = Datos.Rows[0][0].ToString();

            }
        }


        public void agregar()
        {
                sql = string.Format("insert into miembros(miembro,membresia,pago) values('{0}','{1}','{2}')",
                            txtPin.Text.Trim(), comboBox1.SelectedValue);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar();
            MessageBox.Show("Se ha enviado el recibo de pago a su correo electronico");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRecibo ventana = new frmRecibo();
            ventana.Show();
        }

        private void frmSolicitudMembresia_Load(object sender, EventArgs e)
        {
            consulta();
            data.llenarCombos(comboBox1, "select * from tipo_membresias order by id_tipo", "id_tipo", "nombre");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            frmMenuUsuario ventana = new frmMenuUsuario();
            ventana.Show();
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Datos = new DataTable();
            string vari;

            sql = string.Format("select costo from tipo_membresias where id_tipo={0}", comboBox1.SelectedValue);
            Datos = data.listaTabla(sql);

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("Error en la consulta", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                vari = Datos.Rows[0][0].ToString();
                lblPrecio.Text = vari;


            }
        }

        private void comboBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
