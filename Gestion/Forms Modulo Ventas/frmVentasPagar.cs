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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;


namespace Gestion.Forms_Modulo_Ventas
{
    public partial class frmVentasPagar : Form
    {
        public frmVentasPagar()
        {
            InitializeComponent();
            CargarTabla(dgvCarrito, clsCarrito.carrito);
        }

        //Instanciar clases
        clsConexionClientes  nuevo = new clsConexionClientes();
        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVentasPagar_Load(object sender, EventArgs e)
        {
            optSi.CheckedChanged += new EventHandler(optSeleccionado);
            optNo.CheckedChanged += new EventHandler(optSeleccionado);


            //Dando formato a las columnas
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.Columns[0].Width = 59;
            dgvCarrito.Columns[1].Width = 291;
            dgvCarrito.Columns[2].Width = 63;
            dgvCarrito.Columns[3].Width = 88;
            dgvCarrito.Columns[4].Width = 74;

            dgvCarrito.Columns.RemoveAt(5);

            ActualizarCarrito();
        }
        public void CargarTabla(DataGridView dataGridView, DataTable dataTable)
        {
            // Limpiar el DataGridView antes de cargar nuevos datos
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Asignar el DataTable como fuente de datos del DataGridView
            dataGridView.DataSource = dataTable;
        }

        private void ActualizarCarrito()
        {
            decimal totalCarrito = 0;

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                totalCarrito += Convert.ToDecimal(row.Cells[4].Value);
            }
            //Mostrar en lblTotal
            lblTotal.Text = $"{totalCarrito:c2}";  // Formato de moneda C2
        }


        //GEnerar la factura en PDF
        private void btnPagar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string plantilla = Properties.Resources.factura.ToString();
            plantilla = plantilla.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yy  HH:mm"));

            string filas = string.Empty;
            decimal total = 0;

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cod."].Value.ToString() + "</td>";
                filas += "<td align='left'>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td align='right'>" + row.Cells["Cant."].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio Uni."].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Importe"].Value.ToString());
            }
            plantilla = plantilla.Replace("@FILAS", filas);
            plantilla = plantilla.Replace("@TOTAL", total.ToString());


            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    Document pdf = new Document(PageSize.A5, 20, 20, 20, 20);
                    PdfWriter escribir = PdfWriter.GetInstance(pdf, stream);

                    pdf.Open();

                    pdf.Add(new Phrase(""));
                    using (StringReader sr = new StringReader(plantilla))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(escribir, pdf, sr);
                    }

                    pdf.Close();
                    stream.Close();
                }
            }
        }

        //Funcion OPT Seleccionado 
        private void optSeleccionado(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Cambia  dependiendo del opt seleccionado
                if (rb == optSi)
                {
                    txtDNI.Text = "";
                    txtDNI.Enabled = true;

                    txtNombre.Enabled = false;
                    txtDireccion.Enabled = false;
                }
                else if (rb == optNo)
                {
                    txtDNI.Enabled= true;
                    txtDNI.Text = "";
                    txtNombre.Enabled= true;
                    txtNombre.Text = "";
                    txtDireccion.Enabled= true;
                    txtDireccion.Text = "";
                }
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (optSi.Checked && txtDNI.TextLength == 8)
            {
                nuevo.DNI(txtDNI.Text.Trim());
                if (cslClienteCompra.DNI.Any())
                {
                    txtNombre.Text = cslClienteCompra.Cliente;
                    txtDireccion.Text = cslClienteCompra.Direccion;
                }
                else MessageBox.Show("DNI no registrado", "Notificacion");
            }
            
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el evento si no es un número
                e.Handled = true;
            }
        }
    }
}
