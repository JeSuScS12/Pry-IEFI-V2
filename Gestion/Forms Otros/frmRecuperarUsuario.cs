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

namespace Gestion.Forms_Otros
{
    public partial class frmRecuperarUsuario : Form
    {
        public frmRecuperarUsuario()
        {
            InitializeComponent();
        }

        //Instanciar Conexion
        clsConexionUsuarios nuevo = new clsConexionUsuarios();

        private void frmRecuperarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea enviar a este Correo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Enviado", "Notificacion");
            }
        }
    }
}
