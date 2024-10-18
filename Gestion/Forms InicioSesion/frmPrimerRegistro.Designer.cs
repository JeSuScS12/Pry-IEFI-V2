namespace Gestion.Forms_Otros
{
    partial class frmPrimerRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimerRegistro));
            this.panelUp = new System.Windows.Forms.Panel();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grbDatosNegocio = new System.Windows.Forms.GroupBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.lblPregImpuestos = new System.Windows.Forms.Label();
            this.grbIva = new System.Windows.Forms.GroupBox();
            this.lblVA = new System.Windows.Forms.Label();
            this.txtNegocio = new System.Windows.Forms.TextBox();
            this.grbDatosAdmin = new System.Windows.Forms.GroupBox();
            this.txtContraseñaR = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.grbLogo = new System.Windows.Forms.GroupBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblAtencion = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelUp.SuspendLayout();
            this.grbDatosNegocio.SuspendLayout();
            this.grbIva.SuspendLayout();
            this.grbDatosAdmin.SuspendLayout();
            this.grbLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.panelUp.Controls.Add(this.lblDatos);
            this.panelUp.Controls.Add(this.btnCerrar);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(910, 38);
            this.panelUp.TabIndex = 0;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.White;
            this.lblDatos.Location = new System.Drawing.Point(13, 9);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(146, 21);
            this.lblDatos.TabIndex = 6;
            this.lblDatos.Text = "DATOS INICIALES\r\n";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btnCerrar.Location = new System.Drawing.Point(855, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(55, 38);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // grbDatosNegocio
            // 
            this.grbDatosNegocio.Controls.Add(this.cmbLocalidad);
            this.grbDatosNegocio.Controls.Add(this.cmbProvincia);
            this.grbDatosNegocio.Controls.Add(this.txtRubro);
            this.grbDatosNegocio.Controls.Add(this.txtDireccion);
            this.grbDatosNegocio.Controls.Add(this.optNo);
            this.grbDatosNegocio.Controls.Add(this.optSi);
            this.grbDatosNegocio.Controls.Add(this.lblPregImpuestos);
            this.grbDatosNegocio.Controls.Add(this.grbIva);
            this.grbDatosNegocio.Controls.Add(this.txtNegocio);
            this.grbDatosNegocio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosNegocio.ForeColor = System.Drawing.Color.White;
            this.grbDatosNegocio.Location = new System.Drawing.Point(12, 75);
            this.grbDatosNegocio.Name = "grbDatosNegocio";
            this.grbDatosNegocio.Size = new System.Drawing.Size(640, 204);
            this.grbDatosNegocio.TabIndex = 1;
            this.grbDatosNegocio.TabStop = false;
            this.grbDatosNegocio.Text = "Datos Negocio";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocalidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.IntegralHeight = false;
            this.cmbLocalidad.ItemHeight = 17;
            this.cmbLocalidad.Location = new System.Drawing.Point(210, 160);
            this.cmbLocalidad.MaxDropDownItems = 10;
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(159, 25);
            this.cmbLocalidad.TabIndex = 11;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProvincia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.IntegralHeight = false;
            this.cmbProvincia.ItemHeight = 17;
            this.cmbProvincia.Location = new System.Drawing.Point(26, 160);
            this.cmbProvincia.MaxDropDownItems = 10;
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(178, 25);
            this.cmbProvincia.TabIndex = 10;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // txtRubro
            // 
            this.txtRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRubro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRubro.Location = new System.Drawing.Point(26, 74);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(343, 23);
            this.txtRubro.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(27, 116);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(342, 23);
            this.txtDireccion.TabIndex = 8;
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNo.Location = new System.Drawing.Point(461, 43);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(48, 24);
            this.optNo.TabIndex = 7;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSi.Location = new System.Drawing.Point(402, 43);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(39, 24);
            this.optSi.TabIndex = 6;
            this.optSi.TabStop = true;
            this.optSi.Text = "SI";
            this.optSi.UseVisualStyleBackColor = true;
            // 
            // lblPregImpuestos
            // 
            this.lblPregImpuestos.AutoSize = true;
            this.lblPregImpuestos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregImpuestos.Location = new System.Drawing.Point(383, 23);
            this.lblPregImpuestos.Name = "lblPregImpuestos";
            this.lblPregImpuestos.Size = new System.Drawing.Size(170, 17);
            this.lblPregImpuestos.TabIndex = 5;
            this.lblPregImpuestos.Text = "¿Trabaja con Impuestos?";
            // 
            // grbIva
            // 
            this.grbIva.Controls.Add(this.lblVA);
            this.grbIva.ForeColor = System.Drawing.Color.White;
            this.grbIva.Location = new System.Drawing.Point(386, 65);
            this.grbIva.Name = "grbIva";
            this.grbIva.Size = new System.Drawing.Size(239, 124);
            this.grbIva.TabIndex = 4;
            this.grbIva.TabStop = false;
            this.grbIva.Text = "IVA";
            // 
            // lblVA
            // 
            this.lblVA.AutoSize = true;
            this.lblVA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVA.Location = new System.Drawing.Point(48, 52);
            this.lblVA.Name = "lblVA";
            this.lblVA.Size = new System.Drawing.Size(141, 22);
            this.lblVA.TabIndex = 9;
            this.lblVA.Text = "Proximamente";
            // 
            // txtNegocio
            // 
            this.txtNegocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNegocio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNegocio.Location = new System.Drawing.Point(26, 34);
            this.txtNegocio.Name = "txtNegocio";
            this.txtNegocio.Size = new System.Drawing.Size(343, 23);
            this.txtNegocio.TabIndex = 3;
            // 
            // grbDatosAdmin
            // 
            this.grbDatosAdmin.Controls.Add(this.txtContraseñaR);
            this.grbDatosAdmin.Controls.Add(this.txtTelefono);
            this.grbDatosAdmin.Controls.Add(this.txtContraseña);
            this.grbDatosAdmin.Controls.Add(this.txtUsuario);
            this.grbDatosAdmin.Controls.Add(this.txtCorreo);
            this.grbDatosAdmin.Controls.Add(this.txtApellidos);
            this.grbDatosAdmin.Controls.Add(this.txtNombres);
            this.grbDatosAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosAdmin.ForeColor = System.Drawing.Color.White;
            this.grbDatosAdmin.Location = new System.Drawing.Point(12, 299);
            this.grbDatosAdmin.Name = "grbDatosAdmin";
            this.grbDatosAdmin.Size = new System.Drawing.Size(886, 188);
            this.grbDatosAdmin.TabIndex = 2;
            this.grbDatosAdmin.TabStop = false;
            this.grbDatosAdmin.Text = "Datos del Administrador";
            // 
            // txtContraseñaR
            // 
            this.txtContraseñaR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseñaR.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaR.Location = new System.Drawing.Point(589, 134);
            this.txtContraseñaR.Name = "txtContraseñaR";
            this.txtContraseñaR.Size = new System.Drawing.Size(200, 26);
            this.txtContraseñaR.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(38, 134);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(243, 26);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(589, 92);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(200, 26);
            this.txtContraseña.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(589, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 26);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(38, 92);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(408, 26);
            this.txtCorreo.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(258, 50);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(188, 26);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(38, 50);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(200, 26);
            this.txtNombres.TabIndex = 0;
            // 
            // grbLogo
            // 
            this.grbLogo.Controls.Add(this.lblLogo);
            this.grbLogo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLogo.ForeColor = System.Drawing.Color.White;
            this.grbLogo.Location = new System.Drawing.Point(672, 78);
            this.grbLogo.Name = "grbLogo";
            this.grbLogo.Size = new System.Drawing.Size(226, 201);
            this.grbLogo.TabIndex = 3;
            this.grbLogo.TabStop = false;
            this.grbLogo.Text = "Logo de Negocio";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(45, 91);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(141, 22);
            this.lblLogo.TabIndex = 8;
            this.lblLogo.Text = "Proximamente";
            // 
            // lblAtencion
            // 
            this.lblAtencion.AutoSize = true;
            this.lblAtencion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtencion.ForeColor = System.Drawing.Color.Silver;
            this.lblAtencion.Location = new System.Drawing.Point(13, 45);
            this.lblAtencion.Name = "lblAtencion";
            this.lblAtencion.Size = new System.Drawing.Size(280, 21);
            this.lblAtencion.TabIndex = 4;
            this.lblAtencion.Text = "Los campos con [*] son obligatorios";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(163)))), ((int)(((byte)(147)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.ImageKey = "Guardar.png";
            this.btnConfirmar.ImageList = this.imageList1;
            this.btnConfirmar.Location = new System.Drawing.Point(15, 510);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfirmar.Size = new System.Drawing.Size(880, 45);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Guardar e Iniciar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Guardar.png");
            // 
            // frmPrimerRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(910, 565);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblAtencion);
            this.Controls.Add(this.grbLogo);
            this.Controls.Add(this.grbDatosAdmin);
            this.Controls.Add(this.grbDatosNegocio);
            this.Controls.Add(this.panelUp);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrimerRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrimerRegistro";
            this.Load += new System.EventHandler(this.frmPrimerRegistro_Load);
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.grbDatosNegocio.ResumeLayout(false);
            this.grbDatosNegocio.PerformLayout();
            this.grbIva.ResumeLayout(false);
            this.grbIva.PerformLayout();
            this.grbDatosAdmin.ResumeLayout(false);
            this.grbDatosAdmin.PerformLayout();
            this.grbLogo.ResumeLayout(false);
            this.grbLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox grbDatosNegocio;
        private System.Windows.Forms.GroupBox grbDatosAdmin;
        private System.Windows.Forms.GroupBox grbLogo;
        private System.Windows.Forms.Label lblAtencion;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtContraseñaR;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox grbIva;
        private System.Windows.Forms.TextBox txtNegocio;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.Label lblPregImpuestos;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblVA;
    }
}