using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Net;


namespace Gestion.Clases
{
    internal class clsUsuarios
    {
        OleDbCommand comando;
        OleDbConnection conectar;
        OleDbDataAdapter adaptador;

        string cadena;

        public clsUsuarios()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BD/DB.accdb";
        }

        public void CargarUsuarios(DataGridView tabla)
        {
            conectar = new OleDbConnection(cadena);
            try
            {
                conectar.Open();
                string consulta = "select c.IdUsuario as ID, c.Nombre as Nombre, c.DNI, c.Correo, c.Telefono, e.Nombre as Estado from Usuarios as c inner join Estado as e on c.IdEstado = e.IdEstado;";

                adaptador = new OleDbDataAdapter(consulta, conectar);
                DataTable dataTable = new DataTable();
                adaptador.Fill(dataTable);
                tabla.DataSource = dataTable;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }


        public void MostrarAvatar(int id)
        {
            try
            {
                using (OleDbConnection conectar = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conectar;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = $"SELECT ImgPerfil FROM Usuarios WHERE IdUsuario = {id}";

                        conectar.Open();

                        OleDbDataReader reader = comando.ExecuteReader();
                        if (reader.Read())
                        {
                            // Verifica si la imagen no es DBNull
                            if (reader["ImgPerfil"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["ImgPerfil"];

                                // Convierte el array de bytes a una imagen
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image imagen = Image.FromStream(ms);
                                    clsUserGlobal.foto = imagen;
                                }
                            }
                            else clsUserGlobal.foto = Properties.Resources.FondoCircular;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente con el DNI proporcionado.");
                            clsUserGlobal.foto = null; // Limpia el PictureBox si no hay cliente
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la imagen: " + ex.Message);
            }
        }

        public void GuardarDatos(string nombre, string dni, string direcc, string email, string tel, int estado,int cargo, PictureBox pictureBox)
        {
            // Consulta SQL para insertar los datos
            string consulta = $"INSERT INTO Usuarios (Nombre, DNI, Correo, Telefono, IdEstado,IdCargo, ImgPerfil) VALUES ('{nombre}','{dni}','{email}','{tel}',{estado},{cargo},@Imagen)";

            conectar = new OleDbConnection(cadena);

            try
            {
                conectar.Open();
                comando = new OleDbCommand(consulta, conectar);

                // Convertir la imagen del PictureBox a un array de bytes
                if (pictureBox.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);  // Guardar imagen en formato binario
                    byte[] imgBytes = ms.ToArray();
                    comando.Parameters.AddWithValue("@Imagen", imgBytes);
                }
                else
                {
                    comando.Parameters.AddWithValue("@Imagen", DBNull.Value);  // Si no hay imagen
                }

                // Ejecutar la consulta
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto guardado correctamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }




        public void CargarEstados(ComboBox cmb)
        {
            try
            {
                conectar = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conectar;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select Nombre FROM Estado";
                conectar.Open();

                OleDbDataReader reader = comando.ExecuteReader();
                cmb.Items.Clear();
                while (reader.Read())
                {
                    string cliente = reader["Nombre"].ToString();
                    cmb.Items.Add(cliente);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarCargos(ComboBox cmb)
        {
            try
            {
                conectar = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conectar;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select Nombre FROM Cargos";
                conectar.Open();

                OleDbDataReader reader = comando.ExecuteReader();
                cmb.Items.Clear();
                while (reader.Read())
                {
                    string cliente = reader["Nombre"].ToString();
                    cmb.Items.Add(cliente);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
