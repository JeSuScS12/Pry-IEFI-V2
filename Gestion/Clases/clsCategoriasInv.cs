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
        public string BuscarParaGrillaa(Int32 Id)
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
        public void ListarProductosxCat(DataGridView GrillaPxCat, Int32 idcategoria)
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
        public void ListarTablaCategorias(DataGridView dgv) 
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
        public void AgregarCat(string nombreCategoria)
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
                        comandoBD.CommandText = "INSERT INTO Categorias (Categoria) VALUES (@Categoria)";
                        comandoBD.Parameters.AddWithValue("@Categoria", nombreCategoria);

                        int filasAfectadas = comandoBD.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Categoría agregada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar la categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la categoría: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargaCMB(ComboBox combo) 
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
    }
}
