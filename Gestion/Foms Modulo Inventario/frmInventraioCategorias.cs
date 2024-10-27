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
    public partial class frmInventraioCategorias : Form
    {
        public frmInventraioCategorias()
        {
            InitializeComponent();
        }

        private void lblCategoria2_Click(object sender, EventArgs e)
        {

        }

        private void lblcategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void frmInventraioCategorias_Load(object sender, EventArgs e)
        {
            clsCategoriasInv.ListarTablaCategorias(dgvCategorias);
        }
        clsCategoriasInv clsCategoriasInv = new clsCategoriasInv();
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Verifica que el campo de la categoría no esté vacío.
            if (!string.IsNullOrWhiteSpace(txtCategoriaAgregar.Text))
            {  
                clsCategoriasInv.AgregarCat(txtCategoriaAgregar.Text);  
                txtCategoriaAgregar.Clear();
            }
            else
            {
                // Muestra un mensaje de error si el campo está vacío.
                MessageBox.Show("Por favor, ingrese un nombre para la categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            clsCategoriasInv.ListarTablaCategorias(dgvCategorias);

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvCategorias.Rows[e.RowIndex];

                // Llena los TextBox con los valores de la fila seleccionada
                //txtIdProd.Text = filaSeleccionada.Cells["Column1"].Value.ToString();
                txtCategoriaModElim.Text = filaSeleccionada.Cells["Column2"].Value.ToString();
                
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
