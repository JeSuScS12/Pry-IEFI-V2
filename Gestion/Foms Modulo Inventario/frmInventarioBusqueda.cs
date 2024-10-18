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
    public partial class frmInventarioBusqueda : Form
    {
        public frmInventarioBusqueda()
        {
            InitializeComponent();
           
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            
            txtCodigo.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbStock.SelectedIndex = -1;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            cmbStock.SelectedIndex = -1;
            if (cmbCategoria.SelectedIndex >= 0)
            {
               
            }
            else
            {
                
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigo.Text, out int codigo))
            { }
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbStock.SelectedIndex = -1;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
