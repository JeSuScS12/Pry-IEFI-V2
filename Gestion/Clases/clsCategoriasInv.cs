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

        string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Gestion\\BD\\BDInventario.accdb";

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
        public void AgregarCat() 
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

               
                Fila["Categoria"] = Categoria;
                Fila["Descripcion"] = Descripcion;
               

                tabla.Rows.Add(Fila);

                OleDbCommandBuilder HacerCompatiblesLosCambios = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(DS, Tabla);
                conexionBD.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo registrar cliente", "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
