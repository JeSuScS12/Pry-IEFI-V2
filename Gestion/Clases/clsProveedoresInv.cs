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

        string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\BD\\BDInventario.accdb";

        public string EstadoDeConexion = "";
        private string Tabla = "Proveedores";
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
                            varProveedor = Lector.GetString(1);
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
                combo.DisplayMember = "Proveedor";
                combo.ValueMember = "idProveedor";
                conexionBD.Close();
            }
            catch (Exception Mensaje)
            {
                MessageBox.Show(Mensaje.Message);
            }
        }
    }
}
