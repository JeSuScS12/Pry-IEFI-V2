namespace Gestion.Foms_Modulo_Inventario
{
    partial class frmInventraioCategorias
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
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelidcategoria = new System.Windows.Forms.Label();
            this.txtModificarDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionModificar = new System.Windows.Forms.Label();
            this.lblCategoriaModificar = new System.Windows.Forms.Label();
            this.txtModificar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.txtCategoriaAgregar = new System.Windows.Forms.TextBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGeneral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.panelGeneral.Controls.Add(this.groupBox2);
            this.panelGeneral.Controls.Add(this.groupBox1);
            this.panelGeneral.Controls.Add(this.dgvCategorias);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1000, 691);
            this.panelGeneral.TabIndex = 7;
            this.panelGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGeneral_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.labelidcategoria);
            this.groupBox2.Controls.Add(this.txtModificarDescripcion);
            this.groupBox2.Controls.Add(this.lblDescripcionModificar);
            this.groupBox2.Controls.Add(this.lblCategoriaModificar);
            this.groupBox2.Controls.Add(this.txtModificar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 240);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar o Eliminar Categoria";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(258, 64);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 23;
            // 
            // labelidcategoria
            // 
            this.labelidcategoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelidcategoria.ForeColor = System.Drawing.Color.White;
            this.labelidcategoria.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelidcategoria.Location = new System.Drawing.Point(6, 54);
            this.labelidcategoria.Name = "labelidcategoria";
            this.labelidcategoria.Size = new System.Drawing.Size(102, 34);
            this.labelidcategoria.TabIndex = 22;
            this.labelidcategoria.Text = "Categoria:";
            this.labelidcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModificarDescripcion
            // 
            this.txtModificarDescripcion.Location = new System.Drawing.Point(258, 136);
            this.txtModificarDescripcion.Name = "txtModificarDescripcion";
            this.txtModificarDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtModificarDescripcion.TabIndex = 21;
            // 
            // lblDescripcionModificar
            // 
            this.lblDescripcionModificar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDescripcionModificar.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionModificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDescripcionModificar.Location = new System.Drawing.Point(6, 122);
            this.lblDescripcionModificar.Name = "lblDescripcionModificar";
            this.lblDescripcionModificar.Size = new System.Drawing.Size(102, 34);
            this.lblDescripcionModificar.TabIndex = 20;
            this.lblDescripcionModificar.Text = "Descripción";
            this.lblDescripcionModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategoriaModificar
            // 
            this.lblCategoriaModificar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblCategoriaModificar.ForeColor = System.Drawing.Color.White;
            this.lblCategoriaModificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCategoriaModificar.Location = new System.Drawing.Point(6, 88);
            this.lblCategoriaModificar.Name = "lblCategoriaModificar";
            this.lblCategoriaModificar.Size = new System.Drawing.Size(102, 34);
            this.lblCategoriaModificar.TabIndex = 19;
            this.lblCategoriaModificar.Text = "Categoria:";
            this.lblCategoriaModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModificar
            // 
            this.txtModificar.Location = new System.Drawing.Point(258, 98);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(121, 20);
            this.txtModificar.TabIndex = 18;
            this.txtModificar.TextChanged += new System.EventHandler(this.txtModificar_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(233, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(211, 54);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(6, 161);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(211, 54);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccionar una Categoria en la Tabla";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblcategoria);
            this.groupBox1.Controls.Add(this.txtCategoriaAgregar);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 230);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Categoria";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(267, 141);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 17;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 127);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(102, 34);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(99, 170);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(211, 54);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingresar Nombre de la Nueva Categoria";
            // 
            // lblcategoria
            // 
            this.lblcategoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblcategoria.ForeColor = System.Drawing.Color.White;
            this.lblcategoria.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblcategoria.Location = new System.Drawing.Point(15, 67);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(102, 34);
            this.lblcategoria.TabIndex = 8;
            this.lblcategoria.Text = "Categoria:";
            this.lblcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCategoriaAgregar
            // 
            this.txtCategoriaAgregar.Location = new System.Drawing.Point(267, 81);
            this.txtCategoriaAgregar.Name = "txtCategoriaAgregar";
            this.txtCategoriaAgregar.Size = new System.Drawing.Size(121, 20);
            this.txtCategoriaAgregar.TabIndex = 1;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCategorias.Location = new System.Drawing.Point(490, 12);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(498, 667);
            this.dgvCategorias.TabIndex = 5;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "idCategoria";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Categoria";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmInventraioCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 691);
            this.Controls.Add(this.panelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventraioCategorias";
            this.Text = "frmInventraioCategorias";
            this.Load += new System.EventHandler(this.frmInventraioCategorias_Load);
            this.panelGeneral.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.TextBox txtCategoriaAgregar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtModificarDescripcion;
        private System.Windows.Forms.Label lblDescripcionModificar;
        private System.Windows.Forms.Label lblCategoriaModificar;
        private System.Windows.Forms.TextBox txtModificar;
        private System.Windows.Forms.Label labelidcategoria;
        private System.Windows.Forms.TextBox txtID;
    }
}