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
    internal class clsCategoriasInv
    {
        OleDbConnection conexionBD = new OleDbConnection();
        OleDbCommand comandoBD = new OleDbCommand();
        //OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD = new OleDbDataAdapter();
        //DataSet objDS;

        string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\BD\\BDInventario.accdb";

        public string EstadoDeConexion = "";
        private string Tabla = "Categorias";
        Int32 id_c;
        string cate;
        string descrip;
        public Int32 idCategoria
        {
            get { return id_c; }
            set { id_c = value; }
        }
        public string Categoria
        {
            get { return cate; }
            set { cate = value; }
        }
        public string Descripcion
        {
            get { return descrip; }
            set { descrip = value; }
        }
        public string BuscarParaGrillaa(Int32 Id) //busca cuando necesitamos listar todos los productos y pone la categoria en vez de los idCategoria
        {
            try
            {
                //Conecto con la base de datos
                conexionBD.ConnectionString = cadenaDeConexion;
                //Abro Conexion
                conexionBD.Open();
                //Indico cual es la conexion que voy a utilizar
                comandoBD.Connection = conexionBD;
                //Indico que voy a trabajar directamente con table
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla;

                OleDbDataReader Lector = comandoBD.ExecuteReader();
                string varCategoria = "";
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == Id)
                        {
                            varCategoria = Lector.GetString(1);
                        }
                    }
                }
                conexionBD.Close();
                return varCategoria;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ListarProductosxCat(DataGridView GrillaPxCat, Int32 idcategoria) //busqueda por categoria
        {
            try
            {
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla;

                OleDbDataReader DR = comandoBD.ExecuteReader();
                GrillaPxCat.Rows.Clear();
                //si hay filas
                if (DR.HasRows)
                {
                    //Recorro la tabla 
                    while (DR.Read())
                    {
                        //Comparo el categoria que seria el campo numero 5 con el detalle que nos enviaron desde la interfaz grafica
                        if (DR.GetInt32(5) == idcategoria)
                        {
                            GrillaPxCat.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetString(2), DR.GetString(3), DR.GetString(4), DR.GetDateTime(6), DR.GetDateTime(7));
                        }
                    }
                }
                conexionBD.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }

        }
        public void ListarTablaCategorias(DataGridView dgv) //lista la tabla categorias con sus respectivos datos 
        {
            try
            {
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla;
                OleDbDataReader dr = comandoBD.ExecuteReader();
                dgv.Rows.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read()) 
                    {
                        dgv.Rows.Add(dr.GetInt32(0), dr.GetString(1),dr.GetString(2)) ;
                    }
                }
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
                //throw;
            }
        }
        public void AgregarCat(string nombreCategoria, string descripcion, DataGridView grilla) //agrega categoria con descripción
        {
            try
            {
                // Verificar si la categoría ya existe
                if (ExisteCategoria(nombreCategoria))
                {
                    MessageBox.Show("La categoría ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Proceder a agregar la categoría si no existe
                using (OleDbConnection conexionBD = new OleDbConnection(cadenaDeConexion))
                {
                    conexionBD.Open();
                    using (OleDbCommand comandoBD = new OleDbCommand())
                    {
                        comandoBD.Connection = conexionBD;
                        comandoBD.CommandType = CommandType.Text;
                        comandoBD.CommandText = "INSERT INTO Categorias (Categoria, Descripcion) VALUES (@Categoria, @Descripcion)";
                        comandoBD.Parameters.AddWithValue("@Categoria", nombreCategoria);
                        comandoBD.Parameters.AddWithValue("@Descripcion", descripcion); // Agregar la descripción

                        int filasAfectadas = comandoBD.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Categoría agregada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clsCategoriasInv clsCategoriasInv = new clsCategoriasInv();
                            clsCategoriasInv.ListarTablaCategorias(grilla);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    conexionBD.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la categoría: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ModificarCategoria(int idCategoria, string nuevoNombreCategoria, string nuevaDescripcion, DataGridView grilla)
        {
            try
            {
                using (OleDbConnection conexionBD = new OleDbConnection(cadenaDeConexion))
                {
                    conexionBD.Open();

                    // Verificar si la categoría a actualizar existe en la base de datos
                    if (!ExisteCategoriaPorId(idCategoria))
                    {
                        MessageBox.Show("La categoría no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Crear el comando para actualizar la categoría
                    using (OleDbCommand comandoBD = new OleDbCommand())
                    {
                        comandoBD.Connection = conexionBD;
                        comandoBD.CommandType = CommandType.Text;
                        comandoBD.CommandText = "UPDATE Categorias SET Categoria = @NuevoNombre, Descripcion = @NuevaDescripcion WHERE idCategoria = @idCategoria";

                        // Asignar parámetros de la consulta
                        comandoBD.Parameters.AddWithValue("@NuevoNombre", nuevoNombreCategoria);
                        comandoBD.Parameters.AddWithValue("@NuevaDescripcion", nuevaDescripcion);
                        comandoBD.Parameters.AddWithValue("@idCategoria", idCategoria);

                        int filasAfectadas = comandoBD.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Categoría modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Actualizar la grilla después de la modificación
                            clsCategoriasInv clsCategoriasInv = new clsCategoriasInv();
                            clsCategoriasInv.ListarTablaCategorias(grilla);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    conexionBD.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la categoría: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool ExisteCategoriaPorId(int idCategoria)
        {
            bool existe = false;

            using (OleDbConnection conexionBD = new OleDbConnection(cadenaDeConexion))
            {
                string query = "SELECT COUNT(*) FROM Categorias WHERE idCategoria = @idCategoria";
                OleDbCommand comandoBD = new OleDbCommand(query, conexionBD);
                comandoBD.Parameters.AddWithValue("@idCategoria", idCategoria);

                conexionBD.Open();
                int count = (int)comandoBD.ExecuteScalar();
                existe = count > 0;
            }

            return existe;
        }

        public void CargaCMB(ComboBox combo) //carga los datos en el combobox categoria con las categorias correspondientes de la base de datos
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
                combo.DisplayMember = "Categoria";
                combo.ValueMember = "idCategoria";
                conexionBD.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
            }
        }
        public void CargaCMBID(ComboBox combo) //carga los datos en el combobox categoria con las categorias correspondientes de la base de datos
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
                combo.DisplayMember = "idCategoria";
                combo.ValueMember = "idCategoria";
                conexionBD.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
            }
        }
        public bool ExisteCategoria(string nombreCategoria) //verifica si existe la categoria, si existe hay aviso, si no? procede
        {
            bool existe = false;
            try
            {
                using (OleDbConnection conexionBD = new OleDbConnection(cadenaDeConexion))
                {
                    conexionBD.Open();
                    string query = "SELECT COUNT(*) FROM Categorias WHERE Categoria = @Categoria";
                    using (OleDbCommand comandoBD = new OleDbCommand(query, conexionBD))
                    {
                        comandoBD.Parameters.AddWithValue("@Categoria", nombreCategoria);

                        int count = Convert.ToInt32(comandoBD.ExecuteScalar());
                        existe = (count > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return existe;
        }
        public void EliminarCategoria(int idCategoria, DataGridView grilla)
        {
            try
            {
                using (OleDbConnection conexionBD = new OleDbConnection(cadenaDeConexion))
                {
                    conexionBD.Open();
                    using (OleDbCommand comandoBD = new OleDbCommand())
                    {
                        comandoBD.Connection = conexionBD;
                        comandoBD.CommandType = CommandType.Text;
                        comandoBD.CommandText = "DELETE FROM Categorias WHERE idCategoria = @idCategoria";
                        comandoBD.Parameters.AddWithValue("@idCategoria", idCategoria);

                        int filasAfectadas = comandoBD.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Categoría eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Actualizar la grilla después de eliminar la categoría
                            ListarTablaCategorias(grilla);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    conexionBD.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
