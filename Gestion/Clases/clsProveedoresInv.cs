using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace Gestion.Clases
{
    internal class clsProveedoresInv
    {
        OleDbConnection conexionBD = new OleDbConnection();
        OleDbCommand comandoBD = new OleDbCommand();
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD = new OleDbDataAdapter();

        string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BDInventario.accdb";

        public string EstadoDeConexion = "";
        private string Tabla = "Productos";
        Int32 id_p;
        string prove;
        string tel;
        string direc;
        string corr;
        public Int32 idProveedor
        {
            get { return id_p; }
            set { id_p = value; }
        }
        public string Proveedor
        {
            get { return prove; }
            set { prove = value; }
        }
        public string Telefono
        {
            get { return tel; }
            set { tel = value; }
        }
        public string Direccion
        {
            get { return direc; }
            set { direc = value; }
        }
        public string Correo
        {
            get { return corr; }
            set { corr = value; }
        }
        public string BuscarParaGrillaa(Int32 Id)
        {
            try
            {
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = Tabla;
                OleDbDataReader Lector = comandoBD.ExecuteReader();
                string varProveedor = "";
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == Id)
                        {
                            varProveedor = Lector.GetString(6);
                        }
                    }
                }
                conexionBD.Close();
                return varProveedor;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
