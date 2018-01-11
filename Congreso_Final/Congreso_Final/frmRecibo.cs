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
    public partial class frmRecibo : Form
    {
        SQLServer data = new SQLServer();
        public SqlCommand cmd;
        public SqlConnection cnn;
        string sql;

        string ruta = "";
        string archivo;
        string rutacompleta;
        public string idvalor;

        public frmRecibo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su recibo ha sido enviado con exito \nEn verificacion para la activacion de membresia");
            sql = string.Format("update miembros set recibo=@fotoimagen where id_miembro={0}");
            data.grabarImageServer(sql, pboxFoto.Image);
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



    }
}
