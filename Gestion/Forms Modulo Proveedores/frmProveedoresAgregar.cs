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

namespace Gestion.Forms_Modulo_Proveedores
{
    public partial class frmProveedoresAgregar : Form
    {
        public frmProveedoresAgregar()
        {
            InitializeComponent();
        }
        clsConexionProveedores ObjProveedores = new clsConexionProveedores();
        private void frmProveedoresAgregar_Load(object sender, EventArgs e)
        {
            ObjProveedores.CargarCategorias(cmbCategoria);
            ObjProveedores.CargarEstados(cmbEstado);
            ObjProveedores.ListarProveedores(dgvProveedores);
            AjustarColumnas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && cmbCategoria.Text != "" && txtDireccion.Text != "" 
                && txtTelefono.Text != "" && txtCorreo.Text != "" && cmbEstado.Text != "" &&
                dtpFecha.Text != "")
            {
                String nombre = txtNombre.Text;
                Int32 cate = Convert.ToInt32(cmbCategoria.SelectedValue);
                String direccion = txtDireccion.Text;
                Int32 estado = Convert.ToInt32(cmbEstado.SelectedValue);
                String telefono = txtTelefono.Text;
                String correo = txtCorreo.Text;
                DateTime fecha = dtpFecha.Value.Date;

                ObjProveedores.Agregar(nombre, cate, estado, direccion, telefono, correo, fecha);
                Limpiar();
                ObjProveedores.ListarProveedores(dgvProveedores);
            }
        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            cmbCategoria.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            dtpFecha.ResetText();
        }
        public void AjustarColumnas()
        {
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.Columns[0].HeaderText = "ID";
            dgvProveedores.Columns[0].Width = 30;
            dgvProveedores.Columns[1].HeaderText = "Proveedor";
            dgvProveedores.Columns[1].Width = 80;
            dgvProveedores.Columns[2].HeaderText = "Categoría";
            dgvProveedores.Columns[3].HeaderText = "Estado";
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
