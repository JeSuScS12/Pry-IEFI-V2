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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.mrcBusqueda = new System.Windows.Forms.GroupBox();
            this.optCodigo = new System.Windows.Forms.RadioButton();
            this.optCategoria = new System.Windows.Forms.RadioButton();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.optNombre = new System.Windows.Forms.RadioButton();
            this.mrcCodigo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.mrcBuscarCategoria = new System.Windows.Forms.GroupBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.mrcBuscarxNombre = new System.Windows.Forms.GroupBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gpbBusqueda.SuspendLayout();
            this.mrcBusqueda.SuspendLayout();
            this.mrcCodigo.SuspendLayout();
            this.mrcBuscarCategoria.SuspendLayout();
            this.mrcBuscarxNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInventario
            // 
            this.panelInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.panelInventario.Controls.Add(this.dgvProductos);
            this.panelInventario.Controls.Add(this.gpbBusqueda);
            this.panelInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInventario.Location = new System.Drawing.Point(0, 0);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(1000, 668);
            this.panelInventario.TabIndex = 7;
            this.panelInventario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInventario_Paint);
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
            this.dgvProductos.Cursor = System.Windows.Forms.Cursors.No;
            this.dgvProductos.Location = new System.Drawing.Point(440, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(548, 631);
            this.dgvProductos.TabIndex = 37;
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
            // gpbBusqueda
            // 
            this.gpbBusqueda.Controls.Add(this.mrcBusqueda);
            this.gpbBusqueda.Controls.Add(this.mrcCodigo);
            this.gpbBusqueda.Controls.Add(this.mrcBuscarCategoria);
            this.gpbBusqueda.Controls.Add(this.mrcBuscarxNombre);
            this.gpbBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.gpbBusqueda.Location = new System.Drawing.Point(9, 12);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(415, 468);
            this.gpbBusqueda.TabIndex = 27;
            this.gpbBusqueda.TabStop = false;
            this.gpbBusqueda.Enter += new System.EventHandler(this.gpbBusqueda_Enter);
            // 
            // mrcBusqueda
            // 
            this.mrcBusqueda.Controls.Add(this.optCodigo);
            this.mrcBusqueda.Controls.Add(this.optCategoria);
            this.mrcBusqueda.Controls.Add(this.lbltitulo);
            this.mrcBusqueda.Controls.Add(this.optNombre);
            this.mrcBusqueda.Location = new System.Drawing.Point(11, 19);
            this.mrcBusqueda.Name = "mrcBusqueda";
            this.mrcBusqueda.Size = new System.Drawing.Size(393, 114);
            this.mrcBusqueda.TabIndex = 36;
            this.mrcBusqueda.TabStop = false;
            this.mrcBusqueda.Text = "Seleccione el tipo de búsqueda";
            // 
            // optCodigo
            // 
            this.optCodigo.AutoSize = true;
            this.optCodigo.Location = new System.Drawing.Point(213, 80);
            this.optCodigo.Name = "optCodigo";
            this.optCodigo.Size = new System.Drawing.Size(126, 17);
            this.optCodigo.TabIndex = 32;
            this.optCodigo.TabStop = true;
            this.optCodigo.Text = "Búsqueda por código";
            this.optCodigo.UseVisualStyleBackColor = true;
            this.optCodigo.CheckedChanged += new System.EventHandler(this.optCodigo_CheckedChanged);
            // 
            // optCategoria
            // 
            this.optCategoria.AutoSize = true;
            this.optCategoria.Location = new System.Drawing.Point(213, 50);
            this.optCategoria.Name = "optCategoria";
            this.optCategoria.Size = new System.Drawing.Size(138, 17);
            this.optCategoria.TabIndex = 31;
            this.optCategoria.TabStop = true;
            this.optCategoria.Text = "Búsqueda por categoria";
            this.optCategoria.UseVisualStyleBackColor = true;
            this.optCategoria.CheckedChanged += new System.EventHandler(this.optCategoria_CheckedChanged);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbltitulo.Location = new System.Drawing.Point(1, 16);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(206, 51);
            this.lbltitulo.TabIndex = 15;
            this.lbltitulo.Text = "Filtro de Productos por :";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltitulo.Click += new System.EventHandler(this.lbltitulo_Click);
            // 
            // optNombre
            // 
            this.optNombre.AutoSize = true;
            this.optNombre.Location = new System.Drawing.Point(213, 19);
            this.optNombre.Name = "optNombre";
            this.optNombre.Size = new System.Drawing.Size(129, 17);
            this.optNombre.TabIndex = 30;
            this.optNombre.TabStop = true;
            this.optNombre.Text = "Búsqueda por nombre";
            this.optNombre.UseVisualStyleBackColor = true;
            this.optNombre.CheckedChanged += new System.EventHandler(this.optNombre_CheckedChanged);
            // 
            // mrcCodigo
            // 
            this.mrcCodigo.Controls.Add(this.label1);
            this.mrcCodigo.Controls.Add(this.txtCodigo);
            this.mrcCodigo.Controls.Add(this.btnBuscarCodigo);
            this.mrcCodigo.Location = new System.Drawing.Point(11, 342);
            this.mrcCodigo.Name = "mrcCodigo";
            this.mrcCodigo.Size = new System.Drawing.Size(393, 105);
            this.mrcCodigo.TabIndex = 35;
            this.mrcCodigo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "Busqueda por Codigo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(249, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 22;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged_1);
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnBuscarCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodigo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarCodigo.Location = new System.Drawing.Point(289, 55);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(81, 35);
            this.btnBuscarCodigo.TabIndex = 30;
            this.btnBuscarCodigo.Text = "Buscar";
            this.btnBuscarCodigo.UseVisualStyleBackColor = false;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mrcBuscarCategoria
            // 
            this.mrcBuscarCategoria.Controls.Add(this.lblcategoria);
            this.mrcBuscarCategoria.Controls.Add(this.cmbCategoria);
            this.mrcBuscarCategoria.Controls.Add(this.btnBuscarCategoria);
            this.mrcBuscarCategoria.Location = new System.Drawing.Point(11, 242);
            this.mrcBuscarCategoria.Name = "mrcBuscarCategoria";
            this.mrcBuscarCategoria.Size = new System.Drawing.Size(393, 94);
            this.mrcBuscarCategoria.TabIndex = 34;
            this.mrcBuscarCategoria.TabStop = false;
            // 
            // lblcategoria
            // 
            this.lblcategoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblcategoria.ForeColor = System.Drawing.Color.White;
            this.lblcategoria.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblcategoria.Location = new System.Drawing.Point(6, 13);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(216, 34);
            this.lblcategoria.TabIndex = 18;
            this.lblcategoria.Text = "Busqueda por Categoria:";
            this.lblcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(244, 23);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 26;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged_1);
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnBuscarCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCategoria.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(284, 50);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(81, 35);
            this.btnBuscarCategoria.TabIndex = 31;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = false;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // mrcBuscarxNombre
            // 
            this.mrcBuscarxNombre.Controls.Add(this.lblnombre);
            this.mrcBuscarxNombre.Controls.Add(this.btnBuscarNombre);
            this.mrcBuscarxNombre.Controls.Add(this.txtNombre);
            this.mrcBuscarxNombre.Location = new System.Drawing.Point(11, 139);
            this.mrcBuscarxNombre.Name = "mrcBuscarxNombre";
            this.mrcBuscarxNombre.Size = new System.Drawing.Size(393, 94);
            this.mrcBuscarxNombre.TabIndex = 33;
            this.mrcBuscarxNombre.TabStop = false;
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblnombre.Location = new System.Drawing.Point(6, 16);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(189, 34);
            this.lblnombre.TabIndex = 19;
            this.lblnombre.Text = "Busqueda por Nombre:";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnBuscarNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarNombre.Location = new System.Drawing.Point(284, 53);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(81, 35);
            this.btnBuscarNombre.TabIndex = 32;
            this.btnBuscarNombre.Text = "Buscar";
            this.btnBuscarNombre.UseVisualStyleBackColor = false;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(244, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_2);
            // 
            // frmInventarioBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 668);
            this.Controls.Add(this.panelInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventarioBusqueda";
            this.Text = "frmInventarioBusqueda";
            this.Load += new System.EventHandler(this.frmInventarioBusqueda_Load);
            this.panelInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gpbBusqueda.ResumeLayout(false);
            this.mrcBusqueda.ResumeLayout(false);
            this.mrcBusqueda.PerformLayout();
            this.mrcCodigo.ResumeLayout(false);
            this.mrcCodigo.PerformLayout();
            this.mrcBuscarCategoria.ResumeLayout(false);
            this.mrcBuscarxNombre.ResumeLayout(false);
            this.mrcBuscarxNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.GroupBox mrcBuscarxNombre;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.GroupBox mrcCodigo;
        private System.Windows.Forms.GroupBox mrcBuscarCategoria;
        private System.Windows.Forms.RadioButton optNombre;
        private System.Windows.Forms.GroupBox mrcBusqueda;
        private System.Windows.Forms.RadioButton optCodigo;
        private System.Windows.Forms.RadioButton optCategoria;
        private System.Windows.Forms.DataGridView dgvProductos;
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