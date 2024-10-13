using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using Gestion.Clases;
using Gestion.Forms_Otros;
using System.Data.SqlClient;

namespace Gestion
{
    public partial class frmInicioSesion : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public frmInicioSesion()
        {
            InitializeComponent();
            //Funcion para bordes redondos
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));   // <--- border radius 25
        }

        clsConexionUsuarios nuevo = new clsConexionUsuarios();

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRecuperar_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
            frmRecuperarUsuario frm = new frmRecuperarUsuario();
            frm.FormClosed += Form2_FormClosed;
            frm.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1.0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string pass = txtContraseña.Text.Trim();

            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    lblError.Text = "";
                    lblError.Visible = false;

                    if (nuevo.ValidarUsuario(user, pass))
                    {
                        frmPrincipal frm = new frmPrincipal();

                        frm.Show();
                        this.Hide();
                        frm.FormClosing += frm_close;
                    }
                    else lblError.Text = "El usuario no existe";
                }
                else lblError.Text = "Ingrese Contraseña";
                lblError.Visible = true;
            }
            else lblError.Text = "Ingrese Usuario";
            lblError.Visible = true;
        }

        private void frm_close(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            this.Show();
            txtUsuario.Focus();
        }
    }
}
