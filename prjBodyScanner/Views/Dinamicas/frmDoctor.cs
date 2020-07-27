using prjBodyScanner.Cache;
using prjBodyScanner.Data.Infraetructura;
using prjBodyScanner.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBodyScanner.Views.Dinamicas
{
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }
        private void frmDoctor_Load(object sender, EventArgs e)
        {
            InicializadorCustom();
        }
        private void InicializadorCustom()
        {
            LoadDataToTextBox();
            SetDataToGridViewUser();
            EstadoTextBox(false);
            ResizeGV();
        }

        private IRepositorioDoctorUs conn = new RepositorioDoctorUs();

        #region Diseño responsivo
        private void ResizeGV()
        {
            foreach (DataGridViewColumn _col in dgvBitacora.Columns) {
                _col.Width = tamanio();
            }
        }
        private int tamanio()
        {
            int ta = (this.dgvBitacora.Width / dgvBitacora.ColumnCount);
            int tam = ta + (ta / 65);
            return tam;
        }

        private void dgvBitacora_Resize(object sender, EventArgs e)
        {
            ResizeGV();
        }
        #endregion

        #region iniciocom

        private void EstadoTextBox(bool estado)
        {
            txtCelular.Enabled = estado;
            txtCorreo.Enabled = estado;
            btnAgregarF.Enabled = estado;
            btnAgregarF.Visible = estado;
            btnCancelar.Enabled = estado;
            btnCancelar.Visible = estado;
            btnGuardar.Enabled = estado;
            btnGuardar.Visible = estado;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EstadoTextBox(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoTextBox(false);
        }
        #endregion

        #region Data
        private void SetDataToGridViewUser()
        {

            dgvBitacora.AutoGenerateColumns = false;
            dgvBitacora.DataSource = conn.GetEntradas(UserLoginCache.IIDoctor);
            dgvBitacora.Columns[0].DataPropertyName = "NombreDocBD";
            dgvBitacora.Columns[1].DataPropertyName = "FechaBD";
            dgvBitacora.Columns[2].DataPropertyName = "HoraBD";
            dgvBitacora.Columns[3].DataPropertyName = "EquipoBD";

        }
        private void LoadDataToTextBox()
        {
            txtNombre.Text = UserLoginCache.Nombre;
            txtAPaterno.Text = UserLoginCache.ApellidoP;
            txtAmaterno.Text = UserLoginCache.ApellidoM;
            txtCelular.Text = UserLoginCache.Telefono;
            txtCorreo.Text = UserLoginCache.Correo;
        }

        #endregion

    }
}
