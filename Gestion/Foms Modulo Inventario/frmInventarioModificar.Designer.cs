namespace Gestion.Foms_Modulo_Inventario
{
    partial class frmInventarioModificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelModificar = new System.Windows.Forms.Panel();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.gpbModificar = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.panelModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gpbModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelModificar
            // 
            this.panelModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.panelModificar.Controls.Add(this.lblSeleccion);
            this.panelModificar.Controls.Add(this.dgvProductos);
            this.panelModificar.Controls.Add(this.gpbModificar);
            this.panelModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModificar.Location = new System.Drawing.Point(0, 0);
            this.panelModificar.Name = "panelModificar";
            this.panelModificar.Size = new System.Drawing.Size(1000, 691);
            this.panelModificar.TabIndex = 8;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblSeleccion.ForeColor = System.Drawing.Color.White;
            this.lblSeleccion.Location = new System.Drawing.Point(3, 9);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(411, 48);
            this.lblSeleccion.TabIndex = 13;
            this.lblSeleccion.Text = "Seleccionar una Categoria en la Tabla \r\npara MODIFICAR\r\n";
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Cursor = System.Windows.Forms.Cursors.No;
            this.dgvProductos.Location = new System.Drawing.Point(419, 9);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(569, 670);
            this.dgvProductos.TabIndex = 4;
            // 
            // gpbModificar
            // 
            this.gpbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbModificar.Controls.Add(this.btnModificar);
            this.gpbModificar.Controls.Add(this.lblstock);
            this.gpbModificar.Controls.Add(this.lblprecio);
            this.gpbModificar.Controls.Add(this.lblcategoria);
            this.gpbModificar.Controls.Add(this.lbldescripcion);
            this.gpbModificar.Controls.Add(this.lblnombre);
            this.gpbModificar.Controls.Add(this.cmbCategoria);
            this.gpbModificar.Controls.Add(this.txtPrecio);
            this.gpbModificar.Controls.Add(this.txtStock);
            this.gpbModificar.Controls.Add(this.txtDescripcion);
            this.gpbModificar.Controls.Add(this.txtnombre);
            this.gpbModificar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpbModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.gpbModificar.Location = new System.Drawing.Point(12, 74);
            this.gpbModificar.Name = "gpbModificar";
            this.gpbModificar.Size = new System.Drawing.Size(401, 443);
            this.gpbModificar.TabIndex = 3;
            this.gpbModificar.TabStop = false;
            this.gpbModificar.Text = "Modificar Datos";
            this.gpbModificar.Enter += new System.EventHandler(this.gpbModificar_Enter);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnModificar.Location = new System.Drawing.Point(91, 367);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(211, 54);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // lblstock
            // 
            this.lblstock.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblstock.ForeColor = System.Drawing.Color.White;
            this.lblstock.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblstock.Location = new System.Drawing.Point(20, 305);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(127, 34);
            this.lblstock.TabIndex = 10;
            this.lblstock.Text = "Stock:";
            this.lblstock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblprecio
            // 
            this.lblprecio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblprecio.ForeColor = System.Drawing.Color.White;
            this.lblprecio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblprecio.Location = new System.Drawing.Point(20, 236);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(127, 34);
            this.lblprecio.TabIndex = 9;
            this.lblprecio.Text = "Precio:";
            this.lblprecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcategoria
            // 
            this.lblcategoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblcategoria.ForeColor = System.Drawing.Color.White;
            this.lblcategoria.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblcategoria.Location = new System.Drawing.Point(20, 177);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(127, 34);
            this.lblcategoria.TabIndex = 8;
            this.lblcategoria.Text = "Categoria:";
            this.lblcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbldescripcion.ForeColor = System.Drawing.Color.White;
            this.lbldescripcion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbldescripcion.Location = new System.Drawing.Point(20, 108);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(127, 34);
            this.lbldescripcion.TabIndex = 7;
            this.lbldescripcion.Text = "Descripción:";
            this.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblnombre.Location = new System.Drawing.Point(20, 44);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(127, 34);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(153, 187);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(153, 246);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Text = "\r\n";
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(153, 315);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(121, 20);
            this.txtStock.TabIndex = 3;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(153, 118);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(190, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(153, 54);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // frmInventarioModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 691);
            this.Controls.Add(this.panelModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioModificar";
            this.Text = "frmInventarioModificar";
            this.panelModificar.ResumeLayout(false);
            this.panelModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gpbModificar.ResumeLayout(false);
            this.gpbModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelModificar;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox gpbModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtnombre;
    }
}