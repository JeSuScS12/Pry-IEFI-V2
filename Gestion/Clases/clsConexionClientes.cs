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

        public void CargarNombres(ComboBox cmbClientes)
        {
            try
            {
                conectar = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conectar;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT DISTINCT Cliente FROM Firmas";
                conectar.Open();

                OleDbDataReader reader = comando.ExecuteReader();
                cmbClientes.Items.Clear();
                while (reader.Read())
                {
                    string cliente = reader["Cliente"].ToString();
                    cmbClientes.Items.Add(cliente);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void MostrarFirma(string cliente, PictureBox picFirma)
        {
            try
            {
                conectar = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conectar;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Firma FROM Firmas WHERE Cliente = ?";

                comando.Parameters.AddWithValue("@Cliente", cliente);
                conectar.Open();

                OleDbDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    byte[] firmaBytes = (byte[])reader["Firma"];

                    using (MemoryStream ms = new MemoryStream(firmaBytes))
                    {
                        Image firmaImagen = Image.FromStream(ms);
                        picFirma.Image = firmaImagen; // muestra la firma en el pic
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la firma.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la firma: " + ex.Message);
            }
        }
    }
}
