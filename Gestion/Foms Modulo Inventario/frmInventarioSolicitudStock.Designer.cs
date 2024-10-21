namespace Gestion.Foms_Modulo_Inventario
{
    partial class frmInventarioSolicitudStock
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
            this.panelInventario = new System.Windows.Forms.Panel();
            this.btnEliminarSolicitud = new System.Windows.Forms.Button();
            this.btnSolicitud = new System.Windows.Forms.Button();
            this.lblSolicitud = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.gpbAgregar = new System.Windows.Forms.GroupBox();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.panelInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gpbAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInventario
            // 
            this.panelInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.panelInventario.Controls.Add(this.btnEliminarSolicitud);
            this.panelInventario.Controls.Add(this.btnSolicitud);
            this.panelInventario.Controls.Add(this.lblSolicitud);
            this.panelInventario.Controls.Add(this.dgvProductos);
            this.panelInventario.Controls.Add(this.gpbAgregar);
            this.panelInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInventario.Location = new System.Drawing.Point(0, 0);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(1000, 691);
            this.panelInventario.TabIndex = 3;
            // 
            // btnEliminarSolicitud
            // 
            this.btnEliminarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnEliminarSolicitud.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnEliminarSolicitud.Location = new System.Drawing.Point(20, 450);
            this.btnEliminarSolicitud.Name = "btnEliminarSolicitud";
            this.btnEliminarSolicitud.Size = new System.Drawing.Size(173, 69);
            this.btnEliminarSolicitud.TabIndex = 15;
            this.btnEliminarSolicitud.Text = "Eliminar Solicitud";
            this.btnEliminarSolicitud.UseVisualStyleBackColor = false;
            // 
            // btnSolicitud
            // 
            this.btnSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnSolicitud.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnSolicitud.Location = new System.Drawing.Point(199, 450);
            this.btnSolicitud.Name = "btnSolicitud";
            this.btnSolicitud.Size = new System.Drawing.Size(173, 69);
            this.btnSolicitud.TabIndex = 15;
            this.btnSolicitud.Text = "Realizar Solicitud";
            this.btnSolicitud.UseVisualStyleBackColor = false;
            // 
            // lblSolicitud
            // 
            this.lblSolicitud.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitud.ForeColor = System.Drawing.Color.White;
            this.lblSolicitud.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSolicitud.Location = new System.Drawing.Point(528, 4);
            this.lblSolicitud.Name = "lblSolicitud";
            this.lblSolicitud.Size = new System.Drawing.Size(269, 34);
            this.lblSolicitud.TabIndex = 10;
            this.lblSolicitud.Text = "Lista de productos Solicitados";
            this.lblSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dgvProductos.Enabled = false;
            this.dgvProductos.Location = new System.Drawing.Point(419, 41);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(569, 638);
            this.dgvProductos.TabIndex = 5;
            // 
            // gpbAgregar
            // 
            this.gpbAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbAgregar.Controls.Add(this.cmbProveedores);
            this.gpbAgregar.Controls.Add(this.btnAgregar);
            this.gpbAgregar.Controls.Add(this.lblCantidad);
            this.gpbAgregar.Controls.Add(this.lblProveedores);
            this.gpbAgregar.Controls.Add(this.lbldescripcion);
            this.gpbAgregar.Controls.Add(this.lblnombre);
            this.gpbAgregar.Controls.Add(this.txtStock);
            this.gpbAgregar.Controls.Add(this.txtDescripcion);
            this.gpbAgregar.Controls.Add(this.txtnombre);
            this.gpbAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpbAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.gpbAgregar.Location = new System.Drawing.Point(21, 41);
            this.gpbAgregar.Name = "gpbAgregar";
            this.gpbAgregar.Size = new System.Drawing.Size(375, 371);
            this.gpbAgregar.TabIndex = 4;
            this.gpbAgregar.TabStop = false;
            this.gpbAgregar.Text = "Carga de Datos";
            this.gpbAgregar.Enter += new System.EventHandler(this.gpbAgregar_Enter);
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(146, 173);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedores.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(84, 291);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(211, 54);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCantidad.Location = new System.Drawing.Point(20, 220);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(106, 34);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProveedores
            // 
            this.lblProveedores.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblProveedores.ForeColor = System.Drawing.Color.White;
            this.lblProveedores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblProveedores.Location = new System.Drawing.Point(20, 163);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(106, 34);
            this.lblProveedores.TabIndex = 9;
            this.lblProveedores.Text = "Proveedor:";
            this.lblProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbldescripcion.ForeColor = System.Drawing.Color.White;
            this.lbldescripcion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbldescripcion.Location = new System.Drawing.Point(20, 97);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(106, 34);
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
            this.lblnombre.Size = new System.Drawing.Size(106, 34);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(146, 230);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(121, 20);
            this.txtStock.TabIndex = 3;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(146, 107);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(190, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(146, 54);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // frmInventarioSolicitudStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 691);
            this.Controls.Add(this.panelInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioSolicitudStock";
            this.Text = "frmInventarioSolicitudStock";
            this.panelInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gpbAgregar.ResumeLayout(false);
            this.gpbAgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gpbAgregar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnSolicitud;
        private System.Windows.Forms.Label lblSolicitud;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnEliminarSolicitud;
        private System.Windows.Forms.ComboBox cmbProveedores;
    }
}