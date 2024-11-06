using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Clases
{
    internal class clsConexionProveedores
    {
        OleDbCommand comando;
        OleDbConnection conectar;
        OleDbDataAdapter adaptador;

        string cadena;

        public clsConexionProveedores()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BD/DB.accdb";
        }
        public void CargarCategorias(ComboBox cmbCategorias)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT IdCategoria, Categoria FROM CategoriasProveedores";
                        conexion.Open();

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbCategorias.DataSource = dt;
                            cmbCategorias.DisplayMember = "Categoria";
                            cmbCategorias.ValueMember = "IdCategoria";
                            cmbCategorias.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarEstados(ComboBox cmbEstados)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT IdEstado, Nombre FROM Estado";
                        conexion.Open();

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbEstados.DataSource = dt;
                            cmbEstados.DisplayMember = "Nombre";
                            cmbEstados.ValueMember = "IdEstado";
                            cmbEstados.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListarProveedores(DataGridView dgvProveedores)
        {
            try
            {
                conectar = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conectar;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT p.IdProveedor, p.Nombre AS NombreProveedor, c.Categoria, e.Nombre AS EstadoProveedor, p.Direccion, p.Telefono, p.Correo, p.FechaInicio " +
                    "FROM (Proveedor p INNER JOIN Estado e ON p.IdEstado = e.IdEstado) INNER JOIN CategoriasProveedores c ON p.IdCategoria = c.IdCategoria " +
                    "ORDER BY p.IdProveedor";

                DataTable tablaProveedores = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProveedores);

                dgvProveedores.DataSource = tablaProveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListarProveedores(TreeView tvProveedores)
        {
            try
            {
                conectar = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conectar;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT IdProveedor, Nombre FROM Proveedor";
                conectar.Open();

                //Ejecuta la consulta y devuelve el datareader con los resultados
                OleDbDataReader reader = comando.ExecuteReader();
                tvProveedores.Nodes.Clear();
                // Mientras lea cada registro
                while (reader.Read())
                {
                    string proveedor = reader["Nombre"].ToString();
                    int idProveedor = Convert.ToInt32(reader["IdProveedor"]);

                    TreeNode nodoProveedor = new TreeNode(proveedor);
                    nodoProveedor.Tag = idProveedor;  // Es para guardar en la propiedad Tag el id del prvoeedor
                    tvProveedores.Nodes.Add(nodoProveedor);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Agregar(String nombre, Int32 categoria, Int32 estado, String direccion, String telefono, 
            String correo, DateTime fecha)
        {
            try
            {
                conectar = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conectar;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Proveedor (Nombre, IdCategoria, IdEstado, Direccion, Telefono, Correo, FechaInicio) VALUES " +
                    "(?, ?, ?, ?, ?, ?, ?)";

                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@IdCategoria", categoria);
                comando.Parameters.AddWithValue("@IdEstado", estado);
                comando.Parameters.AddWithValue("@Direccion", direccion);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@FechaInicio", fecha);


                conectar.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado el proveedor", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Modificar(DataGridView dgvProveedores, String nombre, Int32 categoria, Int32 estado, String direccion, String telefono,
            String correo, DateTime fecha)
        {
            try
            {
                int codigoProveedor= int.Parse(dgvProveedores.SelectedRows[0].Cells["IdProveedor"].Value.ToString());

                conectar = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conectar;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Proveedor SET Nombre = ?, IdCategoria = ?, IdEstado = ?, Direccion = ?, Telefono = ?, Correo = ?, FechaInicio = ? WHERE IdProveedor = ?";

                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@IdCategoria", categoria);
                comando.Parameters.AddWithValue("@IdEstado", estado);
                comando.Parameters.AddWithValue("@Direccion", direccion);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@FechaInicio", fecha);
                comando.Parameters.AddWithValue("@IdProveedor", codigoProveedor);


                conectar.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se han modificado los datos del proveedor", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarProductosProveedor(DataGridView dgvProductos, Int32 idProveedor)
        {
            try
            {
                conectar = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conectar;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT p.IdProducto, p.Nombre, p.Descripcion, p.Precio, c.Nombre, e.Nombre FROM ((Productos p INNER JOIN [Producto-Proveedor] pp ON p.IdProducto = pp.IdProducto) " +
                    "INNER JOIN Categorias c ON p.Categoria = c.IdCategoria) INNER JOIN Estado e ON p.Estado = e.IdEstado WHERE pp.IdProveedor = @IdProveedor";

                comando.Parameters.AddWithValue("@IdProveedor", idProveedor);
                DataTable tablaProductosProveedor = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductosProveedor);

                dgvProductos.DataSource = tablaProductosProveedor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataRow DatosProveedor(string proveedor)
        {
            DataTable datosProveedor = new DataTable();
            try
            {
                conectar = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conectar;
                comando.CommandType = CommandType.Text;
                comando.CommandText = @"SELECT p.Nombre, c.Categoria AS Categoria, p.IdEstado, p.Direccion, p.Telefono, p.Correo, p.FechaInicio " +
                    "FROM (Proveedor p INNER JOIN CategoriasProveedores c ON p.IdCategoria = c.IdCategoria) WHERE p.Nombre = ?";

                comando.Parameters.AddWithValue("?", proveedor);
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(datosProveedor);
                if (datosProveedor.Rows.Count > 0)
                {
                    return datosProveedor.Rows[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos del proveedor: " + ex.Message);
                return null;
            }
            
        } 
    }
}
