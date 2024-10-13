using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Clases
{
    internal class clsConexionVentas
    {
        OleDbCommand comando;
        OleDbConnection conectar;
        OleDbDataAdapter adaptador;

        string cadena;

        public clsConexionVentas()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BD/Ventas.accdb";
        }

        //Limpiar Panel
        public void ControlPanel(Panel panel)
        {
            if (panel.Controls.Count > 0)
            {
                // Eliminar todos los controles dentro del panel
                panel.Controls.Clear();
            }
        }

        //Cargar ComboBox
        public void CargarCMB(ComboBox combo)
        {
            conectar = new OleDbConnection(cadena);
            try
            {
                conectar.Open();
                string consulta = "SELECT Nombre  FROM Categorias";
                comando = new OleDbCommand(consulta, conectar);
                OleDbDataReader reader = comando.ExecuteReader();

                // Limpia los items del ComboBox antes de agregar nuevos datos
                combo.Items.Clear();
                // Agrega los datos al ComboBox
                while (reader.Read())
                {
                    combo.Items.Add(reader["Nombre"].ToString());
                }
                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Prueba DataSet
        public DataTable EnviarModulos()
        {
            conectar = new OleDbConnection(cadena);
            string consulta = "SELECT IdProducto,Nombre,Descripcion,Precio FROM Productos";
            DataTable dt = new DataTable();
            try
            {
                conectar.Open();
                comando = new OleDbCommand(consulta, conectar);
                adaptador = new OleDbDataAdapter(comando);

                // Llenar el DataTable con los datos obtenidos
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
            return dt;
        }

        //Prueba BUsqueda Item
        public DataTable EnviarModulos(string item)
        {
            conectar = new OleDbConnection(cadena);
            string consulta = $"SELECT IdProducto,Nombre,Descripcion,Precio FROM Productos where Nombre like '%{item}%'";
            DataTable dt = new DataTable();
            try
            {
                conectar.Open();
                comando = new OleDbCommand(consulta, conectar);
                adaptador = new OleDbDataAdapter(comando);

                // Llenar el DataTable con los datos obtenidos
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        //Prueba Busqueda Categoria
        public DataTable EnviarModulos(int categoria)
        {
            conectar = new OleDbConnection(cadena);
            string consulta = $"SELECT IdProducto,Nombre,Descripcion,Precio FROM Productos where Categoria = {categoria}";
            DataTable dt = new DataTable();
            try
            {
                conectar.Open();
                comando = new OleDbCommand(consulta, conectar);
                adaptador = new OleDbDataAdapter(comando);

                // Llenar el DataTable con los datos obtenidos
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

    }
}
