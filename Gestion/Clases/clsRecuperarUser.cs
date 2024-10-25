using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Librerias 
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion.Clases
{
    internal  class clsRecuperarUser
    {
        //Correo Emisor  
        private string myEmail = "enviarcorreoprueba66@gmail.com";
        private string MyPassword = "agnh qfmr jxyp okij";
        private string MyAlias = "BandejaTEC";
        private MailMessage mCorreo;


        OleDbCommand comando;
        OleDbConnection conectar;
        OleDbDataAdapter adaptador;

        string cadena;

        public clsRecuperarUser()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BD/DB.accdb";
        }

        string body = "<!DOCTYPE html>\r\n<html lang=\"es\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Recuperación de Usuario</title>\r\n    <style>\r\n        /* Estilos básicos para el correo */\r\n        body {\r\n            font-family: Arial, sans-serif;\r\n            margin: 0;\r\n            padding: 0;\r\n            background-color: #f4f4f4;\r\n        }\r\n        .container {\r\n            width: 100%;\r\n            max-width: 600px;\r\n            margin: 0 auto;\r\n            background-color: #ffffff;\r\n            padding: 20px;\r\n            border-radius: 8px;\r\n            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);\r\n        }\r\n        h2 {\r\n            color: #333333;\r\n        }\r\n        p {\r\n            color: #555555;\r\n            font-size: 16px;\r\n            line-height: 1.5;\r\n        }\r\n        .user-data {\r\n            background-color: #f8f8f8;\r\n            padding: 15px;\r\n            margin-top: 20px;\r\n            border: 1px solid #dddddd;\r\n            border-radius: 5px;\r\n        }\r\n        .footer {\r\n            margin-top: 30px;\r\n            text-align: center;\r\n            color: #aaaaaa;\r\n            font-size: 12px;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n    <div class=\"container\">\r\n        <h2>Recuperación de Datos de Usuario</h2>\r\n        <p>Hola,</p>\r\n        <p>Has solicitado recuperar tus datos de usuario, te enviamos la información asociada a tu cuenta:</p>\r\n\r\n        <!-- Sección donde se muestran los datos del usuario -->\r\n        <div class=\"user-data\">\r\n            <p><strong>Nombre:</strong> @NOMBRE</p>\r\n            <p><strong>DNI:</strong> @DNI</p>\r\n            <p><strong>Usuario:</strong> @USUARIO</p>\r\n            <p><strong>Contraseña:</strong> @CONTRASEÑA</p>\r\n            <!-- Si por alguna razón incluyes la contraseña -->\r\n            \r\n        </div>\r\n        <div class=\"footer\">\r\n            <p>&copy; 2024 BandejaTEC.</p>\r\n        </div>\r\n    </div>\r\n</body>\r\n</html>";


        //Metodo para remplazar los datos del usuario
        public void CambiarBody(string correo)
        {
            conectar = new OleDbConnection(cadena);
            try
            {
                conectar.Open();
                string consulta = $"SELECT Usuario, Contraseña, Nombre, DNI FROM Usuarios WHERE Correo = '{correo}'";
                comando = new OleDbCommand(consulta, conectar);
                OleDbDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    body = body.Replace("@USUARIO", reader["Usuario"].ToString());
                    body = body.Replace("@CONTRASEÑA", reader["Contraseña"].ToString());
                    body = body.Replace("@NOMBRE", reader["Nombre"].ToString());
                    body = body.Replace("@DNI", reader["DNI"].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        //CUERPO DEL CORREO
        public void CrearCuerpoCorreo(string correo)
        {
            mCorreo = new MailMessage();
            mCorreo.From = new MailAddress(myEmail, MyAlias, System.Text.Encoding.UTF8);
            mCorreo.To.Add(correo);
            mCorreo.Subject = "RECUPERACION DE USUARIO";
            mCorreo.Body = body;
            mCorreo.IsBodyHtml = true;
            mCorreo.Priority = MailPriority.High;

        }

        //ENVIO DE CORREO
        public void Enviar(string correo)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Port = 25;
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential(myEmail, MyPassword);
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; };
                smtp.EnableSsl = true;
                smtp.Send(mCorreo);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
