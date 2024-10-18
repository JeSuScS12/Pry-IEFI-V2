namespace Gestion.Foms_Modulo_Inventario
{
    partial class frmInventarioBusqueda
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
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.cmbStock = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            this.panelInventario.SuspendLayout();
            this.gpbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInventario
            // 
            this.panelInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.panelInventario.Controls.Add(this.btnReporte);
            this.panelInventario.Controls.Add(this.gpbBusqueda);
            this.panelInventario.Controls.Add(this.dgvProductos);
            this.panelInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInventario.Location = new System.Drawing.Point(0, 0);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(1000, 691);
            this.panelInventario.TabIndex = 3;
            // 
            // gpbBusqueda
            // 
            this.gpbBusqueda.Controls.Add(this.cmbStock);
            this.gpbBusqueda.Controls.Add(this.cmbCategoria);
            this.gpbBusqueda.Controls.Add(this.lblcategoria);
            this.gpbBusqueda.Controls.Add(this.lbltitulo);
            this.gpbBusqueda.Controls.Add(this.label2);
            this.gpbBusqueda.Controls.Add(this.txtNombre);
            this.gpbBusqueda.Controls.Add(this.txtCodigo);
            this.gpbBusqueda.Controls.Add(this.lblnombre);
            this.gpbBusqueda.Controls.Add(this.label1);
            this.gpbBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.gpbBusqueda.Location = new System.Drawing.Point(41, 12);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(325, 320);
            this.gpbBusqueda.TabIndex = 27;
            this.gpbBusqueda.TabStop = false;
            this.gpbBusqueda.Text = "Buscar Productos";
            // 
            // cmbStock
            // 
            this.cmbStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStock.FormattingEnabled = true;
            this.cmbStock.Location = new System.Drawing.Point(187, 266);
            this.cmbStock.Name = "cmbStock";
            this.cmbStock.Size = new System.Drawing.Size(121, 21);
            this.cmbStock.TabIndex = 27;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(187, 157);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 26;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // lblcategoria
            // 
            this.lblcategoria.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.ForeColor = System.Drawing.Color.White;
            this.lblcategoria.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblcategoria.Location = new System.Drawing.Point(7, 148);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(180, 34);
            this.lblcategoria.TabIndex = 18;
            this.lblcategoria.Text = "Busqueda por Categoria:";
            this.lblcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltitulo
            // 
            this.lbltitulo.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbltitulo.Location = new System.Drawing.Point(6, 31);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(307, 51);
            this.lbltitulo.TabIndex = 15;
            this.lbltitulo.Text = "Filtro de Productos por :";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(7, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Busqueda por Stock:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(187, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(187, 208);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 22;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblnombre.Location = new System.Drawing.Point(7, 97);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(158, 34);
            this.lblnombre.TabIndex = 19;
            this.lblnombre.Text = "Busqueda por Nombre:";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(7, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Busqueda por Codigo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dgvProductos.Location = new System.Drawing.Point(419, 3);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(581, 691);
            this.dgvProductos.TabIndex = 5;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReporte.Location = new System.Drawing.Point(41, 399);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(232, 64);
            this.btnReporte.TabIndex = 28;
            this.btnReporte.Text = "Reporte de Stock";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // frmInventarioBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 691);
            this.Controls.Add(this.panelInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioBusqueda";
            this.Text = "frmInventarioBusqueda";
            this.panelInventario.ResumeLayout(false);
            this.gpbBusqueda.ResumeLayout(false);
            this.gpbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.ComboBox cmbStock;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnReporte;
    }
}