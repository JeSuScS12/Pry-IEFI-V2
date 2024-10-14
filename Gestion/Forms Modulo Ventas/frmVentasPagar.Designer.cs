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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrito.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCarrito.Location = new System.Drawing.Point(28, 57);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrito.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.optNo);
            this.groupBox1.Controls.Add(this.optSi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 222);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTES";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(251, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 45);
            this.label7.TabIndex = 39;
            this.label7.Text = "* Enviar al correo solo disponible para usuarios\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(254, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 85);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factura";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(19, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 21);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Enviar al correo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(19, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 21);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Imprimir";
            this.radioButton2.UseVisualStyleBackColor = true;
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
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(226, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 53);
            this.label5.TabIndex = 37;
            this.label5.Text = "Si tiene usuario los campos se agregaran al colocar el DNI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Direccion";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 23);
            this.textBox3.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "DNI";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "¿Tiene USUARIO el cliente?";
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
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}