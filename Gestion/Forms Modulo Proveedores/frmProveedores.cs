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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        private void AbrirFrm(object frmHijo)
        {
            if (this.panelProveedores.Controls.Count > 0)
            {
                this.panelProveedores.Controls.RemoveAt(0);
            }

            Form frm = frmHijo as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelProveedores.Controls.Add(frm);
            this.panelProveedores.Tag = frm;
            frm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmProveedoresAgregar());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmProveedoresModificar());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmProveedoresInicio());
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            AbrirFrm(new frmProveedoresInicio());
        }
    }
}
