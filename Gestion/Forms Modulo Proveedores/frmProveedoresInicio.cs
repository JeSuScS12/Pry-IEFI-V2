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

namespace Gestion.Forms_Modulo_Proveedores
{
    public partial class frmProveedoresInicio : Form
    {
        public frmProveedoresInicio()
        {
            InitializeComponent();
        }
        clsConexionProveedores ObjProveedores = new clsConexionProveedores();
        private void frmProveedoresInicio_Load(object sender, EventArgs e)
        {
            ObjProveedores.ListarProveedores(tvProveedores);
        }

        private void tvProveedores_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Tag != null)
            {              
                string proveedor = e.Node.Text;
                DataRow datosProveedor = ObjProveedores.DatosProveedor(proveedor);
                if (datosProveedor != null)
                {
                    lblNom.Text = datosProveedor["Nombre"].ToString();
                    lblDirec.Text = datosProveedor["Direccion"].ToString();
                    lblCat.Text = datosProveedor["Categoria"].ToString();
                    lblTel.Text = datosProveedor["Telefono"].ToString();
                    lblCorr.Text = datosProveedor["Correo"].ToString();
                    lblFechaInicio.Text = DateTime.Parse(datosProveedor["FechaInicio"].ToString()).ToShortDateString();

                    int idEstado = Convert.ToInt32(datosProveedor["IdEstado"]);
                    chkActivo.Checked = (idEstado == 1);
                    chkActivo.Enabled = (idEstado == 1);
                }else
                {
                    MessageBox.Show("Error");
                }

                int idProveedor = Convert.ToInt32(e.Node.Tag);
                ObjProveedores.CargarProductosProveedor(dgvProductos, idProveedor);
                AjustarColumnas();
            }
        }
        public void AjustarColumnas()
        {
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.Columns[0].HeaderText = "ID";
            dgvProductos.Columns[0].Width = 50;
            dgvProductos.Columns[1].HeaderText = "Producto";
            dgvProductos.Columns[1].Width = 150;
            dgvProductos.Columns[2].Width = 150;
            dgvProductos.Columns[3].Width = 60;
            dgvProductos.Columns[4].HeaderText = "Categoría";
            dgvProductos.Columns[4].Width = 100;
            dgvProductos.Columns[5].HeaderText = "Estado";
            dgvProductos.Columns[5].Width = 70;
        }
    }
}
