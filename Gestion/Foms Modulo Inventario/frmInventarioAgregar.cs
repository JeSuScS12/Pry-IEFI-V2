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

namespace Gestion.Foms_Modulo_Inventario
{
    public partial class frmInventarioAgregar : Form
    {
        public frmInventarioAgregar()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;

            btnAgregar.BackColor = Color.Gray;
            txtnombre.TextChanged += TextBox_TextChanged;
            txtDescripcion.TextChanged += TextBox_TextChanged;
            txtPrecio.TextChanged += TextBox_TextChanged;
            txtStock.TextChanged += TextBox_TextChanged;
        }
        #region Controles de TextBoxs
        private void EstadoDeTextos()
        {
            bool estado = !string.IsNullOrWhiteSpace(txtnombre.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text) && !string.IsNullOrWhiteSpace(txtDescripcion.Text) && !string.IsNullOrWhiteSpace(txtStock.Text);
            btnAgregar.Enabled = estado;
            if (estado == false) { btnAgregar.BackColor = Color.Gray; }
            else { btnAgregar.BackColor = Color.FromArgb(47, 117, 255); }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            EstadoDeTextos();
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
        clsInventario clsInventario = new clsInventario();
        clsCategoriasInv clsCategoriasInv = new clsCategoriasInv();
        clsProveedoresInv clsProveedoresInv = new clsProveedoresInv();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void panelAgregar_Paint(object sender, PaintEventArgs e)
        {

        }
         
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmInventarioAgregar_Load(object sender, EventArgs e)
        {
            clsInventario.ListarProductos(dgvProductos);
            clsCategoriasInv.CargaCMB(cmbCategoria);
            clsProveedoresInv.CargaCMB(cmbProveedor);
        }
        private void LimpiarComandos() 
        {
            txtDescripcion.Clear();
            txtnombre.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtIdProd.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtIdProd.Text);
            clsInventario.Buscar(cod);
            if (clsInventario.idProducto != cod)
            {
                clsInventario.idProducto = Convert.ToInt32(txtIdProd.Text);
                clsInventario.Nombre = txtnombre.Text;
                clsInventario.Descripcion = txtDescripcion.Text;
                clsInventario.Precio = Convert.ToDecimal(txtPrecio.Text);
                clsInventario.Stock = Convert.ToInt32(txtStock.Text);
                clsInventario.idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                clsInventario.idProveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
                clsInventario.FechaIngreso = Convert.ToDateTime(dtpFecha.Value);
                clsInventario.AgregarProducto();
                MessageBox.Show("Producto agregado con éxito");
                LimpiarComandos();
                
            }
            else
            {
                MessageBox.Show("Este producto ya se encuentra registrado");
                LimpiarComandos();
            }
            clsInventario.ListarProductos(dgvProductos);
        }

        private void panelAgregar_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
