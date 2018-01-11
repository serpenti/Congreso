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
    public partial class frmUsuarios : Form
    {
        SQLServer data = new SQLServer();
        public SqlCommand cmd;
        public SqlConnection cnn;
        string sql;

        string ruta = "";
        string archivo;
        string rutacompleta;
        public string idvalor;

        public frmUsuarios()
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
            dtpFecha_c.Value = DateTime.Now;
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDisciplina.Text = "";
            txtRFC.Text = "";
            cmbFactura.Text = "";
            pboxFoto.Image = null;
            txtPass.Focus();
            data.llenarCombos(cmbOrganizacion, "select * from organizaciones order by id_organizacion", "id_organizacion", "nombre");
            data.llenarDatagrid(dtgrUsuario, "select * from usuarios order by pin where estatus = 'Activo'");
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
                sql = string.Format("insert into usuarios(pass,posicion_titulo,nombre,apellidos,sexo,email,telefono,organizacion,disciplina,url,factura,razonsocial,rfc,domiciliofiscal) values('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}'','{13}'','{14}')",
                            txtPass.Text.Trim(), txtPosicion.Text.Trim(),txtNombreU.Text.Trim(),txtApellido.Text.Trim(),cmbSexo.SelectedItem, txtEmail.Text.Trim(), txtTelefono.Text.Trim(),cmbOrganizacion.SelectedValue,txtDisciplina.Text.Trim(), txtURL.Text.Trim(),cmbFactura.SelectedItem,txtRazon.Text.Trim(),txtRFC.Text.Trim(),txtDomicilio.Text.Trim());
            }

            if (data.ExecuteSQL(sql))
            {

                // grabar foto
                sql = string.Format("update usuarios set foto=@fotoimagen where id_usuario={0}", txtPin.Text);
                data.grabarImageServer(sql, pboxFoto.Image);

                MessageBox.Show("Usuario agregado con exito");
                Limpiar();
            }

            string sql2 = string.Format("Select Max(pin) from usuarios");
            cmd = new SqlCommand(sql2, cnn);
            int pin2 = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("Tu pin es:" + pin2.ToString() + "/nRecuerde su pin");
        }


        public void modificar()
        {
            /*  Falta
            - Validar Blancos
            - Verificar que no exista el id.
                          
           */
            if (txtPass.Text == "" || txtPosicion.Text == "" || txtNombreU.Text == "" || txtApellido.Text == "")
            {
                return;
            }
            else
            {
                sql = String.Format("update usuarios set pass = '{1}',posicion = '{2}',nombre = '{3}',apellidos = '{4}',sexo = '{5}',email = '{6}', telefono = '{7}', organizacion = '{8}', disciplina = '{9}', url = '{10}', factura = '{11}', razonsocial = '{12}', rfc = '{13}', domiciliofiscal = '{14}' where pin='{0}'",
                           txtPass.Text.Trim(), txtPosicion.Text.Trim(), txtNombreU.Text.Trim(), txtApellido.Text.Trim(), cmbSexo.SelectedItem, txtEmail.Text.Trim(), txtTelefono.Text.Trim(), cmbOrganizacion.SelectedValue, txtDisciplina.Text.Trim(), txtURL.Text.Trim(), cmbFactura.SelectedItem, txtRazon.Text.Trim(), txtRFC.Text.Trim(), txtDomicilio.Text.Trim());

                if (data.ExecuteSQL(sql))
                {
                    // modificar foto
                    sql = string.Format("update usuarios set foto=@fotoimagen where pin={0}", txtPin.Text);
                    data.grabarImageServer(sql, pboxFoto.Image);

                    MessageBox.Show("El usuario ha sido modificado satisfactoriamente");

                }
            }

        }

        public void borrar()
        {
            if (txtPin.Text == "" || txtPass.Text == "" || txtPosicion.Text == "")
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Esta Seguro de Eliminar", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    sql = string.Format("delete from usuarios where pin={0}", txtPin.Text.Trim());
                    if (data.ExecuteSQL(sql))
                    {
                        MessageBox.Show("Usuario borrado");
                        Limpiar();
                    }
                }
            }
        }

        public void consulta()
        {
            DataTable Datos = new DataTable();

            if (txtPin.Text == "")
            {
                return;
            }

            sql = string.Format("select pass,posicion,nombre,apellido,sexo,email,telefono,organizacion,disciplina,url,factura,razon,rfc,domicilio from usuarios where pin={0}", txtPin.Text.Trim());
            Datos = data.listaTabla(sql);

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro ningun Admin", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
            else
            {
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
            sql = string.Format("select foto from usuarios where pin = {0}", txtPin.Text);
            pboxFoto.Image = data.getImageServer(sql);

        }

        private void dtgrUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string valor = dtgrUsuario.Rows[dtgrUsuario.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtPin.Text = valor;
            btnPerCon.PerformClick();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            data.llenarCombos(cmbOrganizacion, "select * from organizaciones order by id_organizacion", "id_organizacion", "nombre");
            data.llenarDatagrid(dtgrUsuario, "select * from usuarios order by pin where estatus = 'Activo'");
        }

        private void btnPerCon_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void dtgrUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string valor = dtgrUsuario.Rows[dtgrUsuario.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtPin.Text = valor;
                btnPerCon.PerformClick();
            }
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarEnteroPos(e);
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
    }
}
