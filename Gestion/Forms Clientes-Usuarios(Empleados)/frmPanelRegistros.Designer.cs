namespace Gestion.Forms_Clientes_Usuarios_Empleados_
{
    partial class frmPanelRegistros
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnMostrarUsuarios = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(50, 112);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(900, 572);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnMostrarTodos);
            this.panelBotones.Controls.Add(this.btnMostrarUsuarios);
            this.panelBotones.Controls.Add(this.btnCliente);
            this.panelBotones.Location = new System.Drawing.Point(50, 56);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(900, 50);
            this.panelBotones.TabIndex = 1;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMostrarTodos.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(253)))));
            this.btnMostrarTodos.Location = new System.Drawing.Point(300, 0);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(300, 50);
            this.btnMostrarTodos.TabIndex = 9;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // btnMostrarUsuarios
            // 
            this.btnMostrarUsuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMostrarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnMostrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(253)))));
            this.btnMostrarUsuarios.Location = new System.Drawing.Point(600, 0);
            this.btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            this.btnMostrarUsuarios.Size = new System.Drawing.Size(300, 50);
            this.btnMostrarUsuarios.TabIndex = 8;
            this.btnMostrarUsuarios.Text = "Usuarios";
            this.btnMostrarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(253)))));
            this.btnCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(300, 50);
            this.btnCliente.TabIndex = 7;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionar.Location = new System.Drawing.Point(46, 25);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(318, 21);
            this.lblSeleccionar.TabIndex = 2;
            this.lblSeleccionar.Text = "Seleccione la accion que quiera realizar";
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAclaracion.ForeColor = System.Drawing.Color.Gray;
            this.lblAclaracion.Location = new System.Drawing.Point(395, 9);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(181, 37);
            this.lblAclaracion.TabIndex = 3;
            this.lblAclaracion.Text = "* Solo el Adminstrador y Supervisor pueden registrar Usuarios";
            // 
            // frmPanelRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1000, 715);
            this.Controls.Add(this.lblAclaracion);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelContenedor);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPanelRegistros";
            this.Text = "frmPanelGeneral";
            this.Load += new System.EventHandler(this.frmPanelGeneral_Load);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnMostrarUsuarios;
        private System.Windows.Forms.Button btnCliente;
    }
}