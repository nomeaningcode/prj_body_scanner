namespace prjBodyScanner.Views.Bases
{
    partial class ControlPanel
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnlPrincipal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlPrincipal.Location = new System.Drawing.Point(28, 129);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new System.Drawing.Size(1290, 535);
            pnlPrincipal.TabIndex = 10;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1348, 687);
            this.Controls.Add(pnlPrincipal);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ControlPanel";
            this.Controls.SetChildIndex(pnlPrincipal, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public static System.Windows.Forms.Panel pnlPrincipal;
    }
}
