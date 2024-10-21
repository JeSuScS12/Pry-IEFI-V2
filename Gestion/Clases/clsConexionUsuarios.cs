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
    internal class clsConexionUsuarios
    {
        OleDbCommand comando;
        OleDbConnection conectar;
        OleDbDataAdapter adaptador;

        string cadena;

        public clsConexionUsuarios()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BD/DB.accdb";
        }

        //Metodo de Cargar CMB
        //Cargar Provincias
        public void CargarProvincias(ComboBox cmbProvincias)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT idProvincia, Provincia FROM Provincias";
                        conexion.Open();

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbProvincias.DataSource = dt;
                            cmbProvincias.DisplayMember = "Provincia";
                            cmbProvincias.ValueMember = "idProvincia";
                            cmbProvincias.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Cargar Localidades
        public void CargarLocalidades(ComboBox cmbLocalidades, int provincia)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT idLocalidad, Localidad FROM Localidades WHERE idProvincia = ?";
                        comando.Parameters.AddWithValue("@idProvincia", provincia);
                        conexion.Open();

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbLocalidades.DataSource = dt;
                            cmbLocalidades.DisplayMember = "Localidad";
                            cmbLocalidades.ValueMember = "idLocalidad";
                            cmbLocalidades.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Validar Usuarios
        public bool ValidarUsuario(string user, string pass)
        {
            string consulta = $"select count(*) from Usuarios where Usuario = '{user}' and Contraseña = '{pass}'";  //Query de Validacion (Mejorar metodo) 
            conectar = new OleDbConnection(cadena);
            comando = new OleDbCommand(consulta, conectar);
            try
            {
                conectar.Open();
                int count = (int)comando.ExecuteScalar();
                if (count > 0)
                {
                    SesionActual.Usuario = user;
                    clsUserGlobal.user = user;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }

        public void UserGlobal(string user, string password)
        {

            string consulta = $"SELECT u.IdUsuario, u.[Usuario], u.[Contraseña], u.Nombre, u.DNI, u.Correo, e.Nombre AS Estado, c.Nombre AS Cargo\r\nFROM (Usuarios AS u\r\nINNER JOIN Cargos AS c ON c.IdCargo = u.IdCargo)\r\nINNER JOIN Estado AS e ON e.IdEstado = u.IdEstado\r\nWHERE u.[Usuario] = '{user}' AND u.[Contraseña] = '{password}';";
            conectar = new OleDbConnection(cadena);
            comando = new OleDbCommand(consulta, conectar);

            try
            {
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    clsUserGlobal.id = lector.GetInt32(0);
                    clsUserGlobal.user = lector.GetString(1);
                    clsUserGlobal.contraseña = lector.GetString(2);
                    clsUserGlobal.nombre = lector.GetString(3);
                    clsUserGlobal.estado = lector.GetString(4);
                    clsUserGlobal.cargo = lector.GetString(5);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error" + error);
            }

        }


        //Guarda el usuario
        public static class SesionActual
        {
            public static string Usuario { get; set; }  // para guardar el usuario
        }
    }
}
