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
    public partial class frmProveedoresModificar : Form
    {
        public frmProveedoresModificar()
        {
            InitializeComponent();
        }
        clsConexionProveedores ObjModificar = new clsConexionProveedores();

        private void btnModificar_Click(object sender, EventArgs e)
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

                ObjModificar.Modificar(dgvProveedores, nombre, cate, estado, direccion, telefono, correo, fecha);
                Limpiar();
                ObjModificar.ListarProveedores(dgvProveedores);
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

        private void frmProveedoresModificar_Load(object sender, EventArgs e)
        {           
            ObjModificar.ListarProveedores(dgvProveedores);
            ObjModificar.CargarCategorias(cmbCategoria);
            ObjModificar.CargarEstados(cmbEstado);
            AjustarColumnas();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSelec = dgvProveedores.Rows[e.RowIndex];

                txtNombre.Text = filaSelec.Cells["NombreProveedor"].Value.ToString();
                txtDireccion.Text = filaSelec.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = filaSelec.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = filaSelec.Cells["Correo"].Value.ToString();
                cmbCategoria.Text = filaSelec.Cells["Categoria"].Value.ToString();
                cmbEstado.Text = filaSelec.Cells["EstadoProveedor"].Value.ToString();
                dtpFecha.Text = filaSelec.Cells["FechaInicio"].Value.ToString();
            }
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
            dgvProveedores.Columns[3].Width = 60;
            dgvProveedores.Columns[4].Width = 100;
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
