using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Congreso_Final
{
    class SQLServer
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public SqlDataReader reader;

        DataTable dt;
        SqlDataAdapter da;

        public BindingSource BindingSource1 = new BindingSource();
        //public string SQLString = "";


        // toma la cadena de conexion de una clase DatosConexion;
        //string cadena = DatosConexion.cadenaconexion;   
        string cadena = @"Data Source=DESKTOP-9UFP6OV\SQLEXPRESS;Initial Catalog=congreso;Integrated Security=True";
        //string cadena = DatosConexion.getCadenaConexion();

        public SQLServer()
        {
            //open();
        }

        public void Abrir_bd()
        {
            try
            {
                cnn = new SqlConnection();
                cnn.ConnectionString = cadena;
                cnn.Open();
                //MessageBox.Show("Conexión Exitosa");

            }
            catch (Exception)
            {
                MessageBox.Show("Problema en la Base de Datos");
            }

        }

        public void Cerrar_bd()
        {

            if (cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            if (cmd != null)
                cmd.Dispose();
            if (da != null)
                da.Dispose();
        }

        public string TestConexion()
        {
            string cadena2 = "";
            try
            {
                cnn = new SqlConnection();
                cnn.ConnectionString = cadena;
                cnn.Open();
                //MessageBox.Show("Conexión Exitosa");
                cadena2 = "Conexion Exitosa";
            }
            catch (Exception)
            {
                //MessageBox.Show("Problema en la Base de Datos");
                cadena2 = "Problema en la base de datos";
            }
            return cadena2;
        }

        public bool existe(string sql)
        {
            bool retorno = false;
            try
            {
                Abrir_bd();
                cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        retorno = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                retorno = false;
            }
            finally
            {
                Cerrar_bd();
            }
            return retorno;

        }


        public bool ExecuteSQL(string sql)
        {
            bool retorno = false;
            try
            {
                Abrir_bd();
                cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cerrar_bd();
            }
            return retorno;
        }

        public string ExecuteScalar(string sql)
        {
            string valor = "0";
            try
            {
                Abrir_bd();
                cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
                string getValue = cmd.ExecuteScalar().ToString();

                if (getValue != null)
                {
                    valor = getValue.ToString();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cerrar_bd();
            }
            return valor;
        }

        public IEnumerable<IDataRecord> ExecuteReader(string sql)
        {
            cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            //reader = cmd.ExecuteReader();

            using (var reader = cmd.ExecuteReader())
            {
                //bool encontrado = false;
                while (reader.Read())
                {
                    yield return (IDataRecord)reader;
                    //encontrado = true;
                }

            }

        }

        public DataTable listaTabla(string sql)
        {
            try
            {
                Abrir_bd();
                dt = new DataTable();
                da = new SqlDataAdapter(sql, cnn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta " + ex.Message);
            }
            finally
            {
                Cerrar_bd();
                dt.Dispose();
            }
            da.Dispose();
            return dt;
        }


        public Image getImageServer(string sql)
        {
            Image img = null;
            Abrir_bd();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            try
            {
                byte[] imgArr = (byte[])cmd.ExecuteScalar();
                using (var stream = new MemoryStream(imgArr))
                {
                    if (stream.Length != 0)
                    {
                        img = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Cerrar_bd();
            }
            return img;
        }


        public void grabarImageServer(string sql, Image img)
        {

            if (img == null)
                return;

            Abrir_bd();
            // string sql = string.Format("update usuarios set foto=@fotoimagen where id={0}", txtId.Text);
            cmd = new SqlCommand(sql, cnn);
            try
            {
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                cmd.Parameters.AddWithValue("@fotoimagen", aByte);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cerrar_bd();
            }


        }


        //  *****************     Otras Funciones     *********************+

        public void llenarCombos(System.Windows.Forms.ComboBox combo, string sql, string pk, string display)
        {

            try
            {
                Abrir_bd();
                da = new SqlDataAdapter(sql, cnn);
                dt = new DataTable();
                da.Fill(dt);
                combo.DataSource = dt;
                combo.ValueMember = pk;
                combo.DisplayMember = display;
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta " + ex.Message);
            }
            finally
            {
                Cerrar_bd();
            }

        }

        public void llenarDatagrid(DataGridView grid, string sql)
        {
            Abrir_bd();
            try
            {
                BindingSource1.DataSource = listaTabla(sql);
                grid.DataSource = BindingSource1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cerrar_bd();
            }
        }


        public void aplicarFiltro(DataGridView grid, string filtro)
        {
            //Nota: Recordar que se debe asignar el BindingSource al DataGridView antes de realizar este procedimiento por medio del DataSource

            try
            {
                BindingSource1.Filter = filtro;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
