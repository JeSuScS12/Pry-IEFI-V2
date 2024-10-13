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
namespace Gestion.Forms_Otros
{
    public partial class frmPrimerRegistro : Form
    {

        //Da bordes redondos al Form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public frmPrimerRegistro()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));   // <--- border radius 25
        }

        clsConexionUsuarios nuevo = new clsConexionUsuarios();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrimerRegistro_Load(object sender, EventArgs e)
        {
            nuevo.CargarProvincias(cmbProvincia);
            optSi.CheckedChanged += new EventHandler(optSeleccionado);
            optNo.CheckedChanged += new EventHandler(optSeleccionado);

            grbIva.Enabled = false;

            //Negocio
            PlaceHolder(txtNegocio, "Nombre Negocio[*]");
            PlaceHolder(txtRubro, "Rubro[*]");
            PlaceHolder(txtDireccion, "Direccion[*]");

            PlaceHolder(cmbProvincia, "Provincia[*]");
            PlaceHolder(cmbLocalidad, "Localidad[*]");


            //Administrador
            PlaceHolder(txtNombres, "Nombres[*]");
            PlaceHolder(txtApellidos, "Apellidos[*]");
            PlaceHolder(txtCorreo, "Correo[*]");
            PlaceHolder(txtTelefono, "Telefono");
            PlaceHolder(txtUsuario, "Usuario[*]");
            PlaceHolder(txtContraseña, "Contraseña[*]");
            PlaceHolder(txtContraseñaR, "Repita su Contraseña[*]");
        }


        // Función que configura el placeholder para cualquier TextBox
        private void PlaceHolder(TextBox txtBox, string dato)
        {
            // Asigna el texto inicial y color del placeholder
            txtBox.Text = dato;
            txtBox.ForeColor = Color.Gray;

            // Evento Enter
            txtBox.Enter += (s, e) =>
            {
                if (txtBox.Text == dato)
                {
                    txtBox.Text = "";
                    txtBox.ForeColor = Color.Black; // Cambia el color al escribir
                }
            };

            // Evento Leave
            txtBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBox.Text))
                {
                    txtBox.Text = dato;
                    txtBox.ForeColor = Color.Gray; // Cambia el color del placeholder
                }
            };
        }
        // Función que configura el placeholder para cualquier ComboBox
        private void PlaceHolder(ComboBox cmb, string dato)
        {
            // Asigna el texto inicial y color del placeholder
            cmb.Text = dato;
            cmb.ForeColor = Color.Gray;

            // Evento Enter
            cmb.Enter += (s, e) =>
            {
                if (cmb.Text == dato)
                {
                    cmb.Text = "";
                    cmb.ForeColor = Color.Black; // Cambia el color al escribir
                }
            };

            // Evento Leave
            cmb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(cmb.Text))
                {
                    cmb.Text = dato;
                    cmb.ForeColor = Color.Gray; // Cambia el color del placeholder
                }
            };
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardado");
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincia.SelectedValue != null && cmbProvincia.SelectedValue is int)
            {
                int idProvincia = Convert.ToInt32(cmbProvincia.SelectedValue);
                nuevo.CargarLocalidades(cmbLocalidad, idProvincia);
            }
        }

        //Funcion OPT Seleccionado --- GroupBox IVA
        private void optSeleccionado(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Cambia  dependiendo del opt seleccionado
                if (rb == optSi) grbIva.Enabled = true;
                else if (rb == optNo) grbIva.Enabled = false;
            }
        }
    }
}