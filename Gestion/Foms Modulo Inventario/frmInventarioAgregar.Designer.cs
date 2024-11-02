namespace Gestion.Foms_Modulo_Inventario
{
    partial class frmInventarioAgregar
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
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbAgregar = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
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
            this.panelAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gpbAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgregar
            // 
            this.panelAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.panelAgregar.Controls.Add(this.dgvProductos);
            this.panelAgregar.Controls.Add(this.gpbAgregar);
            this.panelAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAgregar.Location = new System.Drawing.Point(0, 0);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(1000, 668);
            this.panelAgregar.TabIndex = 7;
            this.panelAgregar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAgregar_Paint_1);
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProductos.Location = new System.Drawing.Point(430, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(548, 631);
            this.dgvProductos.TabIndex = 4;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "idProducto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripción";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Stock";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Categoria";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Proveedor";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Fecha Ingreso";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // gpbAgregar
            // 
            this.gpbAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbAgregar.Controls.Add(this.dtpFecha);
            this.gpbAgregar.Controls.Add(this.lblFecha);
            this.gpbAgregar.Controls.Add(this.cmbProveedor);
            this.gpbAgregar.Controls.Add(this.lblProveedor);
            this.gpbAgregar.Controls.Add(this.btnAgregar);
            this.gpbAgregar.Controls.Add(this.lblstock);
            this.gpbAgregar.Controls.Add(this.lblprecio);
            this.gpbAgregar.Controls.Add(this.lblcategoria);
            this.gpbAgregar.Controls.Add(this.lbldescripcion);
            this.gpbAgregar.Controls.Add(this.lblnombre);
            this.gpbAgregar.Controls.Add(this.cmbCategoria);
            this.gpbAgregar.Controls.Add(this.txtPrecio);
            this.gpbAgregar.Controls.Add(this.txtStock);
            this.gpbAgregar.Controls.Add(this.txtDescripcion);
            this.gpbAgregar.Controls.Add(this.txtnombre);
            this.gpbAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpbAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.gpbAgregar.Location = new System.Drawing.Point(12, 12);
            this.gpbAgregar.Name = "gpbAgregar";
            this.gpbAgregar.Size = new System.Drawing.Size(386, 470);
            this.gpbAgregar.TabIndex = 3;
            this.gpbAgregar.TabStop = false;
            this.gpbAgregar.Text = "Carga de Datos";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(180, 339);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblFecha.Location = new System.Drawing.Point(20, 332);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(154, 34);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha de ingreso:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Items.AddRange(new object[] {
            "Electronica global",
            "El rey de la carne"});
            this.cmbProveedor.Location = new System.Drawing.Point(180, 293);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedor.TabIndex = 16;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblProveedor.ForeColor = System.Drawing.Color.White;
            this.lblProveedor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblProveedor.Location = new System.Drawing.Point(20, 283);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(103, 34);
            this.lblProveedor.TabIndex = 15;
            this.lblProveedor.Text = "Proveedor:";
            this.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(90, 394);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(211, 54);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lblstock
            // 
            this.lblstock.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblstock.ForeColor = System.Drawing.Color.White;
            this.lblstock.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblstock.Location = new System.Drawing.Point(20, 235);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(83, 34);
            this.lblstock.TabIndex = 10;
            this.lblstock.Text = "Stock:";
            this.lblstock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblprecio
            // 
            this.lblprecio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblprecio.ForeColor = System.Drawing.Color.White;
            this.lblprecio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblprecio.Location = new System.Drawing.Point(20, 182);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(83, 34);
            this.lblprecio.TabIndex = 9;
            this.lblprecio.Text = "Precio:";
            this.lblprecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcategoria
            // 
            this.lblcategoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblcategoria.ForeColor = System.Drawing.Color.White;
            this.lblcategoria.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblcategoria.Location = new System.Drawing.Point(20, 136);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(103, 34);
            this.lblcategoria.TabIndex = 8;
            this.lblcategoria.Text = "Categoria:";
            this.lblcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbldescripcion.ForeColor = System.Drawing.Color.White;
            this.lbldescripcion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbldescripcion.Location = new System.Drawing.Point(20, 88);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(129, 34);
            this.lbldescripcion.TabIndex = 7;
            this.lbldescripcion.Text = "Descripción:";
            this.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblnombre.Location = new System.Drawing.Point(20, 37);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(83, 34);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Electronica",
            "Alimentos",
            "Ropa"});
            this.cmbCategoria.Location = new System.Drawing.Point(180, 146);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(180, 192);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Text = "\r\n";
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress_1);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(180, 245);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(121, 20);
            this.txtStock.TabIndex = 3;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress_1);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(180, 98);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(190, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(180, 47);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // frmInventarioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 668);
            this.Controls.Add(this.panelAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioAgregar";
            this.Text = "frmInventarioAgregar";
            this.Load += new System.EventHandler(this.frmInventarioAgregar_Load);
            this.panelAgregar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gpbAgregar.ResumeLayout(false);
            this.gpbAgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAgregar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox gpbAgregar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnAgregar;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}