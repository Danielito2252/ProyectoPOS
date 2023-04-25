namespace CapaPresentacion
{
    partial class frmLogin
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
            this.lblLogoEmpresa = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.Label();
            this.iconAceptar = new FontAwesome.Sharp.IconButton();
            this.iconCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogoEmpresa
            // 
            this.lblLogoEmpresa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblLogoEmpresa.Location = new System.Drawing.Point(-3, -2);
            this.lblLogoEmpresa.Name = "lblLogoEmpresa";
            this.lblLogoEmpresa.Size = new System.Drawing.Size(264, 317);
            this.lblLogoEmpresa.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Safari;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 83;
            this.iconPictureBox1.Location = new System.Drawing.Point(74, 112);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(83, 83);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.BackColor = System.Drawing.Color.RosyBrown;
            this.lblTituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTituloLogin.Location = new System.Drawing.Point(48, 212);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(139, 25);
            this.lblTituloLogin.TabIndex = 2;
            this.lblTituloLogin.Text = "Sistema POS";
            this.lblTituloLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(292, 58);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(235, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(235, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(289, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoSize = true;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtContraseña.Location = new System.Drawing.Point(289, 96);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(95, 20);
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.Text = "Contraseña";
            // 
            // iconAceptar
            // 
            this.iconAceptar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconAceptar.IconColor = System.Drawing.Color.Black;
            this.iconAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAceptar.Location = new System.Drawing.Point(292, 172);
            this.iconAceptar.Name = "iconAceptar";
            this.iconAceptar.Size = new System.Drawing.Size(75, 23);
            this.iconAceptar.TabIndex = 7;
            this.iconAceptar.Text = "Aceptar";
            this.iconAceptar.UseVisualStyleBackColor = true;
            this.iconAceptar.Click += new System.EventHandler(this.iconAceptar_Click);
            // 
            // iconCancelar
            // 
            this.iconCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconCancelar.IconColor = System.Drawing.Color.Black;
            this.iconCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCancelar.Location = new System.Drawing.Point(452, 172);
            this.iconCancelar.Name = "iconCancelar";
            this.iconCancelar.Size = new System.Drawing.Size(75, 23);
            this.iconCancelar.TabIndex = 8;
            this.iconCancelar.Text = "Cancelar";
            this.iconCancelar.UseVisualStyleBackColor = true;
            this.iconCancelar.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.iconAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.iconCancelar;
            this.ClientSize = new System.Drawing.Size(567, 316);
            this.Controls.Add(this.iconCancelar);
            this.Controls.Add(this.iconAceptar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblTituloLogin);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lblLogoEmpresa);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogoEmpresa;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtContraseña;
        private FontAwesome.Sharp.IconButton iconAceptar;
        private FontAwesome.Sharp.IconButton iconCancelar;
    }
}