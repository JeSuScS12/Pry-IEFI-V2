namespace Gestion.Forms_Modulo_Ventas
{
    partial class frmVentasPagar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasPagar));
            this.panelUp = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPagar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grbClientes = new System.Windows.Forms.GroupBox();
            this.lblSegundoAviso = new System.Windows.Forms.Label();
            this.grbFactura = new System.Windows.Forms.GroupBox();
            this.optEnviarCorreo = new System.Windows.Forms.RadioButton();
            this.optImprimir = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrimerAviso = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.lblPregCliente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.grbClientes.SuspendLayout();
            this.grbFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.panelUp.Controls.Add(this.btnCerrar);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Margin = new System.Windows.Forms.Padding(4);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(700, 47);
            this.panelUp.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btnCerrar.Location = new System.Drawing.Point(636, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(64, 47);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCarrito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCarrito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCarrito.Location = new System.Drawing.Point(28, 57);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.RowHeadersWidth = 55;
            this.dgvCarrito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(630, 190);
            this.dgvCarrito.TabIndex = 22;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "Cod.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 59;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 291;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.FillWeight = 17.48252F;
            this.Column2.HeaderText = "Cant.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 63;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 17.48252F;
            this.Column4.HeaderText = "Precio Uni.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 88;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.FillWeight = 17.48252F;
            this.Column5.HeaderText = "Importe";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 74;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 17.48252F;
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(163)))), ((int)(((byte)(147)))));
            this.btnPagar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.ImageKey = "Billetes.png";
            this.btnPagar.ImageList = this.imageList1;
            this.btnPagar.Location = new System.Drawing.Point(484, 375);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(181, 63);
            this.btnPagar.TabIndex = 24;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Billetes.png");
            // 
            // grbClientes
            // 
            this.grbClientes.Controls.Add(this.lblSegundoAviso);
            this.grbClientes.Controls.Add(this.grbFactura);
            this.grbClientes.Controls.Add(this.lblPrimerAviso);
            this.grbClientes.Controls.Add(this.lblDir);
            this.grbClientes.Controls.Add(this.textBox3);
            this.grbClientes.Controls.Add(this.lblNom);
            this.grbClientes.Controls.Add(this.textBox2);
            this.grbClientes.Controls.Add(this.lblDNI);
            this.grbClientes.Controls.Add(this.textBox1);
            this.grbClientes.Controls.Add(this.optNo);
            this.grbClientes.Controls.Add(this.optSi);
            this.grbClientes.Controls.Add(this.lblPregCliente);
            this.grbClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbClientes.Location = new System.Drawing.Point(28, 264);
            this.grbClientes.Name = "grbClientes";
            this.grbClientes.Size = new System.Drawing.Size(443, 222);
            this.grbClientes.TabIndex = 25;
            this.grbClientes.TabStop = false;
            this.grbClientes.Text = "CLIENTES";
            // 
            // lblSegundoAviso
            // 
            this.lblSegundoAviso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoAviso.ForeColor = System.Drawing.Color.Gray;
            this.lblSegundoAviso.Location = new System.Drawing.Point(251, 170);
            this.lblSegundoAviso.Name = "lblSegundoAviso";
            this.lblSegundoAviso.Size = new System.Drawing.Size(172, 45);
            this.lblSegundoAviso.TabIndex = 39;
            this.lblSegundoAviso.Text = "* Enviar al correo solo disponible para usuarios\r\n";
            this.lblSegundoAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbFactura
            // 
            this.grbFactura.Controls.Add(this.optEnviarCorreo);
            this.grbFactura.Controls.Add(this.optImprimir);
            this.grbFactura.Controls.Add(this.label6);
            this.grbFactura.Location = new System.Drawing.Point(254, 81);
            this.grbFactura.Name = "grbFactura";
            this.grbFactura.Size = new System.Drawing.Size(169, 85);
            this.grbFactura.TabIndex = 38;
            this.grbFactura.TabStop = false;
            this.grbFactura.Text = "Factura";
            // 
            // optEnviarCorreo
            // 
            this.optEnviarCorreo.AutoSize = true;
            this.optEnviarCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optEnviarCorreo.Location = new System.Drawing.Point(19, 53);
            this.optEnviarCorreo.Name = "optEnviarCorreo";
            this.optEnviarCorreo.Size = new System.Drawing.Size(127, 21);
            this.optEnviarCorreo.TabIndex = 33;
            this.optEnviarCorreo.TabStop = true;
            this.optEnviarCorreo.Text = "Enviar al correo";
            this.optEnviarCorreo.UseVisualStyleBackColor = true;
            // 
            // optImprimir
            // 
            this.optImprimir.AutoSize = true;
            this.optImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optImprimir.Location = new System.Drawing.Point(19, 26);
            this.optImprimir.Name = "optImprimir";
            this.optImprimir.Size = new System.Drawing.Size(78, 21);
            this.optImprimir.TabIndex = 32;
            this.optImprimir.TabStop = true;
            this.optImprimir.Text = "Imprimir";
            this.optImprimir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 31;
            // 
            // lblPrimerAviso
            // 
            this.lblPrimerAviso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerAviso.ForeColor = System.Drawing.Color.Gray;
            this.lblPrimerAviso.Location = new System.Drawing.Point(226, 19);
            this.lblPrimerAviso.Name = "lblPrimerAviso";
            this.lblPrimerAviso.Size = new System.Drawing.Size(138, 53);
            this.lblPrimerAviso.TabIndex = 37;
            this.lblPrimerAviso.Text = "Si tiene usuario los campos se agregaran al colocar el DNI";
            this.lblPrimerAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.Location = new System.Drawing.Point(25, 160);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(69, 17);
            this.lblDir.TabIndex = 36;
            this.lblDir.Text = "Direccion";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 23);
            this.textBox3.TabIndex = 35;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(25, 118);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(61, 17);
            this.lblNom.TabIndex = 34;
            this.lblNom.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 33;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(25, 76);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 17);
            this.lblDNI.TabIndex = 32;
            this.lblDNI.Text = "DNI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 31;
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNo.Location = new System.Drawing.Point(100, 41);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(45, 21);
            this.optNo.TabIndex = 30;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSi.Location = new System.Drawing.Point(41, 41);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(35, 21);
            this.optSi.TabIndex = 29;
            this.optSi.TabStop = true;
            this.optSi.Text = "SI";
            this.optSi.UseVisualStyleBackColor = true;
            // 
            // lblPregCliente
            // 
            this.lblPregCliente.AutoSize = true;
            this.lblPregCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregCliente.Location = new System.Drawing.Point(19, 21);
            this.lblPregCliente.Name = "lblPregCliente";
            this.lblPregCliente.Size = new System.Drawing.Size(175, 17);
            this.lblPregCliente.TabIndex = 28;
            this.lblPregCliente.Text = "¿Tiene USUARIO el cliente?";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(499, 281);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(151, 63);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = " $";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVentasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 498);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grbClientes);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.panelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentasPagar";
            this.Load += new System.EventHandler(this.frmVentasPagar_Load);
            this.panelUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.grbClientes.ResumeLayout(false);
            this.grbClientes.PerformLayout();
            this.grbFactura.ResumeLayout(false);
            this.grbFactura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grbClientes;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.Label lblPregCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grbFactura;
        private System.Windows.Forms.Label lblPrimerAviso;
        private System.Windows.Forms.RadioButton optEnviarCorreo;
        private System.Windows.Forms.RadioButton optImprimir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSegundoAviso;
    }
}