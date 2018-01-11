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
    public partial class frmPosicion : Form
    {
        SQLServer data = new SQLServer();
        string sql;

        public void Limpiar()
        {
            txtIdA.Text = "";
            txtNombreA.Text = "";
            data.llenarDatagrid(dtgrPosicion, "select * from posicion_titulo order by id_titulo");
        }

        public void agregar()
        {
            if (txtIdA.Text == "")
            {
                return;
            }
            else
            {
                sql = string.Format("insert into posicion_titulo(titulo) values('{1}')",
                        txtIdA.Text.Trim(), txtNombreA.Text.Trim());
            }

            if (data.ExecuteSQL(sql))
            {
                MessageBox.Show("Posicion agregada con exito");
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
                sql = String.Format("update posicion_titulo set titulo = '{1}' where id_titulo='{0}'",
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
                sql = string.Format("select * from posicion_titulo where id_titulo={0}", txtIdA.Text.Trim());
                Datos = data.listaTabla(sql);
            }

            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontro Ningun Usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                sql = string.Format("delete from posicion_titulo where id_titulo={0}", txtIdA.Text.Trim());
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

        public frmPosicion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPosBaja_Click_1(object sender, EventArgs e)
        {
            borrar();
            data.llenarDatagrid(dtgrPosicion, "select * from posicion_titulo order by id_titulo");
        }

        private void frmPosicion_Load_1(object sender, EventArgs e)
        {
            data.llenarDatagrid(dtgrPosicion, "select * from posicion_titulo order by id_titulo");
        }

        private void btnPosAlta_Click(object sender, EventArgs e)
        {
            agregar();
            data.llenarDatagrid(dtgrPosicion, "select * from posicion_titulo order by id_titulo");
        }

        private void btnPosMod_Click(object sender, EventArgs e)
        {
            modificar();
            data.llenarDatagrid(dtgrPosicion, "select * from posicion_titulo order by id_titulo");
        }

        private void btnPosCon_Click(object sender, EventArgs e)
        {
            consulta();
            data.llenarDatagrid(dtgrPosicion, "select * from posicion_titulo order by id_titulo");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarA_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            data.llenarDatagrid(dtgrPosicion, "select * from posicion_titulo order by id_titulo");
        }

        private void dtgrPosicion_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string valor = dtgrPosicion.Rows[dtgrPosicion.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtIdA.Text = valor;
                btnPosCon.PerformClick();
            }
        }

        private void dtgrPosicion_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string valor = dtgrPosicion.Rows[dtgrPosicion.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtIdA.Text = valor;
            btnPosCon.PerformClick();
        }

        private void txtIdA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarEnteroPos(e);
        }

        private void txtNombreA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.validarLetra(e, txtNombreA);
        }
    }
}
