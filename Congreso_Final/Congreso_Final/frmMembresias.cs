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
    public partial class frmMembresias : Form
    {
        SQLServer data = new SQLServer();
        string sql;
        
        public void Limpiar()
        {
            txtIdA.Text = "";
            txtNombreA.Text = "";
            txtDescuento.Text = "";
            txtCosto.Text = "";
            data.llenarDatagrid(dtgrArea, "select * from tipo_membresias order by id_tipo");
        }

        public void agregar()
        {
            if (txtIdA.Text == "" || txtNombreA.Text == "" || txtCosto.Text == "")
            {
                return;
            }
            else
            {
                sql = string.Format("insert into tipo_membresias(nombre,costo,descuento_congreso) values('{1}','{2}','{3}')",
                        txtIdA.Text.Trim(), txtNombreA.Text.Trim(),txtCosto.Text.Trim(),txtDescuento.Text.Trim());
            }

            if (data.ExecuteSQL(sql))
            {
                MessageBox.Show("Membresia agregada con exito");
                Limpiar();
            }
        }

        public void modificar()
        {
            /*  Falta
            - Validar Blancos
            - Verificar que no exista el id.
                          
           */
            if (txtIdA.Text == "" || txtNombreA.Text == "" || txtCosto.Text == "")
            {
                return;
            }
            else
            {
                sql = String.Format("update tipo_membresias set nombre = '{1}', costo = '{2}', descuento_congreso = '{3}' where id_tipo='{0}'",
                               txtIdA.Text.Trim(), txtNombreA.Text.Trim(), txtCosto.Text.Trim(), txtDescuento.Text.Trim());
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
                sql = string.Format("select * from tipo_membresias where id_tipo={0}", txtIdA.Text.Trim());
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
                txtCosto.Text = Datos.Rows[0][2].ToString();
                txtDescuento.Text = Datos.Rows[0][3].ToString();
            }

        }

        public void borrar()
        {
            if (MessageBox.Show("Esta Seguro de Eliminar", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                sql = string.Format("delete from tipo_membresias where id_tipo={0}", txtIdA.Text.Trim());
                if (data.ExecuteSQL(sql))
                {
                    MessageBox.Show("Registro borrado");
                    Limpiar();
                }
            }
        }

        public frmMembresias()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerAlta_Click(object sender, EventArgs e)
        {
            agregar();
            data.llenarDatagrid(dtgrArea, "select * from tipo_membresias order by id_tipo");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPerBaja_Click(object sender, EventArgs e)
        {
            borrar();
            data.llenarDatagrid(dtgrArea, "select * from tipo_membresias order by id_tipo");
        }

        private void btnPerMod_Click(object sender, EventArgs e)
        {
            modificar();
            data.llenarDatagrid(dtgrArea, "select * from tipo_membresias order by id_tipo");
        }

        private void btnPerCon_Click(object sender, EventArgs e)
        {
            consulta();
            data.llenarDatagrid(dtgrArea, "select * from tipo_membresias order by id_tipo");
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            data.llenarDatagrid(dtgrArea, "select * from tipo_membresias order by id_tipo");
        }

        private void dtgrArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string valor = dtgrArea.Rows[dtgrArea.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtIdA.Text = valor;
                btnPerCon.PerformClick();
            }

        }

        private void btnLimpiarA_Click(object sender, EventArgs e)
        {
            Limpiar();
            data.llenarDatagrid(dtgrArea, "select * from tipo_membresias order by id_tipo");
        }

        private void dtgrArea_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string valor = dtgrArea.Rows[dtgrArea.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtIdA.Text = valor;
            btnPerCon.PerformClick();
        }
    }
}
