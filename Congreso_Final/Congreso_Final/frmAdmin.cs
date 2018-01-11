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
    public partial class frmAdmin : Form
    {
        
        SQLServer data = new SQLServer();
        string sql;

        string ruta = "";
        string archivo;
        string rutacompleta;
        public string idvalor;


        public void Limpiar()
        {
            txtIdP.Text = "";
            txtNombreP.Text = "";
            txtApellidoP.Text = "";
            dtpFecha_c.Value = DateTime.Now;
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            txtIdP.Focus();
            data.llenarDatagrid(dtgrAdmin, "select id_admin,nombre,apellidos,email,celular,usuario,pass,creado from admins where id_admin={0} and estado='Activo'");
        }

        public void agregar()
        {
            if (txtIdP.Text == "" || txtNombreP.Text == "" || txtApellidoP.Text == "")
            {
                return;
            }
            else
            {
                sql = string.Format("insert into admins(nombre,apellidos,email,celular,usuario,pass) values('{1}','{2}','{3}','{4}','{5}','{6}')",
                            txtNombreP.Text.Trim(), txtApellidoP.Text.Trim(), txtEmail.Text.Trim(), txtCelular.Text.Trim(), txtUser.Text.Trim(), txtPass.Text.Trim());
            }
        }

        public void modificar()
        {
            /*  Falta
            - Validar Blancos
            - Verificar que no exista el id.
                          
           */
            if (txtIdP.Text == "" || txtNombreP.Text == "" || txtApellidoP.Text == "")
            {
                return;
            }
            else
            {
                sql = String.Format("update admins set nombre = '{1}',apellidos = '{2}',email = '{3}',celular = '{4}',usuario = '{5}',pass = '{6}' where id_admin='{0}'",
                           txtNombreP.Text.Trim(), txtApellidoP.Text.Trim(), txtEmail.Text.Trim(), txtCelular.Text.Trim(), txtUser.Text.Trim(), txtPass.Text.Trim());

            }
        }

        public void consulta()
        {
            DataTable Datos = new DataTable();

            if (txtIdP.Text == "")
            {
                return;
            }

            sql = string.Format("select * from admins where id_admin={0}", txtIdP.Text.Trim());
            Datos = data.listaTabla(sql);

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro ningun Admin", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
            else
            {
                txtNombreP.Text = Datos.Rows[0][1].ToString();
                txtApellidoP.Text = Datos.Rows[0][2].ToString();
                txtEmail.Text = Datos.Rows[0][3].ToString();
                txtCelular.Text = Datos.Rows[0][4].ToString();
                txtUser.Text = Datos.Rows[0][5].ToString();
                txtPass.Text = Datos.Rows[0][6].ToString();
                dtpFecha_c.Text = Datos.Rows[0][7].ToString();
            }

        }

        public void borrar()
        {
            if (txtIdP.Text == "" || txtNombreP.Text == "" || txtApellidoP.Text == "")
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Esta Seguro de Eliminar", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    sql = string.Format("delete from admins where id_admin={0}", txtIdP.Text.Trim());
                    if (data.ExecuteSQL(sql))
                    {
                        MessageBox.Show("Registro borrado");
                        Limpiar();
                    }
                }
            }
        }

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            data.llenarDatagrid(dtgrAdmin, "select id_admin,nombre,apellidos,email,celular,usuario,pass,creado from admins where and estatus='Activo'");
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonal_Load_1(object sender, EventArgs e)
        {
            data.llenarDatagrid(dtgrAdmin, "select id_admin,nombre,apellidos,email,celular,usuario,pass,creado from admins where estatus='Activo'");
        }

        private void txtIdP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarEnteroPos(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarTelefono(e, txtCelular);
        }

        private void txtNombreP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e,txtNombreP);
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e,txtApellidoP);
        }


        private void dtgrPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string valor = dtgrAdmin.Rows[dtgrAdmin.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtIdP.Text = valor;
                btnPerCon.PerformClick();
            }
        }

        private void btnPerAlta_Click_1(object sender, EventArgs e)
        {
            agregar();
            data.llenarDatagrid(dtgrAdmin, "select id_admin,nombre,apellidos,email,celular,usuario,pass,creado from admins where estatus='Activo'");
        }

        private void btnPerBaja_Click_1(object sender, EventArgs e)
        {
            borrar();
            data.llenarDatagrid(dtgrAdmin, "select id_admin,nombre,apellidos,email,celular,usuario,pass,creado from admins where estatus='Activo'");
        }

        private void btnPerMod_Click_1(object sender, EventArgs e)
        {
            modificar();
            data.llenarDatagrid(dtgrAdmin, "select id_admin,nombre,apellidos,email,celular,usuario,pass,creado from admins where estatus='Activo'");
        }

        private void btnPerCon_Click_1(object sender, EventArgs e)
        {
            consulta();
            data.llenarDatagrid(dtgrAdmin, "select id_admin,nombre,apellidos,email,celular,usuario,pass,creado from admins where estatus='Activo'");
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dtgrPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string valor = dtgrAdmin.Rows[dtgrAdmin.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtIdP.Text = valor;
            btnPerCon.PerformClick();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarCorreo(e, txtEmail);
        }
    }
}
