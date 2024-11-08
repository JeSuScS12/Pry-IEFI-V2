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
    internal class clsConexionClientes
    {
        OleDbCommand comando;
        OleDbConnection conectar;
        OleDbDataAdapter adaptador;

        string cadena;

        public clsConexionClientes()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BD/DB.accdb";
        }

        public void GuardarFirma(string cliente, byte[] firmaBytes)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                // En la tabla Firmas hay un campo "Firma" del tipo Objeto OLE que es para guardar las firmas
                conexion.Open();
                using (OleDbCommand comando = new OleDbCommand("INSERT INTO Firmas (Cliente, Firma) VALUES (?, ?)", conexion))
                {
                    comando.Parameters.AddWithValue("@Cliente", cliente);
                    comando.Parameters.AddWithValue("@Firma", firmaBytes);
                    comando.ExecuteNonQuery();
                }
            }
        }


        public void MostrarFirma(int id, PictureBox picFirma)
        {
            try
            {
                using (OleDbConnection conectar = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conectar;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = $"SELECT Firma FROM Cliente WHERE IdCliente = {id}";

                        conectar.Open();

                        OleDbDataReader reader = comando.ExecuteReader();
                        if (reader.Read())
                        {
                            // Verifica si la imagen no es DBNull
                            if (reader["Firma"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["Firma"];

                                // Convierte el array de bytes a una imagen
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image imagen = Image.FromStream(ms);
                                    picFirma.Image = imagen; // Muestra la imagen en el PictureBox
                                    picFirma.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El cliente no tiene FIRMA registrada.");
                                picFirma.Image = null; // Limpia el PictureBox si no hay imagen
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente con el DNI proporcionado.");
                            picFirma.Image = null; // Limpia el PictureBox si no hay cliente
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la imagen: " + ex.Message);
            }
        }

        //Metodo Cargar Clientes en DGV
        public void CargarClientes(DataGridView tabla)
        {
            conectar = new OleDbConnection(cadena);
            try
            {
                conectar.Open();
                string consulta = "select c.IdCliente as ID, c.Nombre as Nombre, c.DNI, c.Correo, c.Telefono, e.Nombre as Estado from Cliente as c inner join Estado as e on c.IdEstado = e.IdEstado;";   

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

        //Metodo cargar Estados a ComboBox
        public void CargarEstados(ComboBox cmbClientes)
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
                cmbClientes.Items.Clear();
                while (reader.Read())
                {
                    string cliente = reader["Nombre"].ToString();
                    cmbClientes.Items.Add(cliente);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Registrar Cliente
        public void GuardarDatos(string nombre, string dni, string direcc, string email, string tel, int estado, PictureBox pictureBox)
        {
            // Consulta SQL para insertar los datos
            string consulta = $"INSERT INTO Cliente (Nombre, DNI, Correo, Telefono, IdEstado, Firma) VALUES ('{nombre}','{dni}','{email}','{tel}',{estado},@Imagen)";

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

        public void ModificarDatos(string nombre, string dni, string direcc, string email, string tel, int estado, PictureBox pictureBox)
        {
            // Consulta SQL para insertar los datos
            string consulta = $"update Cliente set Nombre='{nombre}', DNI='{dni}', Correo='{email}', Telefono='{tel}', IdEstado={estado}, Firma=@Imagen where DNI = '{dni}'";

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
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Datos del Cliente modificados correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró al Cliente a modificar.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar los datos: " + ex.Message);
            }

        }

        public void DNI(string dni)
        {
            string consulta = $"select Nombre, DNI,Telefono, Direccion from Cliente where DNI = '{dni}'";
            conectar = new OleDbConnection(cadena);
            comando = new OleDbCommand(consulta, conectar);
            try
            {
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    cslClienteCompra.DNI = lector.GetString(1);
                    cslClienteCompra.Cliente = lector.GetString(0);
                    cslClienteCompra.Direccion = lector.GetString(3);
                    cslClienteCompra.Telefono = lector.GetString(2);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }



    }
}
