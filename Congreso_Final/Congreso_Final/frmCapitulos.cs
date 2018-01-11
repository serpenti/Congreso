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
    public partial class frmCapitulos : Form
    {
        SQLServer data = new SQLServer();
        string sql;

        string ruta = "";
        string archivo;
        string rutacompleta;
        public string idvalor;

        public frmCapitulos()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtIdCap.Text = "";
            txtNombreCap.Text = "";
            data.llenarCombos(cmbOrganizacion, "select * from organizacion order by id_organizacion", "id_organizacion", "nombre");
            dtpFecha_c.Value = DateTime.Now;
            txtPresidente.Text = "";
            txtEncargado.Text = "";
            txtComentario.Text = "";
            txtIdCap.Focus();
            data.llenarDatagrid(dtgrCapitulos, "select id_capitulo,nombre,organizacion,presidente,encargado,comentarios,creado from capitulos where estatus='Activo'");
        }

        public void agregar()
        {
            if (txtNombreCap.Text == "" || txtComentario.Text == "" || txtPresidente.Text == "" || txtEncargado.Text == "")
            {
                return;
            }
            else
            {
                sql = string.Format("insert into capitulos(nombre,organizacion,presidente,encargado,comentarios,creado) values('{1}','{2}','{3}','{4}','{5}','{6}')",
                            txtNombreCap.Text.Trim(), cmbOrganizacion.SelectedValue, txtPresidente.Text.Trim(), txtEncargado.Text.Trim(), txtComentario.Text.Trim());
            }
        }

        public void modificar()
        {
            /*  Falta
            - Validar Blancos
            - Verificar que no exista el id.
                          
           */
            if (txtIdCap.Text == "" || txtNombreCap.Text == "" || txtComentario.Text == "" || txtPresidente.Text == "" || txtEncargado.Text == "")
            {
                return;
            }
            else
            {
                sql = String.Format("update capitulos set nombre = '{1}',organizacion = '{2}',presidente = '{3}',encargado= '{4}',comentarios = '{5}', where id_capitulo='{0}'",
                           txtNombreCap.Text.Trim(), cmbOrganizacion.SelectedValue, txtPresidente.Text.Trim(), txtEncargado.Text.Trim(), txtComentario.Text.Trim());

            }
        }

        public void consulta()
        {
            DataTable Datos = new DataTable();

            if (txtIdCap.Text == "")
            {
                return;
            }

            sql = string.Format("select * from capitulos where id_capitulo={0}",
                  txtIdCap.Text.Trim(), txtNombreCap.Text.Trim(), cmbOrganizacion.SelectedValue, txtPresidente.Text.Trim(), txtEncargado.Text.Trim(), txtComentario.Text.Trim());
            Datos = data.listaTabla(sql);

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro ninguna Capitulo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
            else
            {
                txtNombreCap.Text = Datos.Rows[0][1].ToString();
                cmbOrganizacion.SelectedValue = Datos.Rows[0][2].ToString();
                txtPresidente.Text = Datos.Rows[0][3].ToString();
                txtEncargado.Text = Datos.Rows[0][4].ToString();
                txtComentario.Text = Datos.Rows[0][5].ToString();
                dtpFecha_c.Text = Datos.Rows[0][6].ToString();
            }

        }

        public void borrar()
        {
            if (txtIdCap.Text == "")
            {

            }
            else
            {
                if (MessageBox.Show("¿Esta seguro de eliminar este capitulo?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    sql = string.Format("delete from capitulos where id_capitulo={0}", txtIdCap.Text.Trim());
                    if (data.ExecuteSQL(sql))
                    {
                        MessageBox.Show("Capitulo borrado");
                        Limpiar();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            data.llenarDatagrid(dtgrCapitulos, "select id_capitulo,nombre,organizacion,presidente,encargado,comentarios,creado from capitulos where estatus='Activo'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerAlta_Click(object sender, EventArgs e)
        {
            agregar();
            data.llenarDatagrid(dtgrCapitulos, "select id_capitulo,nombre,organizacion,presidente,encargado,comentarios,creado from capitulos where estatus='Activo'");
        }

        private void btnPerBaja_Click(object sender, EventArgs e)
        {
            borrar();
            data.llenarDatagrid(dtgrCapitulos, "select id_capitulo,nombre,organizacion,presidente,encargado,comentarios,creado from capitulos where estatus='Activo'");
        }

        private void btnPerMod_Click(object sender, EventArgs e)
        {
            modificar();
            data.llenarDatagrid(dtgrCapitulos, "select id_capitulo,nombre,organizacion,presidente,encargado,comentarios,creado from capitulos where estatus='Activo'");
        }

        private void btnPerCon_Click(object sender, EventArgs e)
        {
            consulta();
            data.llenarDatagrid(dtgrCapitulos, "select id_capitulo,nombre,organizacion,presidente,encargado,comentarios,creado from capitulos where estatus='Activo'");
        }

        private void txtIdCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarEnteroPos(e);
        }

        private void txtNombreCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtNombreCap);
        }

        private void txtPresidente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtPresidente);
        }

        private void txtEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtEncargado);
        }

        private void dtgrCapitulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string valor = dtgrCapitulos.Rows[dtgrCapitulos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtIdCap.Text = valor;
            btnPerCon.PerformClick();
        }

        private void dtgrCapitulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string valor = dtgrCapitulos.Rows[dtgrCapitulos.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtIdCap.Text = valor;
                btnPerCon.PerformClick();
            }
        }

        private void frmCapitulos_Load(object sender, EventArgs e)
        {
            data.llenarDatagrid(dtgrCapitulos, "select id_capitulo,nombre,organizacion,presidente,encargado,comentarios,creado from capitulos where estatus='Activo'");
        }
    }
}
