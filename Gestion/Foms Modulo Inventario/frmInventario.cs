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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
            AbrirFrm(new frmInventarioInicio());
        }
        //Funcion para Abrir frm en Panel Inventario
        private void AbrirFrm(object frmHijo)
        {
            if (this.panelInventario.Controls.Count > 0)
            {
                this.panelInventario.Controls.RemoveAt(0);
            }

            Form frm = frmHijo as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelInventario.Controls.Add(frm);
            this.panelInventario.Tag = frm;
            frm.Show();
            mspOpciones.Height = 50;
        }

        private void proToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmInventarioInicio());
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmInventarioAgregar());
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmInventarioModificar());
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmInventarioEliminar());
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmInventraioCategorias());
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmInventarioBusqueda());
        }

        private void solicitudDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmInventarioSolicitudStock());
        }

        private void mspOpciones_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void agregarProductosExistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmInventarioAgregarExcelAccess());
        }
    }
}
