namespace prjBodyScanner.Views.Dinamicas
{
    partial class frmDoctor
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
            this.SpliGeneral = new System.Windows.Forms.SplitContainer();
            this.SpDatos = new System.Windows.Forms.SplitContainer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.sph1 = new System.Windows.Forms.SplitContainer();
            this.SPEdicion = new System.Windows.Forms.SplitContainer();
            this.btnAgregarF = new System.Windows.Forms.Button();
            this.ptbFotoUser = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAPaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.spHGUE = new System.Windows.Forms.SplitContainer();
            this.SPDesi = new System.Windows.Forms.SplitContainer();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SplitG = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.SplitDise = new System.Windows.Forms.SplitContainer();
            this.spv1 = new System.Windows.Forms.SplitContainer();
            this.spv2 = new System.Windows.Forms.SplitContainer();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpliGeneral)).BeginInit();
            this.SpliGeneral.Panel1.SuspendLayout();
            this.SpliGeneral.Panel2.SuspendLayout();
            this.SpliGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpDatos)).BeginInit();
            this.SpDatos.Panel1.SuspendLayout();
            this.SpDatos.Panel2.SuspendLayout();
            this.SpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sph1)).BeginInit();
            this.sph1.Panel1.SuspendLayout();
            this.sph1.Panel2.SuspendLayout();
            this.sph1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPEdicion)).BeginInit();
            this.SPEdicion.Panel1.SuspendLayout();
            this.SPEdicion.Panel2.SuspendLayout();
            this.SPEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHGUE)).BeginInit();
            this.spHGUE.Panel2.SuspendLayout();
            this.spHGUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPDesi)).BeginInit();
            this.SPDesi.Panel1.SuspendLayout();
            this.SPDesi.Panel2.SuspendLayout();
            this.SPDesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitG)).BeginInit();
            this.SplitG.Panel1.SuspendLayout();
            this.SplitG.Panel2.SuspendLayout();
            this.SplitG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitDise)).BeginInit();
            this.SplitDise.Panel1.SuspendLayout();
            this.SplitDise.Panel2.SuspendLayout();
            this.SplitDise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spv1)).BeginInit();
            this.spv1.Panel2.SuspendLayout();
            this.spv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spv2)).BeginInit();
            this.spv2.Panel1.SuspendLayout();
            this.spv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // SpliGeneral
            // 
            this.SpliGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpliGeneral.Location = new System.Drawing.Point(0, 0);
            this.SpliGeneral.Name = "SpliGeneral";
            // 
            // SpliGeneral.Panel1
            // 
            this.SpliGeneral.Panel1.Controls.Add(this.SpDatos);
            // 
            // SpliGeneral.Panel2
            // 
            this.SpliGeneral.Panel2.Controls.Add(this.SplitG);
            this.SpliGeneral.Size = new System.Drawing.Size(1280, 525);
            this.SpliGeneral.SplitterDistance = 525;
            this.SpliGeneral.TabIndex = 0;
            // 
            // SpDatos
            // 
            this.SpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpDatos.IsSplitterFixed = true;
            this.SpDatos.Location = new System.Drawing.Point(0, 0);
            this.SpDatos.Name = "SpDatos";
            this.SpDatos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpDatos.Panel1
            // 
            this.SpDatos.Panel1.Controls.Add(this.lblTitulo);
            // 
            // SpDatos.Panel2
            // 
            this.SpDatos.Panel2.Controls.Add(this.sph1);
            this.SpDatos.Size = new System.Drawing.Size(525, 525);
            this.SpDatos.SplitterDistance = 65;
            this.SpDatos.TabIndex = 132;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(25, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 34);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Datos del medico";
            // 
            // sph1
            // 
            this.sph1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sph1.IsSplitterFixed = true;
            this.sph1.Location = new System.Drawing.Point(0, 0);
            this.sph1.Name = "sph1";
            this.sph1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sph1.Panel1
            // 
            this.sph1.Panel1.Controls.Add(this.SPEdicion);
            // 
            // sph1.Panel2
            // 
            this.sph1.Panel2.Controls.Add(this.spHGUE);
            this.sph1.Size = new System.Drawing.Size(525, 456);
            this.sph1.SplitterDistance = 390;
            this.sph1.TabIndex = 0;
            // 
            // SPEdicion
            // 
            this.SPEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPEdicion.Location = new System.Drawing.Point(0, 0);
            this.SPEdicion.Name = "SPEdicion";
            // 
            // SPEdicion.Panel1
            // 
            this.SPEdicion.Panel1.Controls.Add(this.btnAgregarF);
            this.SPEdicion.Panel1.Controls.Add(this.ptbFotoUser);
            // 
            // SPEdicion.Panel2
            // 
            this.SPEdicion.Panel2.Controls.Add(this.btnEditar);
            this.SPEdicion.Panel2.Controls.Add(this.txtCorreo);
            this.SPEdicion.Panel2.Controls.Add(this.label7);
            this.SPEdicion.Panel2.Controls.Add(this.txtCelular);
            this.SPEdicion.Panel2.Controls.Add(this.label5);
            this.SPEdicion.Panel2.Controls.Add(this.txtAmaterno);
            this.SPEdicion.Panel2.Controls.Add(this.label4);
            this.SPEdicion.Panel2.Controls.Add(this.txtAPaterno);
            this.SPEdicion.Panel2.Controls.Add(this.label3);
            this.SPEdicion.Panel2.Controls.Add(this.txtNombre);
            this.SPEdicion.Panel2.Controls.Add(this.label2);
            this.SPEdicion.Size = new System.Drawing.Size(525, 390);
            this.SPEdicion.SplitterDistance = 235;
            this.SPEdicion.TabIndex = 0;
            // 
            // btnAgregarF
            // 
            this.btnAgregarF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarF.Location = new System.Drawing.Point(41, 329);
            this.btnAgregarF.Name = "btnAgregarF";
            this.btnAgregarF.Size = new System.Drawing.Size(152, 23);
            this.btnAgregarF.TabIndex = 5;
            this.btnAgregarF.Text = "AgregarFoto";
            this.btnAgregarF.UseVisualStyleBackColor = true;
            // 
            // ptbFotoUser
            // 
            this.ptbFotoUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbFotoUser.Location = new System.Drawing.Point(17, 15);
            this.ptbFotoUser.Name = "ptbFotoUser";
            this.ptbFotoUser.Size = new System.Drawing.Size(201, 279);
            this.ptbFotoUser.TabIndex = 4;
            this.ptbFotoUser.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.Cyan;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(107, 341);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(156, 27);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar datos";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.Location = new System.Drawing.Point(15, 230);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(248, 24);
            this.txtCorreo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(12, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Correo electrónico";
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCelular.Location = new System.Drawing.Point(15, 181);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(248, 24);
            this.txtCelular.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono celular";
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmaterno.Enabled = false;
            this.txtAmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmaterno.Location = new System.Drawing.Point(15, 133);
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(248, 24);
            this.txtAmaterno.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido materno";
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAPaterno.Enabled = false;
            this.txtAPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPaterno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAPaterno.Location = new System.Drawing.Point(15, 85);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(248, 24);
            this.txtAPaterno.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(15, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // spHGUE
            // 
            this.spHGUE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spHGUE.IsSplitterFixed = true;
            this.spHGUE.Location = new System.Drawing.Point(0, 0);
            this.spHGUE.Name = "spHGUE";
            // 
            // spHGUE.Panel2
            // 
            this.spHGUE.Panel2.Controls.Add(this.SPDesi);
            this.spHGUE.Size = new System.Drawing.Size(525, 62);
            this.spHGUE.SplitterDistance = 235;
            this.spHGUE.TabIndex = 0;
            // 
            // SPDesi
            // 
            this.SPDesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPDesi.Location = new System.Drawing.Point(0, 0);
            this.SPDesi.Name = "SPDesi";
            // 
            // SPDesi.Panel1
            // 
            this.SPDesi.Panel1.Controls.Add(this.btnCancelar);
            // 
            // SPDesi.Panel2
            // 
            this.SPDesi.Panel2.Controls.Add(this.btnGuardar);
            this.SPDesi.Size = new System.Drawing.Size(286, 62);
            this.SPDesi.SplitterDistance = 143;
            this.SPDesi.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(15, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 27);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(13, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 27);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // SplitG
            // 
            this.SplitG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitG.IsSplitterFixed = true;
            this.SplitG.Location = new System.Drawing.Point(0, 0);
            this.SplitG.Name = "SplitG";
            this.SplitG.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitG.Panel1
            // 
            this.SplitG.Panel1.Controls.Add(this.label1);
            // 
            // SplitG.Panel2
            // 
            this.SplitG.Panel2.Controls.Add(this.SplitDise);
            this.SplitG.Size = new System.Drawing.Size(751, 525);
            this.SplitG.SplitterDistance = 65;
            this.SplitG.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entradas de medico";
            // 
            // SplitDise
            // 
            this.SplitDise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitDise.Location = new System.Drawing.Point(0, 0);
            this.SplitDise.Name = "SplitDise";
            this.SplitDise.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitDise.Panel1
            // 
            this.SplitDise.Panel1.Controls.Add(this.spv1);
            // 
            // SplitDise.Panel2
            // 
            this.SplitDise.Panel2.Controls.Add(this.btnlimpiar);
            this.SplitDise.Size = new System.Drawing.Size(751, 456);
            this.SplitDise.SplitterDistance = 390;
            this.SplitDise.TabIndex = 0;
            // 
            // spv1
            // 
            this.spv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spv1.Location = new System.Drawing.Point(0, 0);
            this.spv1.Name = "spv1";
            // 
            // spv1.Panel2
            // 
            this.spv1.Panel2.Controls.Add(this.spv2);
            this.spv1.Size = new System.Drawing.Size(751, 390);
            this.spv1.SplitterDistance = 25;
            this.spv1.TabIndex = 0;
            // 
            // spv2
            // 
            this.spv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spv2.IsSplitterFixed = true;
            this.spv2.Location = new System.Drawing.Point(0, 0);
            this.spv2.Name = "spv2";
            // 
            // spv2.Panel1
            // 
            this.spv2.Panel1.Controls.Add(this.dgvBitacora);
            this.spv2.Size = new System.Drawing.Size(722, 390);
            this.spv2.SplitterDistance = 693;
            this.spv2.TabIndex = 0;
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBitacora.ColumnHeadersHeight = 35;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmDia,
            this.clmHora,
            this.clmEquipo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBitacora.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBitacora.EnableHeadersVisualStyles = false;
            this.dgvBitacora.Location = new System.Drawing.Point(0, 0);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBitacora.Size = new System.Drawing.Size(693, 390);
            this.dgvBitacora.TabIndex = 0;
            this.dgvBitacora.Resize += new System.EventHandler(this.dgvBitacora_Resize);
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre de usuario";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmDia
            // 
            this.clmDia.HeaderText = "Fecha";
            this.clmDia.Name = "clmDia";
            this.clmDia.ReadOnly = true;
            // 
            // clmHora
            // 
            this.clmHora.HeaderText = "Hora de entrada";
            this.clmHora.Name = "clmHora";
            this.clmHora.ReadOnly = true;
            // 
            // clmEquipo
            // 
            this.clmEquipo.HeaderText = "Accedio en:";
            this.clmEquipo.Name = "clmEquipo";
            this.clmEquipo.ReadOnly = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(537, 18);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(185, 23);
            this.btnlimpiar.TabIndex = 0;
            this.btnlimpiar.Text = "Limpiar bitacora";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // Actualizar
            // 
            this.Actualizar.Interval = 10000;
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1280, 525);
            this.Controls.Add(this.SpliGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoctor";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            this.SpliGeneral.Panel1.ResumeLayout(false);
            this.SpliGeneral.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpliGeneral)).EndInit();
            this.SpliGeneral.ResumeLayout(false);
            this.SpDatos.Panel1.ResumeLayout(false);
            this.SpDatos.Panel1.PerformLayout();
            this.SpDatos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpDatos)).EndInit();
            this.SpDatos.ResumeLayout(false);
            this.sph1.Panel1.ResumeLayout(false);
            this.sph1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sph1)).EndInit();
            this.sph1.ResumeLayout(false);
            this.SPEdicion.Panel1.ResumeLayout(false);
            this.SPEdicion.Panel2.ResumeLayout(false);
            this.SPEdicion.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPEdicion)).EndInit();
            this.SPEdicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotoUser)).EndInit();
            this.spHGUE.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spHGUE)).EndInit();
            this.spHGUE.ResumeLayout(false);
            this.SPDesi.Panel1.ResumeLayout(false);
            this.SPDesi.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPDesi)).EndInit();
            this.SPDesi.ResumeLayout(false);
            this.SplitG.Panel1.ResumeLayout(false);
            this.SplitG.Panel1.PerformLayout();
            this.SplitG.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitG)).EndInit();
            this.SplitG.ResumeLayout(false);
            this.SplitDise.Panel1.ResumeLayout(false);
            this.SplitDise.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitDise)).EndInit();
            this.SplitDise.ResumeLayout(false);
            this.spv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spv1)).EndInit();
            this.spv1.ResumeLayout(false);
            this.spv2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spv2)).EndInit();
            this.spv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpliGeneral;
        private System.Windows.Forms.SplitContainer SpDatos;
        private System.Windows.Forms.SplitContainer SplitG;
        private System.Windows.Forms.SplitContainer SplitDise;
        private System.Windows.Forms.SplitContainer spv1;
        private System.Windows.Forms.SplitContainer spv2;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer sph1;
        private System.Windows.Forms.SplitContainer SPEdicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAPaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarF;
        private System.Windows.Forms.PictureBox ptbFotoUser;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.SplitContainer spHGUE;
        private System.Windows.Forms.SplitContainer SPDesi;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Timer Actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEquipo;
        private System.Windows.Forms.Button btnlimpiar;
    }
}