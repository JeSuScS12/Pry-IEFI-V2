namespace Gestion.Forms_Modulo_Proveedores
{
    partial class frmProveedoresModificar
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
            this.panelProveedoresModificar = new System.Windows.Forms.Panel();
            this.gpbAgregar = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.panelProveedoresModificar.SuspendLayout();
            this.gpbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProveedoresModificar
            // 
            this.panelProveedoresModificar.AutoSize = true;
            this.panelProveedoresModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.panelProveedoresModificar.Controls.Add(this.gpbAgregar);
            this.panelProveedoresModificar.Controls.Add(this.lblSeleccion);
            this.panelProveedoresModificar.Controls.Add(this.dgvProveedores);
            this.panelProveedoresModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProveedoresModificar.Location = new System.Drawing.Point(0, 0);
            this.panelProveedoresModificar.Margin = new System.Windows.Forms.Padding(4);
            this.panelProveedoresModificar.Name = "panelProveedoresModificar";
            this.panelProveedoresModificar.Size = new System.Drawing.Size(1000, 668);
            this.panelProveedoresModificar.TabIndex = 9;
            // 
            // gpbAgregar
            // 
            this.gpbAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbAgregar.Controls.Add(this.dtpFecha);
            this.gpbAgregar.Controls.Add(this.lblFecha);
            this.gpbAgregar.Controls.Add(this.cmbEstado);
            this.gpbAgregar.Controls.Add(this.lblProveedor);
            this.gpbAgregar.Controls.Add(this.btnModificar);
            this.gpbAgregar.Controls.Add(this.lblstock);
            this.gpbAgregar.Controls.Add(this.lblprecio);
            this.gpbAgregar.Controls.Add(this.lblcategoria);
            this.gpbAgregar.Controls.Add(this.lbldescripcion);
            this.gpbAgregar.Controls.Add(this.lblnombre);
            this.gpbAgregar.Controls.Add(this.cmbCategoria);
            this.gpbAgregar.Controls.Add(this.txtTelefono);
            this.gpbAgregar.Controls.Add(this.txtCorreo);
            this.gpbAgregar.Controls.Add(this.txtDireccion);
            this.gpbAgregar.Controls.Add(this.txtNombre);
            this.gpbAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpbAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.gpbAgregar.Location = new System.Drawing.Point(39, 104);
            this.gpbAgregar.Name = "gpbAgregar";
            this.gpbAgregar.Size = new System.Drawing.Size(386, 449);
            this.gpbAgregar.TabIndex = 14;
            this.gpbAgregar.TabStop = false;
            this.gpbAgregar.Text = "Modificar Datos";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(170, 328);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 21);
            this.dtpFecha.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblFecha.Location = new System.Drawing.Point(20, 324);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(154, 34);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha de inicio:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Electronica global",
            "El rey de la carne"});
            this.cmbEstado.Location = new System.Drawing.Point(129, 276);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(241, 24);
            this.cmbEstado.TabIndex = 16;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblProveedor.ForeColor = System.Drawing.Color.White;
            this.lblProveedor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblProveedor.Location = new System.Drawing.Point(20, 274);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(103, 34);
            this.lblProveedor.TabIndex = 15;
            this.lblProveedor.Text = "Estado:";
            this.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(90, 374);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(211, 54);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblstock
            // 
            this.lblstock.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblstock.ForeColor = System.Drawing.Color.White;
            this.lblstock.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblstock.Location = new System.Drawing.Point(20, 224);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(83, 34);
            this.lblstock.TabIndex = 10;
            this.lblstock.Text = "Correo:";
            this.lblstock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblprecio
            // 
            this.lblprecio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblprecio.ForeColor = System.Drawing.Color.White;
            this.lblprecio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblprecio.Location = new System.Drawing.Point(20, 174);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(83, 34);
            this.lblprecio.TabIndex = 9;
            this.lblprecio.Text = "Teléfono:";
            this.lblprecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcategoria
            // 
            this.lblcategoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblcategoria.ForeColor = System.Drawing.Color.White;
            this.lblcategoria.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblcategoria.Location = new System.Drawing.Point(20, 124);
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
            this.lbldescripcion.Location = new System.Drawing.Point(20, 74);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(91, 34);
            this.lbldescripcion.TabIndex = 7;
            this.lbldescripcion.Text = "Dirección:";
            this.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblnombre.Location = new System.Drawing.Point(20, 24);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(83, 34);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Electronica",
            "Alimentos",
            "Ropa"});
            this.cmbCategoria.Location = new System.Drawing.Point(129, 129);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(241, 24);
            this.cmbCategoria.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(129, 180);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(241, 21);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.Text = "\r\n";
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(129, 228);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 21);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(129, 81);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(241, 21);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 21);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblSeleccion.ForeColor = System.Drawing.Color.White;
            this.lblSeleccion.Location = new System.Drawing.Point(35, 34);
            this.lblSeleccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(401, 48);
            this.lblSeleccion.TabIndex = 13;
            this.lblSeleccion.Text = "Seleccionar un Proveedor en la Tabla \r\npara MODIFICAR\r\n";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToResizeColumns = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProveedores.Location = new System.Drawing.Point(444, 53);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(527, 600);
            this.dgvProveedores.TabIndex = 4;
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellClick);
            // 
            // frmProveedoresModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1000, 668);
            this.Controls.Add(this.panelProveedoresModificar);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProveedoresModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedoresModificar";
            this.Load += new System.EventHandler(this.frmProveedoresModificar_Load);
            this.panelProveedoresModificar.ResumeLayout(false);
            this.panelProveedoresModificar.PerformLayout();
            this.gpbAgregar.ResumeLayout(false);
            this.gpbAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProveedoresModificar;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.GroupBox gpbAgregar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
    }
}