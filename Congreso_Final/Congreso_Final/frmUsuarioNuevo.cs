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
    public partial class frmUsuarioNuevo : Form
    {

        SQLServer data = new SQLServer();
        public SqlCommand cmd;
        public SqlConnection cnn;
        string sql;

        string ruta = "";
        string archivo;
        string rutacompleta;
        public string idvalor;

        public frmUsuarioNuevo()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtPin.Text = "";
            txtPass.Text = "";
            txtNombreU.Text = "";
            txtApellido.Text = "";
            cmbSexo.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDisciplina.Text = "";
            txtRFC.Text = "";
            cmbFactura.Text = "";
            pboxFoto.Image = null;
            txtPass.Focus();
            data.llenarCombos(cmbOrganizacion, "select * from organizaciones order by id_organizacion", "id_organizacion", "nombre");
        }

        public void agregar()
        {
            data.Abrir_bd();
            if (txtPass.Text == "" || txtNombreU.Text == "" || txtApellido.Text == "")
            {
                return;
            }
            else
            {
                sql = string.Format("insert into usuarios(pass,posicion_titulo,nombre,apellidos,sexo,email,telefono,organizacion,disciplina,url,factura,razonsocial,rfc,domiciliofiscal) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
                            txtPass.Text.Trim(), txtPosicion.Text.Trim(), txtNombreU.Text.Trim(), txtApellido.Text.Trim(), cmbSexo.SelectedItem, txtEmail.Text.Trim(), txtTelefono.Text.Trim(), cmbOrganizacion.SelectedValue, txtDisciplina.Text.Trim(), txtURL.Text.Trim(), cmbFactura.SelectedItem, txtRazon.Text.Trim(), txtRFC.Text.Trim(), txtDomicilio.Text.Trim());
                if (data.ExecuteSQL(sql))
                {

                    // grabar foto
                    sql = string.Format("update usuarios set foto=@fotoimagen where pin={0}", txtPin.Text);
                    data.grabarImageServer(sql, pboxFoto.Image);

                    MessageBox.Show("Usuario creado satisfactoriamente, \nPorfavor inicie sesion");
                    Limpiar();
                }
            }


            
            
            string sql2 = string.Format("Select Max(pin) from usuarios");
            int pin = Convert.ToInt32(data.ExecuteScalar(sql2));
            MessageBox.Show("Tu pin es:" + pin.ToString() + "\nRecuerde su pin");
        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos los formatos de imagen|*.jpg;*.jpeg;*.png;*.tif;*.tiff;*.bmp|Todos los archivos|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {

                string file = openFileDialog1.FileName;


                try
                {
                    pboxFoto.Image = Image.FromFile(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar la Imagen");
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void frmUsuarioNuevo_Load(object sender, EventArgs e)
        {
            data.llenarCombos(cmbOrganizacion, "select * from organizaciones order by id_organizacion", "id_organizacion", "nombre");
        }

        private void txtPosicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtPosicion);
        }

        private void txtNombreU_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtNombreU);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtApellido);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarCorreo(e, txtEmail);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarTelefono(e, txtTelefono);
        }

        private void txtDisciplina_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtDisciplina);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin ventana = new frmLogin();
            ventana.Show();
        }
    }
}
