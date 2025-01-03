﻿using Gestion.Clases;
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
    public partial class frmInventarioEliminar : Form
    {
        public frmInventarioEliminar()
        {
            InitializeComponent();
            Movimientodgv();
            btnEliminar.Enabled = false;
            btnEliminar.BackColor = Color.Gray;
            //Contoles que verifican si las cajas de texto contienen caracteres
            txtnombre.TextChanged += TextBox_TextChanged;
            txtDescripcion.TextChanged += TextBox_TextChanged;
            txtPrecio.TextChanged += TextBox_TextChanged;
            txtStock.TextChanged += TextBox_TextChanged;
        }
        #region Controles de TextBoxs
        private void EstadoDeTextos()
        {
            bool estado = !string.IsNullOrWhiteSpace(txtnombre.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text) && !string.IsNullOrWhiteSpace(txtDescripcion.Text) && !string.IsNullOrWhiteSpace(txtStock.Text);
            btnEliminar.Enabled = estado;
            if (estado == false) { btnEliminar.BackColor = Color.Gray; }
            else { btnEliminar.BackColor = Color.FromArgb(47, 117, 255); }
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
        private void frmInventarioEliminar_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void LimpiarComandos()
        {
            txtIdProd.Clear();
            txtDescripcion.Clear();
            txtnombre.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtIdProd.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void panelEliminar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmInventarioEliminar_Load_1(object sender, EventArgs e)
        {
            clsInventario.ListarProductos(dgvProductos);
            clsCategoriasInv.CargaCMB(cmbCategoria);
            clsProveedoresInv.CargaCMB(cmbProveedor);
            clsInventario.ListarProductos(dgvProductos);
        }

        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvProductos.Rows[e.RowIndex];

                // Llena los TextBox con los valores de la fila seleccionada
                txtIdProd.Text = filaSeleccionada.Cells["Column1"].Value.ToString();
                txtnombre.Text = filaSeleccionada.Cells["Column2"].Value.ToString();
                txtDescripcion.Text = filaSeleccionada.Cells["Column3"].Value.ToString();
                txtPrecio.Text = filaSeleccionada.Cells["Column4"].Value.ToString();
                txtStock.Text = filaSeleccionada.Cells["Column5"].Value.ToString();
                cmbCategoria.SelectedIndex = cmbCategoria.FindStringExact(filaSeleccionada.Cells["Column6"].Value.ToString());
                cmbProveedor.SelectedIndex = cmbProveedor.FindStringExact(filaSeleccionada.Cells["Column7"].Value.ToString());
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No)
                {
                    return;
                }
                Int32 cod = Convert.ToInt32(txtIdProd.Text);
                clsInventario.EliminarProducto(cod);
                LimpiarComandos();
                clsInventario.ListarProductos(dgvProductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        //Maneja el tamaño de las columnas y filas. Agrega barras de scroll lateral y vertical para mejorar la vista de los campos de productos
        private void Movimientodgv()
        {
            dgvProductos.ScrollBars = ScrollBars.Both;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                column.Width = 150;
            }
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                row.Height = 30;
            }
        }

        //Hace que solo se pueda colocar numeros en ambos textboxs
        private void txtPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProductos.Columns["Column3"].Index)
            {
                // Ajusta automáticamente el ancho de la columna de Descripción
                dgvProductos.AutoResizeColumn(e.ColumnIndex, DataGridViewAutoSizeColumnMode.DisplayedCells);
            }
        }
    }
}
