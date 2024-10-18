using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Usando esto para redondear bordes del form
using System.Runtime.InteropServices;
using Gestion.Forms_Modulos;
using Gestion.Forms_Clientes_Usuarios_Empleados_;
using Gestion.Foms_Modulo_Inventario;

namespace Gestion
{
    public partial class frmPrincipal : Form
    {
        //Averiguar que es?
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public frmPrincipal()
        {
            InitializeComponent();
            //Funcion para bordes redondos
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));   // <--- border radius 25
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmVentas());
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmPanelRegistros());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFrm(new frmInventario());
        }
    }
}
