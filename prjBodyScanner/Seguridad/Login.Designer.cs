namespace prjBodyScanner.Seguridad
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMinizar = new System.Windows.Forms.Label();
            this.lblclose = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(18, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 13);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Iniciar sesión BodyScanner";
            // 
            // lblMinizar
            // 
            this.lblMinizar.AutoSize = true;
            this.lblMinizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinizar.ForeColor = System.Drawing.Color.Teal;
            this.lblMinizar.Location = new System.Drawing.Point(459, 2);
            this.lblMinizar.Name = "lblMinizar";
            this.lblMinizar.Size = new System.Drawing.Size(25, 33);
            this.lblMinizar.TabIndex = 19;
            this.lblMinizar.Text = "-";
            this.lblMinizar.Click += new System.EventHandler(this.lblMinizar_Click);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.DarkRed;
            this.lblclose.Location = new System.Drawing.Point(490, 11);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(20, 20);
            this.lblclose.TabIndex = 18;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(322, 245);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 29);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(138)))), ((int)(((byte)(186)))));
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.Black;
            this.btnAcceder.Location = new System.Drawing.Point(156, 245);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(150, 29);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "Iniciar sesión";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Black;
            this.lblPass.Location = new System.Drawing.Point(46, 178);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(89, 18);
            this.lblPass.TabIndex = 15;
            this.lblPass.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(156, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(316, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(156, 127);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(316, 26);
            this.txtUser.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(71, 134);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 18);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Usuario:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(152, 213);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 21;
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLogo.Image = global::prjBodyScanner.Properties.Resources.Logo;
            this.imgLogo.Location = new System.Drawing.Point(43, 50);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(121, 61);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 11;
            this.imgLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(525, 350);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMinizar);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(525, 350);
            this.Name = "Login";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMinizar;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblError;

    }
}