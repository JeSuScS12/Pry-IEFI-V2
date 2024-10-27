using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Clases
{
    internal class clsInventario
    {
        OleDbConnection conexionBD = new OleDbConnection();
        OleDbCommand comandoBD = new OleDbCommand();
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD = new OleDbDataAdapter();
        //DataSet objDS;

        string cadenaDeConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BD/BDInventario.accdb";
        public string EstadoDeConexion = "";
        private string Tabla = "Productos";
        Int32 id;
        string nom;
        Decimal pre;
        Int32 sto;
        Int32 cate;
        string des;
        DateTime fec;
        Int32 idP;
        public Int32 idProducto
        {
            get { return id; }
            set { id = value; }
        }
        public Int32 Stock
        {
            get { return sto; }
            set { sto = value; }
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public Int32 idCategoria
        {
            get { return cate; }
            set { cate = value; }
        }
        public Decimal Precio
        {
            get { return pre; }
            set { pre = value; }
        }
        public string Descripcion
        {
            get { return des; }
            set { des = value; }
        }
        public DateTime FechaIngreso
        {
            get { return fec; }
            set { fec = value; }
        }
        public Int32 idProveedor
        {
            get { return idP; }
            set { idP = value; }
        }

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                EstadoDeConexion = "Conectado";
            }
            catch (Exception ex)
            {
                EstadoDeConexion = "Error" + ex.Message;
            }

        }
        public void AgregarProducto()
        {

            try
            {
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla;

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                DataSet DS = new DataSet();
                //LLENA EL DATA SET CON LOS DATOS DE LA TABLA
                adaptadorBD.Fill(DS, Tabla);
                //RECIBE LOS DATOS
                DataTable tabla = DS.Tables[Tabla];
                DataRow Fila = tabla.NewRow();

                Fila["idProducto"] = idProducto;
                Fila["Nombre"] = Nombre;
                Fila["Descripcion"] = Descripcion;
                Fila["Precio"] = Precio;
                Fila["Stock"] = Stock;  
                Fila["idCategoria"] = idCategoria;
                Fila["idProveedor"] = idProveedor;
                Fila["FechaIngreso"] = FechaIngreso;

                tabla.Rows.Add(Fila);

                OleDbCommandBuilder HacerCompatiblesLosCambios = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(DS, Tabla);
                conexionBD.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo registrar el producto", "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Buscar(Int32 i)
        {
            OleDbConnection conexionBD = new OleDbConnection();
            OleDbCommand comandoBD = new OleDbCommand();

            try
            {
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla;

                OleDbDataReader Lector = comandoBD.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == i)
                        {
                            idProducto = Lector.GetInt32(0);
                            Nombre = Lector.GetString(1);
                            Descripcion = Lector.GetString(2);
                            Precio = Lector.GetDecimal(3);
                            Stock = Lector.GetInt32(4);
                            idCategoria = Lector.GetInt32(5);
                            Descripcion = Lector.GetString(6);
                            FechaIngreso = Lector.GetDateTime(7);
                        }
                    }
                }

                conexionBD.Close();
            }
            catch (Exception MensajeAviso)
            {
                MessageBox.Show(MensajeAviso.Message);
            }
        }
        public void EliminarProducto(Int32 idproducto)
        {
            try
            {
                string EProducto = " DELETE FROM Productos " + "WHERE(" + idproducto + "=[idProducto])";
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.Text;
                comandoBD.CommandText = EProducto;
                comandoBD.ExecuteNonQuery();
                conexionBD.Close();
                MessageBox.Show("Producto Eliminado con éxito");
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show("El cliente no se pudo eliminar " + Mensaje.Message);
                //throw;
            }
        }
        public void ModificarProducto(Int32 idproducto)
        {
            try
            {
                using (OleDbConnection conexionBD = new OleDbConnection(cadenaDeConexion))
                {
                    conexionBD.Open();

                    // Corrección de la consulta de actualización
                    string MProducto = "UPDATE Productos SET " +
                                       "Nombre = @Nombre, " +
                                       "Descripcion = @Descripcion, " +
                                       "Precio = @Precio, " +
                                       "Stock = @Stock, " +
                                       "idCategoria = @idCategoria, " +
                                       "idProveedor = @idProveedor, " +
                                       "FechaIngreso = @FechaIngreso " + // Eliminada la coma antes del WHERE
                                       "WHERE idProducto = @idProducto";

                    using (OleDbCommand comandoBD = new OleDbCommand(MProducto, conexionBD))
                    {
                        // Asignación de parámetros para evitar inyección de SQL
                        comandoBD.Parameters.AddWithValue("@Nombre", Nombre);
                        comandoBD.Parameters.AddWithValue("@Descripcion", Descripcion);
                        comandoBD.Parameters.AddWithValue("@Precio", Precio);
                        comandoBD.Parameters.AddWithValue("@Stock", Stock);
                        comandoBD.Parameters.AddWithValue("@idCategoria", idCategoria);
                        comandoBD.Parameters.AddWithValue("@idProveedor", idProveedor);
                        comandoBD.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                        comandoBD.Parameters.AddWithValue("@idProducto", idproducto);

                        // Ejecuta la actualización
                        int filasAfectadas = comandoBD.ExecuteNonQuery();

                        // Verifica si se actualizó alguna fila
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto para actualizar.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }
        public void ListarProductos(DataGridView grilla)
        {

            conexionBD.ConnectionString = cadenaDeConexion;
            conexionBD.Open();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = Tabla;
            
            OleDbDataReader dr = comandoBD.ExecuteReader();
            grilla.Rows.Clear();
            
            string DetalleCategoria = "";
            string DetalleProveedor = "";
            clsCategoriasInv clsCategoriasInv = new clsCategoriasInv();
            clsProveedoresInv clsProveedoresInv = new clsProveedoresInv();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DetalleCategoria = clsCategoriasInv.BuscarParaGrillaa(dr.GetInt32(5));
                    DetalleProveedor = clsProveedoresInv.BuscarParaGrillaa(dr.GetInt32(6));
                    grilla.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], DetalleCategoria, DetalleProveedor,  dr[7]);
                }
            }
            conexionBD.Close();
        }
        public List<clsInventario> BuscarProductosPorNombre(string nombre)
        {
            List<clsInventario> contactos = new List<clsInventario>();
            List<clsCategoriasInv> categoria = new List<clsCategoriasInv>();
           
            string query = "SELECT idProducto, Nombre, Descripcion, Precio, Stock, Categoria, Proveedor FROM Productos WHERE Nombre LIKE @Nombre";

            using (OleDbConnection connection = new OleDbConnection(cadenaDeConexion))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", "%" + nombre + "%"); // El uso de % permite buscar coincidencias parciales

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        clsInventario contacto = new clsInventario
                        {
                            idProducto = Convert.ToInt32(reader["idProducto"]),
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descipcion"].ToString(),
                            Precio = Convert.ToDecimal(reader["Precio"]),
                            Stock = Convert.ToInt32(reader["Correo"]),
                            idCategoria = Convert.ToInt32(reader["Categoria"]),
                            idProveedor = Convert.ToInt32(reader["idProveedor"]),
                            FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]),
                        };
                        contactos.Add(contacto);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar el contacto: " + ex.Message);
                }
            }

            return contactos;
        }
        public Dictionary<string, int> ObtenerNivelesDeStock()
        {
            Dictionary<string, int> nivelesDeStock = new Dictionary<string, int>();
            try
            {
                using (OleDbConnection conexionBD = new OleDbConnection(cadenaDeConexion))
                {
                    conexionBD.Open();

                    // Consulta SQL para obtener el nombre y stock de cada producto
                    string query = "SELECT Nombre, Stock FROM Productos";

                    using (OleDbCommand comandoBD = new OleDbCommand(query, conexionBD))
                    {
                        OleDbDataReader lector = comandoBD.ExecuteReader();
                        while (lector.Read())
                        {
                            string nombreProducto = lector.GetString(0);
                            int stockProducto = lector.GetInt32(1);
                            nivelesDeStock[nombreProducto] = stockProducto;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                System.Windows.Forms.MessageBox.Show("Ocurrió un error al obtener los niveles de stock: " + ex.Message);
            }
            return nivelesDeStock;
        }
    }

}
