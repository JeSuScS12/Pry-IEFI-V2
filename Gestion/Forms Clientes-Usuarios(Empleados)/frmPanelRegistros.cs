using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Forms_Clientes_Usuarios_Empleados_
{
    public partial class frmPanelRegistros : Form
    {
        public frmPanelRegistros()
        {
            InitializeComponent();
        }

        //Funcion para Abrir frm en Panel Contenedor
        private void AbrirFrm(object frmHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form frm = frmHijo as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(frm);
            this.panelContenedor.Tag = frm;
            frm.Show();
        }

        private void frmPanelGeneral_Load(object sender, EventArgs e)
        {
            AbrirFrm(new frmCliente());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
