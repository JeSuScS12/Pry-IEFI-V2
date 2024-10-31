namespace Gestion.Forms_Clientes_Usuarios_Empleados_
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.grbAccion = new System.Windows.Forms.GroupBox();
            this.optRegistrar = new System.Windows.Forms.RadioButton();
            this.optModificar = new System.Windows.Forms.RadioButton();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pcbAvatar = new System.Windows.Forms.PictureBox();
            this.grbCliente.SuspendLayout();
            this.grbAccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location = new System.Drawing.Point(346, 248);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(176, 53);
            this.lblInfo.TabIndex = 60;
            this.lblInfo.Text = "Seleccione una opcion \r\nPara modificar seleccione de la tabla";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.btnGuardar);
            this.grbCliente.Controls.Add(this.cmbEstado);
            this.grbCliente.Controls.Add(this.lblEstado);
            this.grbCliente.Controls.Add(this.cmbCargo);
            this.grbCliente.Controls.Add(this.lblCargo);
            this.grbCliente.Controls.Add(this.lblTel);
            this.grbCliente.Controls.Add(this.txtTelefono);
            this.grbCliente.Controls.Add(this.lblCorreo);
            this.grbCliente.Controls.Add(this.txtCorreo);
            this.grbCliente.Controls.Add(this.lblDir);
            this.grbCliente.Controls.Add(this.txtDireccion);
            this.grbCliente.Controls.Add(this.lblNom);
            this.grbCliente.Controls.Add(this.txtNombre);
            this.grbCliente.Controls.Add(this.lblDNI);
            this.grbCliente.Controls.Add(this.txtDNI);
            this.grbCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCliente.Location = new System.Drawing.Point(52, 313);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(530, 249);
            this.grbCliente.TabIndex = 59;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Datos Cliente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(33, 192);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(199, 39);
            this.btnGuardar.TabIndex = 63;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(285, 206);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 25);
            this.cmbEstado.TabIndex = 53;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(282, 186);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 52;
            this.lblEstado.Text = "Estado";
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(285, 139);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(200, 25);
            this.cmbCargo.TabIndex = 51;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(282, 119);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 17);
            this.lblCargo.TabIndex = 48;
            this.lblCargo.Text = "Cargo";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(282, 77);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(62, 17);
            this.lblTel.TabIndex = 46;
            this.lblTel.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(285, 93);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 23);
            this.txtTelefono.TabIndex = 45;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(282, 31);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(53, 17);
            this.lblCorreo.TabIndex = 44;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(285, 51);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 23);
            this.txtCorreo.TabIndex = 43;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.Location = new System.Drawing.Point(29, 121);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(69, 17);
            this.lblDir.TabIndex = 42;
            this.lblDir.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(32, 141);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 23);
            this.txtDireccion.TabIndex = 41;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(29, 79);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(61, 17);
            this.lblNom.TabIndex = 40;
            this.lblNom.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(33, 95);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 39;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(29, 33);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 17);
            this.lblDNI.TabIndex = 38;
            this.lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(32, 53);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(200, 23);
            this.txtDNI.TabIndex = 37;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(709, 261);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(54, 21);
            this.lblFoto.TabIndex = 50;
            this.lblFoto.Text = "FOTO";
            // 
            // grbAccion
            // 
            this.grbAccion.Controls.Add(this.optRegistrar);
            this.grbAccion.Controls.Add(this.optModificar);
            this.grbAccion.Location = new System.Drawing.Point(52, 244);
            this.grbAccion.Name = "grbAccion";
            this.grbAccion.Size = new System.Drawing.Size(275, 57);
            this.grbAccion.TabIndex = 58;
            this.grbAccion.TabStop = false;
            this.grbAccion.Text = "¿Que accion quiere Realizar?";
            // 
            // optRegistrar
            // 
            this.optRegistrar.AutoSize = true;
            this.optRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRegistrar.Location = new System.Drawing.Point(158, 23);
            this.optRegistrar.Name = "optRegistrar";
            this.optRegistrar.Size = new System.Drawing.Size(81, 21);
            this.optRegistrar.TabIndex = 1;
            this.optRegistrar.TabStop = true;
            this.optRegistrar.Text = "Registrar";
            this.optRegistrar.UseVisualStyleBackColor = true;
            // 
            // optModificar
            // 
            this.optModificar.AutoSize = true;
            this.optModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optModificar.Location = new System.Drawing.Point(32, 23);
            this.optModificar.Name = "optModificar";
            this.optModificar.Size = new System.Drawing.Size(86, 21);
            this.optModificar.TabIndex = 0;
            this.optModificar.TabStop = true;
            this.optModificar.Text = "Modificar";
            this.optModificar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.Location = new System.Drawing.Point(52, 30);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 55;
            this.dgvUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(800, 204);
            this.dgvUsuarios.TabIndex = 57;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(49, 11);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(101, 16);
            this.lblUsuarios.TabIndex = 56;
            this.lblUsuarios.Text = "Lista de Usuarios";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(675, 505);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(123, 39);
            this.btnCargar.TabIndex = 62;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pcbAvatar
            // 
            this.pcbAvatar.Location = new System.Drawing.Point(644, 289);
            this.pcbAvatar.Name = "pcbAvatar";
            this.pcbAvatar.Size = new System.Drawing.Size(187, 200);
            this.pcbAvatar.TabIndex = 61;
            this.pcbAvatar.TabStop = false;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 572);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pcbAvatar);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.grbAccion);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblUsuarios);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.grbAccion.ResumeLayout(false);
            this.grbAccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox grbAccion;
        private System.Windows.Forms.RadioButton optRegistrar;
        private System.Windows.Forms.RadioButton optModificar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.PictureBox pcbAvatar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnGuardar;
    }
}