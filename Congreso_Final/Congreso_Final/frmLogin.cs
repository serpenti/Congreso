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
using Microsoft.VisualBasic;

namespace Congreso_Final
{
    public partial class frmLogin : Form
    {
        SQLServer data = new SQLServer();
        public SqlCommand cmd;
        public SqlConnection cnn;
        string sql;
        public static string userLogin;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUsuarioNuevo ventana = new frmUsuarioNuevo();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable Datos = new DataTable();
            Boolean boo = true;
            
            if (txtUsuario.Text == "" || txtContra.Text == "")
            {
                MessageBox.Show("Ingrese un usuario y/o una contraseña");
            }
            else
            {
                if (Information.IsNumeric(txtUsuario.Text.Trim()))
                {
                    boo = false;
                    sql = string.Format("select pin, pass from usuarios where pin = '{0}' and pass = '{1}'", Convert.ToString(txtUsuario.Text.Trim()), Convert.ToString(txtContra.Text.Trim()));
                    data.listaTabla(sql);

                    if (boo == false)
                    {
                        userLogin = txtUsuario.Text.Trim();
                        frmMenuUsuario ventana = new frmMenuUsuario();
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario y/o contraseña no valida", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Text = "";
                        txtContra.Text = "";
                    }

                }
                else
                {
                    sql = string.Format("select usuario, pass from admins where usuario = '{0}' and pass = '{1}'", Convert.ToString(txtUsuario.Text.Trim()), txtContra.Text.Trim());
                    Datos = data.listaTabla(sql);

                    if (Datos.Rows.Count == 0)
                    {
                        MessageBox.Show("Nombre de usuario y/o contraseña no valida", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Text = "";
                        txtContra.Text = "";
                    }
                    else
                    {
                        frmMenu ventana = new frmMenu();
                        ventana.Show();
                        this.Hide();
                    }

                }

            }

        }
    }
}
