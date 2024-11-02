using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
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
        private string Tabla2 = "Productos2";
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

        public void ConectarBD() //esto es para verificar que la base este conectada, no se ve en ningun form, prodriamos sacarlo si se quisiese
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
                comandoBD.CommandText = Tabla2;

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                DataSet DS = new DataSet();
                //LLENA EL DATA SET CON LOS DATOS DE LA TABLA
                adaptadorBD.Fill(DS, Tabla2);
                //RECIBE LOS DATOS
                DataTable tabla = DS.Tables[Tabla2];
                DataRow Fila = tabla.NewRow();

                
                Fila["Nombre"] = Nombre;
                Fila["Descripcion"] = Descripcion;
                Fila["Precio"] = Precio;
                Fila["Stock"] = Stock;  
                Fila["idCategoria"] = idCategoria;
                Fila["idProveedor"] = idProveedor;
                Fila["FechaIngreso"] = FechaIngreso;

                tabla.Rows.Add(Fila);

                OleDbCommandBuilder HacerCompatiblesLosCambios = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(DS, Tabla2);
                conexionBD.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo registrar el producto", "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Buscar(Int32 i) //Busca por codigo de producto y dice si esta registrado el id, sirve para el agregar por ej para saber si ya esta registrado
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
        public void Buscar(int idProducto, DataGridView grilla)
        {
            using (OleDbConnection conexionBD = new OleDbConnection(cadenaDeConexion))
            {
                using (OleDbCommand comandoBD = new OleDbCommand())
                {
                    try
                    {
                        // Configuración de la conexión y del comando
                        conexionBD.ConnectionString = cadenaDeConexion;
                        conexionBD.Open();

                        comandoBD.Connection = conexionBD;
                        comandoBD.CommandType = CommandType.TableDirect;
                        comandoBD.CommandText = Tabla;

                        // Limpiar la grilla antes de agregar nuevas filas
                        grilla.Rows.Clear();
                        bool encontrado = false; // Variable para marcar si se encuentra el producto

                        using (OleDbDataReader lector = comandoBD.ExecuteReader())
                        {
                            if (lector.HasRows)
                            {
                                // Clases para obtener detalles de Categorías y Proveedores
                                clsCategoriasInv clsCategoriasInv = new clsCategoriasInv();
                                clsProveedoresInv clsProveedoresInv = new clsProveedoresInv();

                                while (lector.Read())
                                {
                                    // Verifica si el ID del producto coincide con el ID buscado
                                    if (lector.GetInt32(0) == idProducto)
                                    {
                                        encontrado = true; // Marca que se encontró el producto

                                        // Usar métodos de conversión seguros y verificar los tipos de datos
                                        int id = lector.GetInt32(0);
                                        string nombre = lector.IsDBNull(1) ? "" : lector.GetString(1);
                                        string descripcion = lector.IsDBNull(2) ? "" : lector.GetString(2);
                                        decimal precio = lector.IsDBNull(3) ? 0 : Convert.ToDecimal(lector.GetValue(3));
                                        int stock = lector.IsDBNull(4) ? 0 : lector.GetInt32(4);
                                        int idCategoria = lector.GetInt32(5);
                                        int idProveedor = lector.GetInt32(6);
                                        DateTime fechaIngreso = lector.IsDBNull(7) ? DateTime.MinValue : lector.GetDateTime(7);

                                        // Obtener detalles de categoría y proveedor
                                        string detalleCategoria = clsCategoriasInv.BuscarParaGrillaa(idCategoria);
                                        string detalleProveedor = clsProveedoresInv.BuscarParaGrillaa(idProveedor);

                                        // Agregar fila a la grilla con los datos
                                        grilla.Rows.Add(id, nombre, descripcion, precio, stock, detalleCategoria, detalleProveedor, fechaIngreso);

                                        // Sale del bucle una vez encontrado el producto
                                        break;
                                    }
                                }

                                // Mostrar mensaje si no se encontró el producto
                                if (!encontrado)
                                {
                                    MessageBox.Show("No se encontró ningún producto con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No hay productos en la tabla.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Asegura el cierre de la conexión
                        if (conexionBD.State == ConnectionState.Open)
                        {
                            conexionBD.Close();
                        }
                    }
                }
            }
        }



        public void BuscarCateg(DataGridView dgvBuscar, Int32 cate)
        {
            try
            {
                conexionBD = new OleDbConnection(cadenaDeConexion);
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.Text;

                // Modificación de la consulta para obtener los nombres de la categoría y del proveedor
                comandoBD.CommandText = @"
            SELECT p.idProducto, p.Nombre, p.Descripcion, p.Precio, p.Stock, 
                   c.Categoria AS Categoria, pr.Proveedor AS Proveedor, p.FechaIngreso
            FROM (Productos p
            INNER JOIN Categorias c ON p.idCategoria = c.idCategoria)
            INNER JOIN Proveedores pr ON p.idProveedor = pr.idProveedor
            WHERE p.idCategoria = @idCategoria
            ORDER BY p.idProducto";

                comandoBD.Parameters.AddWithValue("@idCategoria", cate);

                DataTable tablaProductos = new DataTable();
                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(tablaProductos);

                // Limpia la grilla antes de asignar la nueva fuente de datos
                dgvBuscar.DataSource = null;
                dgvBuscar.Rows.Clear(); // Limpia filas residuales

                // Asigna la nueva fuente de datos a la grilla
                dgvBuscar.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public void EliminarProducto(Int32 idproducto) //elimina el producto comparado con el identificador (id)
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

                    
                    string MProducto = "UPDATE Productos SET " +
                                       "Nombre = @Nombre, " +
                                       "Descripcion = @Descripcion, " +
                                       "Precio = @Precio, " +
                                       "Stock = @Stock, " +
                                       "idCategoria = @idCategoria, " +
                                       "idProveedor = @idProveedor, " +
                                       "FechaIngreso = @FechaIngreso " + 
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

                        // Verifica si se actualizo alguna fila
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
        public void ListarProductos(DataGridView grilla) //lista los productos
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
                    DetalleCategoria = clsCategoriasInv.BuscarParaGrillaa(dr.GetInt32(5)); //se usa asi ya que el procedimiento buscarparagrillaa hace que aparezcan los datos en vez de los id
                    DetalleProveedor = clsProveedoresInv.BuscarParaGrillaa(dr.GetInt32(6));
                    grilla.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], DetalleCategoria, DetalleProveedor,  dr[7]);
                }
            }
            conexionBD.Close();
        }

        public List<clsInventario> BuscarProductosPorNombre(string nombre)
        {
            List<clsInventario> inventario = new List<clsInventario>();

            string query = "SELECT idProducto, Nombre, Descripcion, Precio, Stock, idCategoria, idProveedor, FechaIngreso FROM Productos WHERE Nombre LIKE @Nombre";

            using (OleDbConnection connection = new OleDbConnection(cadenaDeConexion))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", "%" + nombre + "%"); // Búsqueda parcial por nombre

                try
                {
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clsInventario producto = new clsInventario
                            {
                                idProducto = reader.IsDBNull(reader.GetOrdinal("idProducto")) ? 0 : reader.GetInt32(reader.GetOrdinal("idProducto")),
                                Nombre = reader.IsDBNull(reader.GetOrdinal("Nombre")) ? "" : reader.GetString(reader.GetOrdinal("Nombre")),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "" : reader.GetString(reader.GetOrdinal("Descripcion")),
                                Precio = reader.IsDBNull(reader.GetOrdinal("Precio")) ? 0 : Convert.ToDecimal(reader["Precio"]),
                                Stock = reader.IsDBNull(reader.GetOrdinal("Stock")) ? 0 : reader.GetInt32(reader.GetOrdinal("Stock")),
                                idCategoria = reader.IsDBNull(reader.GetOrdinal("idCategoria")) ? 0 : reader.GetInt32(reader.GetOrdinal("idCategoria")),
                                idProveedor = reader.IsDBNull(reader.GetOrdinal("idProveedor")) ? 0 : reader.GetInt32(reader.GetOrdinal("idProveedor")),
                                FechaIngreso = reader.IsDBNull(reader.GetOrdinal("FechaIngreso")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("FechaIngreso")),
                            };
                            inventario.Add(producto);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar el producto: " + ex.Message);
                }
            }

            return inventario;
        }


        public Dictionary<string, int> ObtenerNivelesDeStock() //obtiene los nivles de stock
        {
            Dictionary<string, int> nivelesDeStock = new Dictionary<string, int>(); //los guarda en un diccionario 'x' seria el string e 'y' el int en este caso nombre y sotck del producto
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
        public void CargaCMBStock(ComboBox combo) //carga los datos en el combobox stock de la busqueda con los datos correspondientes de la base de datos
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
                adaptadorBD.Fill(DS, Tabla);
                combo.DataSource = DS.Tables[Tabla];
                combo.DisplayMember = "Stock";
                //combo.ValueMember = "idCategoria";
                conexionBD.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
            }
        }

        public DataTable GenerarReporteStock()
        {
            DataTable reporteStock = new DataTable();

            string query = @"
        SELECT p.idProducto, p.Nombre, p.Descripcion, p.Precio, p.Stock, 
               c.Categoria AS Categoria, pr.Proveedor AS Proveedor, p.FechaIngreso
        FROM (Productos p
        INNER JOIN Categorias c ON p.idCategoria = c.idCategoria)
        INNER JOIN Proveedores pr ON p.idProveedor = pr.idProveedor
        ORDER BY p.Nombre";

            try
            {
                using (OleDbConnection conexionBD = new OleDbConnection(cadenaDeConexion))
                {
                    conexionBD.Open();
                    using (OleDbCommand comandoBD = new OleDbCommand(query, conexionBD))
                    {
                        OleDbDataAdapter adaptador = new OleDbDataAdapter(comandoBD);
                        adaptador.Fill(reporteStock);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte de stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return reporteStock;
        }
        public void BuscarPorStock(DataGridView dgvProductos, int cantidadStock)
        {
            try
            {
                using (OleDbConnection conexionBD = new OleDbConnection(cadenaDeConexion))
                {
                    conexionBD.Open();
                    string query = @"
                SELECT p.idProducto, p.Nombre, p.Descripcion, p.Precio, p.Stock,
                       c.Categoria, pr.Proveedor, p.FechaIngreso
                FROM (Productos p
                INNER JOIN Categorias c ON p.idCategoria = c.Categoria)
                INNER JOIN Proveedores pr ON p.idProveedor = pr.Proveedor
                WHERE p.Stock = @Stock";

                    using (OleDbCommand comandoBD = new OleDbCommand(query, conexionBD))
                    {
                        comandoBD.Parameters.AddWithValue("@Stock", cantidadStock);

                        using (OleDbDataReader dr = comandoBD.ExecuteReader())
                        {
                            dgvProductos.Rows.Clear(); // Limpia la grilla antes de cargar nuevos datos
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    dgvProductos.Rows.Add(
                                        dr["idProducto"],
                                        dr["Nombre"],
                                        dr["Descripcion"],
                                        dr["Precio"],
                                        dr["Stock"],
                                        dr["Categoria"],
                                        dr["Proveedor"],
                                        dr["FechaIngreso"]
                                    );
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron productos con la cantidad de stock especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos por stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExportarCSV(string rutaArchivo)
        {
            try
            {
                List<clsInventario> inventario = ObtenerInventarioCompleto(); // Método que obtiene todos los productos en inventario

                using (StreamWriter sw = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                {
                    // Escribir encabezados
                    sw.WriteLine("idProducto,Nombre,Descripcion,Precio,Stock,Categoria,Proveedor,FechaIngreso");

                    // Escribir cada registro del inventario en el archivo CSV
                    foreach (var item in inventario)
                    {
                        clsCategoriasInv clsCategoriasInv = new clsCategoriasInv();
                        clsProveedoresInv clsProveedoresInv = new clsProveedoresInv();
                        string categoria = clsCategoriasInv.BuscarParaGrillaa(item.idCategoria); // Obtiene nombre de la categoría
                        string proveedor = clsProveedoresInv.BuscarParaGrillaa(item.idProveedor); // Obtiene nombre del proveedor

                        string linea = $"{item.idProducto},{item.Nombre},{item.Descripcion},{item.Precio},{item.Stock},{categoria},{proveedor},{item.FechaIngreso.ToString("yyyy-MM-dd")}";
                        sw.WriteLine(linea);
                    }
                }

                MessageBox.Show("Exportación a CSV completada exitosamente.", "Exportar CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<clsInventario> ObtenerInventarioCompleto()
        {
            List<clsInventario> inventario = new List<clsInventario>();

            string query = @"SELECT idProducto, Nombre, Descripcion, Precio, Stock, idCategoria, idProveedor, FechaIngreso FROM Productos";

            using (OleDbConnection connection = new OleDbConnection(cadenaDeConexion))
            {
                OleDbCommand command = new OleDbCommand(query, connection);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        clsInventario item = new clsInventario
                        {
                            idProducto = Convert.ToInt32(reader["idProducto"]),
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Precio = Convert.ToDecimal(reader["Precio"]),
                            Stock = Convert.ToInt32(reader["Stock"]),
                            idCategoria = Convert.ToInt32(reader["idCategoria"]),
                            idProveedor = Convert.ToInt32(reader["idProveedor"]),
                            FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"])
                        };

                        inventario.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return inventario;
        }

    }

}
