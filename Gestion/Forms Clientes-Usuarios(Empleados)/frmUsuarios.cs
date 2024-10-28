using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Gestion.Clases;

namespace Gestion.Forms_Clientes_Usuarios_Empleados_
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        clsUsuarios users = new clsUsuarios();

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            users.CargarUsuarios(dgvUsuarios);
            users.CargarEstados(cmbEstado);
            users.CargarCargos(cmbCargo);
            DiseñoTabla(dgvUsuarios);
        }

        //Dimensiones del DGV Clientes
        public void DiseñoTabla(DataGridView tabla)
        {
            tabla.Columns[0].Width = 40;
            tabla.Columns[1].Width = 210;
            tabla.Columns[2].Width = 125;
            tabla.Columns[3].Width = 180;
            tabla.Columns[4].Width = 135;
            tabla.Columns[5].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        }

        OpenFileDialog foto = new OpenFileDialog();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            foto.Title = "Buscar";
            foto.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos (*.*)|*.*";

            if (foto.ShowDialog() == DialogResult.OK)
            {
                string ruta = foto.FileName;
                try
                {
                    // Cargar la imagen en el PictureBox
                    pcbAvatar.Image = Image.FromFile(ruta);
                    pcbAvatar.SizeMode = PictureBoxSizeMode.Zoom; // Ajustar el tamaño si es necesario
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cargo = cmbCargo.SelectedIndex + 1;
            int estado = cmbEstado.SelectedIndex + 1;
            users.GuardarDatos(txtNombre.Text, txtDNI.Text, txtDireccion.Text, txtCorreo.Text, txtTelefono.Text, estado,cargo, pcbAvatar);
            users.CargarUsuarios(dgvUsuarios);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '-'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
