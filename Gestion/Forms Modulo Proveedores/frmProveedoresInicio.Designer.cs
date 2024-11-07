namespace Gestion.Forms_Modulo_Proveedores
{
    partial class frmProveedoresInicio
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
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panelProveedor = new System.Windows.Forms.Panel();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblCorr = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblDirec = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.tvProveedores = new System.Windows.Forms.TreeView();
            this.panelProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panelProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProveedores
            // 
            this.panelProveedores.AutoScroll = true;
            this.panelProveedores.Controls.Add(this.label2);
            this.panelProveedores.Controls.Add(this.label1);
            this.panelProveedores.Controls.Add(this.dgvProductos);
            this.panelProveedores.Controls.Add(this.label4);
            this.panelProveedores.Controls.Add(this.panelProveedor);
            this.panelProveedores.Controls.Add(this.tvProveedores);
            this.panelProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProveedores.Location = new System.Drawing.Point(0, 0);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(1000, 668);
            this.panelProveedores.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(73, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de Proveedores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(396, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Productos del Proveedor seleccionado";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(366, 341);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(599, 251);
            this.dgvProductos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(396, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datos del Proveedor";
            // 
            // panelProveedor
            // 
            this.panelProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProveedor.Controls.Add(this.chkActivo);
            this.panelProveedor.Controls.Add(this.lblCorr);
            this.panelProveedor.Controls.Add(this.lblTel);
            this.panelProveedor.Controls.Add(this.lblFechaInicio);
            this.panelProveedor.Controls.Add(this.lblCat);
            this.panelProveedor.Controls.Add(this.lblDirec);
            this.panelProveedor.Controls.Add(this.lblNom);
            this.panelProveedor.Controls.Add(this.lblFecha);
            this.panelProveedor.Controls.Add(this.pbLogo);
            this.panelProveedor.Controls.Add(this.lbltelefono);
            this.panelProveedor.Controls.Add(this.lblnombre);
            this.panelProveedor.Controls.Add(this.lblcorreo);
            this.panelProveedor.Controls.Add(this.lbldireccion);
            this.panelProveedor.Controls.Add(this.lblcategoria);
            this.panelProveedor.Location = new System.Drawing.Point(366, 44);
            this.panelProveedor.Name = "panelProveedor";
            this.panelProveedor.Size = new System.Drawing.Size(599, 252);
            this.panelProveedor.TabIndex = 6;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Enabled = false;
            this.chkActivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.ForeColor = System.Drawing.SystemColors.Control;
            this.chkActivo.Location = new System.Drawing.Point(450, 195);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(91, 26);
            this.chkActivo.TabIndex = 31;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblCorr
            // 
            this.lblCorr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.lblCorr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCorr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorr.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCorr.Location = new System.Drawing.Point(132, 170);
            this.lblCorr.Name = "lblCorr";
            this.lblCorr.Size = new System.Drawing.Size(251, 29);
            this.lblCorr.TabIndex = 30;
            this.lblCorr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTel
            // 
            this.lblTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTel.Location = new System.Drawing.Point(132, 131);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(251, 29);
            this.lblTel.TabIndex = 29;
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.lblFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaInicio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaInicio.Location = new System.Drawing.Point(175, 209);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(208, 29);
            this.lblFechaInicio.TabIndex = 28;
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCat
            // 
            this.lblCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.lblCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCat.Location = new System.Drawing.Point(132, 92);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(251, 29);
            this.lblCat.TabIndex = 27;
            this.lblCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirec
            // 
            this.lblDirec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.lblDirec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDirec.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirec.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDirec.Location = new System.Drawing.Point(132, 53);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(251, 29);
            this.lblDirec.TabIndex = 26;
            this.lblDirec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNom.Location = new System.Drawing.Point(132, 14);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(251, 29);
            this.lblNom.TabIndex = 25;
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblFecha.Location = new System.Drawing.Point(29, 204);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(154, 34);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Fecha de inicio:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.Image = global::Gestion.Properties.Resources.proveedor2;
            this.pbLogo.Location = new System.Drawing.Point(412, 14);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(166, 160);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lbltelefono
            // 
            this.lbltelefono.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbltelefono.ForeColor = System.Drawing.Color.White;
            this.lbltelefono.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbltelefono.Location = new System.Drawing.Point(29, 126);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(83, 34);
            this.lbltelefono.TabIndex = 21;
            this.lbltelefono.Text = "Teléfono:";
            this.lbltelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblnombre
            // 
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblnombre.Location = new System.Drawing.Point(29, 9);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(83, 34);
            this.lblnombre.TabIndex = 18;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcorreo
            // 
            this.lblcorreo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblcorreo.ForeColor = System.Drawing.Color.White;
            this.lblcorreo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblcorreo.Location = new System.Drawing.Point(29, 165);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(83, 34);
            this.lblcorreo.TabIndex = 22;
            this.lblcorreo.Text = "Correo:";
            this.lblcorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbldireccion
            // 
            this.lbldireccion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbldireccion.ForeColor = System.Drawing.Color.White;
            this.lbldireccion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbldireccion.Location = new System.Drawing.Point(29, 48);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(91, 34);
            this.lbldireccion.TabIndex = 19;
            this.lbldireccion.Text = "Dirección:";
            this.lbldireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcategoria
            // 
            this.lblcategoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblcategoria.ForeColor = System.Drawing.Color.White;
            this.lblcategoria.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblcategoria.Location = new System.Drawing.Point(29, 87);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(103, 34);
            this.lblcategoria.TabIndex = 20;
            this.lblcategoria.Text = "Categoria:";
            this.lblcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tvProveedores
            // 
            this.tvProveedores.BackColor = System.Drawing.SystemColors.Control;
            this.tvProveedores.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvProveedores.ItemHeight = 28;
            this.tvProveedores.Location = new System.Drawing.Point(39, 44);
            this.tvProveedores.Name = "tvProveedores";
            this.tvProveedores.Size = new System.Drawing.Size(285, 548);
            this.tvProveedores.TabIndex = 5;
            this.tvProveedores.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvProveedores_AfterSelect);
            // 
            // frmProveedoresInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1000, 668);
            this.Controls.Add(this.panelProveedores);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProveedoresInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedoresInicio";
            this.Load += new System.EventHandler(this.frmProveedoresInicio_Load);
            this.panelProveedores.ResumeLayout(false);
            this.panelProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panelProveedor.ResumeLayout(false);
            this.panelProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panelProveedor;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView tvProveedores;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblCorr;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}