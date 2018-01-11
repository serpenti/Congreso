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

namespace Congreso_Final
{
    public partial class frmRegistros : Form
    {

        SQLServer data = new SQLServer();
        string sql;

        public void Limpiar()
        {
            txtIdA.Text = "";
            txtNombreA.Text = "";
            data.llenarDatagrid(dtgrPosicion, "select * from tipo_registros order by id_tipo_registro");
        }

        public void agregar()
        {
            if (txtIdA.Text == "")
            {
                return;
            }
            else
            {
                sql = string.Format("insert into tipo_registros(nombre) values('{1}')",
                        txtIdA.Text.Trim(), txtNombreA.Text.Trim());
            }

            if (data.ExecuteSQL(sql))
            {
                MessageBox.Show("Registro agregado con exito");
                Limpiar();
            }
        }

        public void modificar()
        {
            /*  Falta
            - Validar Blancos
            - Verificar que no exista el id.
                          
           */
            if (txtIdA.Text == "")
            {
                return;
            }
            else
            {
                sql = String.Format("update tipo_registro set nombre = '{1}' where id_tipo_registro='{0}'",
                               txtIdA.Text.Trim(), txtNombreA.Text.Trim());
                if (data.ExecuteSQL(sql) && txtIdA != null)
                {

                    MessageBox.Show("El registro ha sido modificado satisfactoriamente");

                }
            }
        }

        public void consulta()
        {
            DataTable Datos = new DataTable();

            if (txtIdA.Text == "")
            {
                return;
            }
            else
            {
                sql = string.Format("select * from tipo_registros where id_tipo_registro={0}", txtIdA.Text.Trim());
                Datos = data.listaTabla(sql);
            }

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro ningun registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
            else
            {
                txtNombreA.Text = Datos.Rows[0][1].ToString();
            }

        }

        public void borrar()
        {
            if (MessageBox.Show("Esta Seguro de Eliminar", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                sql = string.Format("delete from tipo_registros where id_tipo_registro={0}", txtIdA.Text.Trim());
                if (data.ExecuteSQL(sql))
                {
                    MessageBox.Show("Registro borrado");
                    Limpiar();
                }
            }
        }


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dtgrPosicion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string valor = dtgrPosicion.Rows[dtgrPosicion.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtIdA.Text = valor;
                btnPerCon.PerformClick();
            }

        }

        private void btnLimpiarA_Click(object sender, EventArgs e)
        {
            Limpiar();
            data.llenarDatagrid(dtgrPosicion, "select * from tipo_registros order by id_tipo_registro");
        }

        public frmRegistros()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerAlta_Click_1(object sender, EventArgs e)
        {
            agregar();
            data.llenarDatagrid(dtgrPosicion, "select * from tipo_registros order by id_tipo_registro");
        }

        private void btnPerBaja_Click_1(object sender, EventArgs e)
        {
            borrar();
            data.llenarDatagrid(dtgrPosicion, "select * from posicion_titulo order by id_titulo");
        }

        private void btnPerMod_Click_1(object sender, EventArgs e)
        {
            modificar();
            data.llenarDatagrid(dtgrPosicion, "select * from tipo_registros order by id_tipo_registro");
        }

        private void btnPerCon_Click_1(object sender, EventArgs e)
        {
            consulta();
            data.llenarDatagrid(dtgrPosicion, "select * from tipo_registros order by id_tipo_registro");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistros_Load_1(object sender, EventArgs e)
        {
            data.llenarDatagrid(dtgrPosicion, "select * from tipo_registros order by id_tipo_registro");
        }

        private void dtgrPosicion_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string valor = dtgrPosicion.Rows[dtgrPosicion.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtIdA.Text = valor;
            btnPerCon.PerformClick();
        }
    }
}
