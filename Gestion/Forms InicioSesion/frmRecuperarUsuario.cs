using Gestion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Librerias 
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Gestion.Forms_Otros
{
    public partial class frmRecuperarUsuario : Form
    {
        
        public frmRecuperarUsuario()
        {
            InitializeComponent();
        }

        private void frmRecuperarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        clsRecuperarUser recuperar = new clsRecuperarUser();

        //Boton de enviar
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(correo, emailPattern))
            {
                DialogResult resultado = MessageBox.Show("¿Desea enviar a este Correo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    recuperar.CambiarBody(correo);
                    recuperar.CrearCuerpoCorreo(correo);
                    recuperar.Enviar(correo);
                    MessageBox.Show("Enviado", "Notificacion");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("El correo ingresado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
