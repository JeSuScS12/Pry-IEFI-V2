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

namespace Gestion.Forms_Modulos
{
    public partial class frmVentas_Agregar : Form
    {
        public frmVentas_Agregar()
        {
            InitializeComponent();
        }

        private void frmVentas_Agregar_Load(object sender, EventArgs e)
        {
            lblProducto.Text = clsProducto.nombre;
            lblDescripcion.Text = clsProducto.descripcion;
            lblPrecio.Text = "$" + clsProducto.precio.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            int cantidad = Convert.ToInt32(cant.Value);
            clsProducto.cant = cantidad;
            this.Close();
        }
    }
}
