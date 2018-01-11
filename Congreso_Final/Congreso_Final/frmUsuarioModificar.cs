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
    public partial class frmUsuarioModificar : Form
    {

        SQLServer data = new SQLServer();
        public SqlCommand cmd;
        public SqlConnection cnn;
        string sql;

        string ruta = "";
        string archivo;
        string rutacompleta;
        public string idvalor;

        public Image setFotoPicturebox2(string codigo)
        {

            sql = string.Format("select foto from usuarios where pin=@codigo");

            data.Abrir_bd();
            SqlCommand cmd1 = new SqlCommand(sql, cnn);
            cmd1.Parameters.AddWithValue("@codigo", codigo);
            try
            {
                byte[] imgArr = (byte[])cmd1.ExecuteScalar();
                //imgArr = (byte[])cmd.ExecuteScalar();
                using (var stream = new MemoryStream(imgArr))
                {
                    //Image img = null;
                    if (stream.Length == 0)
                    {
                        MessageBox.Show("No hay foto");
                        return null;
                    }
                    else
                    {
                        Image img = Image.FromStream(stream);
                        return img;
                    }
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
                return null;
            }

        }


        public frmUsuarioModificar()
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


        public void modificar()
        {
            /*  Falta
            - Validar Blancos
            - Verificar que no exista el id.
                          
           */
            if (txtPass.Text == "" || txtNombreU.Text == "" || txtApellido.Text == "")
            {
                return;
            }
            else
            {
                sql = String.Format("update usuarios set pass = '{0}',posicion_titulo = '{1}',nombre = '{2}',apellidos = '{3}',sexo = '{4}',email = '{5}', telefono = '{6}', organizacion = '{7}', disciplina = '{8}', url = '{9}', factura = '{10}', razonsocial = '{11}', rfc = '{12}', domiciliofiscal = '{13}' where pin='{14}'",
                           txtPass.Text.Trim(), txtPosicion.Text.Trim(), txtNombreU.Text.Trim(), txtApellido.Text.Trim(), cmbSexo.SelectedItem, txtEmail.Text.Trim(), txtTelefono.Text.Trim(), cmbOrganizacion.SelectedValue, txtDisciplina.Text.Trim(), txtURL.Text.Trim(), cmbFactura.SelectedItem, txtRazon.Text.Trim(), txtRFC.Text.Trim(), txtDomicilio.Text.Trim(), txtPin.Text.Trim());

                if (data.ExecuteSQL(sql))
                {
                    // modificar foto
                    sql = string.Format("update usuarios set foto=@fotoimagen where pin={0}", txtPin.Text);
                    data.grabarImageServer(sql, pboxFoto.Image);

                    MessageBox.Show("El usuario ha sido modificado satisfactoriamente");

                }
            }

        }

        public void consulta()
        {
            DataTable Datos = new DataTable();

            sql = string.Format("select pin,pass,posicion_titulo,nombre,apellidos,sexo,email,telefono,organizacion,disciplina,url,factura,razonsocial,rfc,domiciliofiscal from usuarios where pin={0}", frmLogin.userLogin);
            Datos = data.listaTabla(sql);

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro ningun Usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
            else
            {
                txtPin.Text = Datos.Rows[0][0].ToString();
                txtPass.Text = Datos.Rows[0][1].ToString();
                txtPosicion.Text = Datos.Rows[0][2].ToString();
                txtNombreU.Text = Datos.Rows[0][3].ToString();
                txtApellido.Text = Datos.Rows[0][4].ToString();
                cmbSexo.SelectedItem = Datos.Rows[0][5].ToString();
                txtEmail.Text = Datos.Rows[0][6].ToString();
                txtTelefono.Text = Datos.Rows[0][7].ToString();
                cmbOrganizacion.SelectedValue = Datos.Rows[0][8].ToString();
                txtDisciplina.Text = Datos.Rows[0][9].ToString();
                txtURL.Text = Datos.Rows[0][10].ToString();
                cmbFactura.SelectedItem = Datos.Rows[0][11].ToString();
                txtRazon.Text = Datos.Rows[0][12].ToString();
                txtRFC.Text = Datos.Rows[0][13].ToString();
                txtDomicilio.Text = Datos.Rows[0][14].ToString();

            }
            pboxFoto.Image = setFotoPicturebox2(txtPin.Text);

        }

        private void frmUsuarioModificar_Load(object sender, EventArgs e)
        {
            consulta();
            data.llenarCombos(cmbOrganizacion, "select * from organizaciones order by id_organizacion", "id_organizacion", "nombre");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmMenuUsuario ventana = new frmMenuUsuario();
            ventana.Show();
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
