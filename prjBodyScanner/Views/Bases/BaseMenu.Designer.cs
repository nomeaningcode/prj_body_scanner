namespace prjBodyScanner.Views.Bases
{
    partial class BaseMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseMenu));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblDoctores = new System.Windows.Forms.Label();
            this.lblRetro = new System.Windows.Forms.Label();
            this.lblAdelante = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblEscaneo = new System.Windows.Forms.Label();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.lblReportes = new System.Windows.Forms.Label();
            this.lbBitacoraRes = new System.Windows.Forms.Label();
            this.mnuBasico = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu.SuspendLayout();
            this.mnuBasico.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlMenu.Controls.Add(this.lblDoctores);
            this.pnlMenu.Controls.Add(this.lblRetro);
            this.pnlMenu.Controls.Add(this.lblAdelante);
            this.pnlMenu.Controls.Add(this.lblInicio);
            this.pnlMenu.Controls.Add(this.lblEscaneo);
            this.pnlMenu.Controls.Add(this.lblPacientes);
            this.pnlMenu.Controls.Add(this.lblReportes);
            this.pnlMenu.Controls.Add(this.lbBitacoraRes);
            this.pnlMenu.Controls.Add(this.mnuBasico);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1348, 100);
            this.pnlMenu.TabIndex = 9;
            // 
            // lblDoctores
            // 
            this.lblDoctores.AutoSize = true;
            this.lblDoctores.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctores.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoctores.Location = new System.Drawing.Point(857, 48);
            this.lblDoctores.Name = "lblDoctores";
            this.lblDoctores.Size = new System.Drawing.Size(110, 32);
            this.lblDoctores.TabIndex = 10;
            this.lblDoctores.Text = "Doctores";
            this.lblDoctores.Click += new System.EventHandler(this.lblDoctores_Click);
            // 
            // lblRetro
            // 
            this.lblRetro.AutoSize = true;
            this.lblRetro.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetro.ForeColor = System.Drawing.Color.Aqua;
            this.lblRetro.Location = new System.Drawing.Point(21, 48);
            this.lblRetro.Name = "lblRetro";
            this.lblRetro.Size = new System.Drawing.Size(40, 37);
            this.lblRetro.TabIndex = 6;
            this.lblRetro.Text = "◀";
            this.lblRetro.Click += new System.EventHandler(this.lblRetro_Click);
            // 
            // lblAdelante
            // 
            this.lblAdelante.AutoSize = true;
            this.lblAdelante.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdelante.ForeColor = System.Drawing.Color.Aqua;
            this.lblAdelante.Location = new System.Drawing.Point(67, 49);
            this.lblAdelante.Name = "lblAdelante";
            this.lblAdelante.Size = new System.Drawing.Size(40, 37);
            this.lblAdelante.TabIndex = 7;
            this.lblAdelante.Text = "▶";
            this.lblAdelante.Click += new System.EventHandler(this.lblRetro_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(160, 48);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(87, 32);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Doctor";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // lblEscaneo
            // 
            this.lblEscaneo.AutoSize = true;
            this.lblEscaneo.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscaneo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEscaneo.Location = new System.Drawing.Point(275, 48);
            this.lblEscaneo.Name = "lblEscaneo";
            this.lblEscaneo.Size = new System.Drawing.Size(101, 32);
            this.lblEscaneo.TabIndex = 1;
            this.lblEscaneo.Text = "Escaneo";
            this.lblEscaneo.Click += new System.EventHandler(this.lblEscaneo_Click);
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPacientes.Location = new System.Drawing.Point(407, 48);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(115, 32);
            this.lblPacientes.TabIndex = 2;
            this.lblPacientes.Text = "Pacientes";
            this.lblPacientes.Click += new System.EventHandler(this.lblPacientes_Click);
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Enabled = false;
            this.lblReportes.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblReportes.Location = new System.Drawing.Point(973, 48);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(109, 32);
            this.lblReportes.TabIndex = 4;
            this.lblReportes.Text = "Reportes";
            this.lblReportes.Visible = false;
            // 
            // lbBitacoraRes
            // 
            this.lbBitacoraRes.AutoSize = true;
            this.lbBitacoraRes.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBitacoraRes.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBitacoraRes.Location = new System.Drawing.Point(561, 48);
            this.lbBitacoraRes.Name = "lbBitacoraRes";
            this.lbBitacoraRes.Size = new System.Drawing.Size(250, 32);
            this.lbBitacoraRes.TabIndex = 3;
            this.lbBitacoraRes.Text = "Bitácora de resultados";
            this.lbBitacoraRes.Click += new System.EventHandler(this.lbBitacoraRes_Click);
            // 
            // mnuBasico
            // 
            this.mnuBasico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.mnuBasico.Font = new System.Drawing.Font("Arial", 10F);
            this.mnuBasico.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuBasico.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBasico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.mnuBasico.Location = new System.Drawing.Point(0, 0);
            this.mnuBasico.Name = "mnuBasico";
            this.mnuBasico.Size = new System.Drawing.Size(1348, 24);
            this.mnuBasico.TabIndex = 9;
            this.mnuBasico.Text = "myMenu";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.configuraciónToolStripMenuItem.Text = "Privacidad";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // BaseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 687);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseMenu";
            this.Text = "BodyScanner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseMenu_FormClosing);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.mnuBasico.ResumeLayout(false);
            this.mnuBasico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblDoctores;
        private System.Windows.Forms.Label lblRetro;
        private System.Windows.Forms.Label lblAdelante;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblEscaneo;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Label lbBitacoraRes;
        private System.Windows.Forms.MenuStrip mnuBasico;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}