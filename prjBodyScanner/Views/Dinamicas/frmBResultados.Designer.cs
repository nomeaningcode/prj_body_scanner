namespace prjBodyScanner.Views.Dinamicas
{
    partial class frmBResultados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SplitGeneral = new System.Windows.Forms.SplitContainer();
            this.SplitComtroles = new System.Windows.Forms.SplitContainer();
            this.SplitGV = new System.Windows.Forms.SplitContainer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SplitDisenioC = new System.Windows.Forms.SplitContainer();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.clmIDEscaneo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDoctorMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomPac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitBotonEd = new System.Windows.Forms.SplitContainer();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplitGeneral)).BeginInit();
            this.SplitGeneral.Panel1.SuspendLayout();
            this.SplitGeneral.Panel2.SuspendLayout();
            this.SplitGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitComtroles)).BeginInit();
            this.SplitComtroles.Panel1.SuspendLayout();
            this.SplitComtroles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitGV)).BeginInit();
            this.SplitGV.Panel1.SuspendLayout();
            this.SplitGV.Panel2.SuspendLayout();
            this.SplitGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitDisenioC)).BeginInit();
            this.SplitDisenioC.Panel2.SuspendLayout();
            this.SplitDisenioC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitBotonEd)).BeginInit();
            this.SplitBotonEd.Panel1.SuspendLayout();
            this.SplitBotonEd.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitGeneral
            // 
            this.SplitGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitGeneral.IsSplitterFixed = true;
            this.SplitGeneral.Location = new System.Drawing.Point(0, 0);
            this.SplitGeneral.Name = "SplitGeneral";
            this.SplitGeneral.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitGeneral.Panel1
            // 
            this.SplitGeneral.Panel1.Controls.Add(this.SplitComtroles);
            // 
            // SplitGeneral.Panel2
            // 
            this.SplitGeneral.Panel2.Controls.Add(this.SplitBotonEd);
            this.SplitGeneral.Size = new System.Drawing.Size(1280, 525);
            this.SplitGeneral.SplitterDistance = 466;
            this.SplitGeneral.TabIndex = 1;
            // 
            // SplitComtroles
            // 
            this.SplitComtroles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitComtroles.IsSplitterFixed = true;
            this.SplitComtroles.Location = new System.Drawing.Point(0, 0);
            this.SplitComtroles.Name = "SplitComtroles";
            // 
            // SplitComtroles.Panel1
            // 
            this.SplitComtroles.Panel1.Controls.Add(this.SplitGV);
            this.SplitComtroles.Size = new System.Drawing.Size(1280, 466);
            this.SplitComtroles.SplitterDistance = 939;
            this.SplitComtroles.TabIndex = 0;
            // 
            // SplitGV
            // 
            this.SplitGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitGV.IsSplitterFixed = true;
            this.SplitGV.Location = new System.Drawing.Point(0, 0);
            this.SplitGV.Name = "SplitGV";
            this.SplitGV.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitGV.Panel1
            // 
            this.SplitGV.Panel1.Controls.Add(this.lblTitulo);
            // 
            // SplitGV.Panel2
            // 
            this.SplitGV.Panel2.Controls.Add(this.SplitDisenioC);
            this.SplitGV.Size = new System.Drawing.Size(939, 466);
            this.SplitGV.SplitterDistance = 64;
            this.SplitGV.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(25, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(277, 34);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Bitácora de resultados";
            // 
            // SplitDisenioC
            // 
            this.SplitDisenioC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitDisenioC.IsSplitterFixed = true;
            this.SplitDisenioC.Location = new System.Drawing.Point(0, 0);
            this.SplitDisenioC.Name = "SplitDisenioC";
            // 
            // SplitDisenioC.Panel2
            // 
            this.SplitDisenioC.Panel2.Controls.Add(this.dgvResultado);
            this.SplitDisenioC.Panel2.Controls.Add(this.dtgEmpleados);
            this.SplitDisenioC.Size = new System.Drawing.Size(939, 398);
            this.SplitDisenioC.SplitterDistance = 25;
            this.SplitDisenioC.TabIndex = 0;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvResultado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultado.ColumnHeadersHeight = 30;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDEscaneo,
            this.clmDoctorMat,
            this.clmIDPaciente,
            this.clmNomPac,
            this.clmEnfermedad});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultado.EnableHeadersVisualStyles = false;
            this.dgvResultado.GridColor = System.Drawing.Color.DimGray;
            this.dgvResultado.Location = new System.Drawing.Point(0, 0);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvResultado.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(910, 398);
            this.dgvResultado.TabIndex = 2;
            this.dgvResultado.Resize += new System.EventHandler(this.Empledos_Resize);
            // 
            // clmIDEscaneo
            // 
            this.clmIDEscaneo.HeaderText = "ID Escaneo";
            this.clmIDEscaneo.Name = "clmIDEscaneo";
            this.clmIDEscaneo.ReadOnly = true;
            // 
            // clmDoctorMat
            // 
            this.clmDoctorMat.HeaderText = "Matricula medico";
            this.clmDoctorMat.Name = "clmDoctorMat";
            this.clmDoctorMat.ReadOnly = true;
            // 
            // clmIDPaciente
            // 
            this.clmIDPaciente.HeaderText = "IdPaciente";
            this.clmIDPaciente.Name = "clmIDPaciente";
            this.clmIDPaciente.ReadOnly = true;
            // 
            // clmNomPac
            // 
            this.clmNomPac.HeaderText = "Nombre Paciente";
            this.clmNomPac.Name = "clmNomPac";
            this.clmNomPac.ReadOnly = true;
            // 
            // clmEnfermedad
            // 
            this.clmEnfermedad.HeaderText = "Enfermedad";
            this.clmEnfermedad.Name = "clmEnfermedad";
            this.clmEnfermedad.ReadOnly = true;
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.AllowUserToAddRows = false;
            this.dtgEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dtgEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgEmpleados.ColumnHeadersHeight = 30;
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombre,
            this.clmCargo,
            this.clmTelefono,
            this.clmCorreo});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEmpleados.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEmpleados.EnableHeadersVisualStyles = false;
            this.dtgEmpleados.GridColor = System.Drawing.Color.DimGray;
            this.dtgEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dtgEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpleados.Size = new System.Drawing.Size(910, 398);
            this.dtgEmpleados.TabIndex = 1;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmCargo
            // 
            this.clmCargo.HeaderText = "Cargo";
            this.clmCargo.Name = "clmCargo";
            this.clmCargo.ReadOnly = true;
            // 
            // clmTelefono
            // 
            this.clmTelefono.HeaderText = "Telefono";
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.ReadOnly = true;
            // 
            // clmCorreo
            // 
            this.clmCorreo.HeaderText = "Correo";
            this.clmCorreo.Name = "clmCorreo";
            this.clmCorreo.ReadOnly = true;
            // 
            // SplitBotonEd
            // 
            this.SplitBotonEd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitBotonEd.IsSplitterFixed = true;
            this.SplitBotonEd.Location = new System.Drawing.Point(0, 0);
            this.SplitBotonEd.Name = "SplitBotonEd";
            // 
            // SplitBotonEd.Panel1
            // 
            this.SplitBotonEd.Panel1.Controls.Add(this.btnExportar);
            this.SplitBotonEd.Panel1.Controls.Add(this.btnEliminar);
            this.SplitBotonEd.Size = new System.Drawing.Size(1280, 55);
            this.SplitBotonEd.SplitterDistance = 939;
            this.SplitBotonEd.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(29, 20);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(173, 23);
            this.btnExportar.TabIndex = 11;
            this.btnExportar.Text = "Exportar datos a Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(584, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmBResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1280, 525);
            this.Controls.Add(this.SplitGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBResultados";
            this.Text = "FrmEmpleado";
            this.Load += new System.EventHandler(this.frmBResultados_Load);
            this.SplitGeneral.Panel1.ResumeLayout(false);
            this.SplitGeneral.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitGeneral)).EndInit();
            this.SplitGeneral.ResumeLayout(false);
            this.SplitComtroles.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitComtroles)).EndInit();
            this.SplitComtroles.ResumeLayout(false);
            this.SplitGV.Panel1.ResumeLayout(false);
            this.SplitGV.Panel1.PerformLayout();
            this.SplitGV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitGV)).EndInit();
            this.SplitGV.ResumeLayout(false);
            this.SplitDisenioC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitDisenioC)).EndInit();
            this.SplitDisenioC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.SplitBotonEd.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitBotonEd)).EndInit();
            this.SplitBotonEd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitGeneral;
        private System.Windows.Forms.SplitContainer SplitComtroles;
        private System.Windows.Forms.SplitContainer SplitGV;
        private System.Windows.Forms.SplitContainer SplitBotonEd;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.SplitContainer SplitDisenioC;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCorreo;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDEscaneo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDoctorMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomPac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEnfermedad;
    }
}