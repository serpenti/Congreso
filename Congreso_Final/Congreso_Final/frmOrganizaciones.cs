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
    public partial class frmOrganizaciones : Form
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
            txtDireccion.Text = "";
            dtpFecha_c.Value = DateTime.Now;
            txtEstado.Text = "";
            txtCiudad.Text = "";
            txtPais.Text = "";
            txtIdP.Focus();
            data.llenarDatagrid(dtgrOrganizaciones, "select id_organizacion,nombre,direccion,ciudad,estado,pais,creado from organizaciones where estatus='Activo'");
        }

        public void agregar()
        {
            if (txtNombreP.Text == "")
            {
                return;
            }
            else
            {
                sql = string.Format("insert into admins(nombre,direccion,ciudad,estado,pais) values('{1}','{2}','{3}','{4}','{5}')",
                            txtNombreP.Text.Trim(), txtDireccion.Text.Trim(), txtCiudad.Text.Trim(), txtEstado.Text.Trim(), txtPais.Text.Trim());
            }
        }

        public void modificar()
        {
            /*  Falta
            - Validar Blancos
            - Verificar que no exista el id.
                          
           */
            if (txtIdP.Text == "" || txtNombreP.Text == "" || txtDireccion.Text == "")
            {
                return;
            }
            else
            {
                sql = String.Format("update organizaciones set nombre = '{1}',direccion = '{2}',ciudad = '{3}',estado= '{4}',pais = '{5}', where id_organizacion='{0}'",
                           txtNombreP.Text.Trim(), txtDireccion.Text.Trim(), txtCiudad.Text.Trim(), txtEstado.Text.Trim(), txtPais.Text.Trim());

            }
        }

        public void consulta()
        {
            DataTable Datos = new DataTable();

            if (txtIdP.Text == "")
            {
                return;
            }

                sql = string.Format("select * from organizaciones where id_organizacion={0}", 
                      txtIdP.Text.Trim(), txtNombreP.Text.Trim(), txtDireccion.Text.Trim(), txtCiudad.Text.Trim(), txtEstado.Text.Trim(), txtPais.Text.Trim());
                Datos = data.listaTabla(sql);

                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro ninguna Organizacion", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
                else
                {
                    txtNombreP.Text = Datos.Rows[0][1].ToString();
                    txtDireccion.Text = Datos.Rows[0][2].ToString();
                    txtCiudad.Text = Datos.Rows[0][3].ToString();
                    txtEstado.Text = Datos.Rows[0][4].ToString();
                    txtPais.Text = Datos.Rows[0][5].ToString();
                    dtpFecha_c.Text = Datos.Rows[0][6].ToString();
                }
               
        }

        public void borrar()
        {
            if (txtIdP.Text == "")
            {

            }
            else
            {
                if (MessageBox.Show("Esta Seguro de Eliminar", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    sql = string.Format("delete from organizaciones where id_organizacion={0}", txtIdP.Text.Trim());
                    if (data.ExecuteSQL(sql))
                    {
                        MessageBox.Show("Organizacion borrada");
                        Limpiar();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            data.llenarDatagrid(dtgrOrganizaciones, "select id_organizacion,nombre,direccion,ciudad,estado,pais,creado from organizaciones where estatus='Activo'");
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerAlta_Click_1(object sender, EventArgs e)
        {
            agregar();
            data.llenarDatagrid(dtgrOrganizaciones, "select id_organizacion,nombre,direccion,ciudad,estado,pais,creado from organizaciones where estatus='Activo'");
        }

        private void btnPerBaja_Click_1(object sender, EventArgs e)
        {
            borrar();
            data.llenarDatagrid(dtgrOrganizaciones, "select id_organizacion,nombre,direccion,ciudad,estado,pais,creado from organizaciones where estatus='Activo'");
        }

        private void btnPerMod_Click_1(object sender, EventArgs e)
        {
            modificar();
            data.llenarDatagrid(dtgrOrganizaciones, "select id_organizacion,nombre,direccion,ciudad,estado,pais,creado from organizaciones where estatus='Activo'");
        }

        private void btnPerCon_Click_1(object sender, EventArgs e)
        {
            consulta();
            data.llenarDatagrid(dtgrOrganizaciones, "select id_organizacion,nombre,direccion,ciudad,estado,pais,creado from organizaciones where estatus='Activo'");
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        public frmOrganizaciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dtgrOrganizaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string valor = dtgrOrganizaciones.Rows[dtgrOrganizaciones.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtIdP.Text = valor;
            btnPerCon.PerformClick();
        }

        private void dtgrOrganizaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string valor = dtgrOrganizaciones.Rows[dtgrOrganizaciones.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtIdP.Text = valor;
                btnPerCon.PerformClick();
            }
        }

        private void txtIdP_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validacion.validarEnteroPos(e);
        }

        private void txtNombreP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtNombreP);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtDireccion);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtCiudad);
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtEstado);
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtPais);
        }

        private void frmOrganizaciones_Load(object sender, EventArgs e)
        {
            data.llenarDatagrid(dtgrOrganizaciones, "select id_organizacion,nombre,direccion,ciudad,estado,pais,creado from organizaciones where estatus='Activo'");
        }
    }
}
