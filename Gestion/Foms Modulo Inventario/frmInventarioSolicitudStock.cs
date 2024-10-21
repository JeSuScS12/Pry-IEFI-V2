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
    public partial class frmInventarioSolicitudStock : Form
    {
        public frmInventarioSolicitudStock()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;

            btnAgregar.BackColor = Color.Gray;
            txtnombre.TextChanged += TextBox_TextChanged;
            txtDescripcion.TextChanged += TextBox_TextChanged;
          
            txtStock.TextChanged += TextBox_TextChanged;
        }

        #region Controles de TextBoxs
        private void EstadoDeTextos()
        {
            bool estado = !string.IsNullOrWhiteSpace(txtnombre.Text)  && !string.IsNullOrWhiteSpace(txtDescripcion.Text) && !string.IsNullOrWhiteSpace(txtStock.Text);
            btnAgregar.Enabled = estado;
            if (estado == false) { btnAgregar.BackColor = Color.Gray; }
            else { btnAgregar.BackColor = Color.FromArgb(47, 117, 255); }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            EstadoDeTextos();
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void gpbAgregar_Enter(object sender, EventArgs e)
        {

        }
    }
}
