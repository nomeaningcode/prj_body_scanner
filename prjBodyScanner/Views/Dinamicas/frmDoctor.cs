using prjBodyScanner.Cache;
using prjBodyScanner.Data.Infraetructura;
using prjBodyScanner.Data.Modelo;
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
        private DoctorBD RecoleccionDatos()
        {

            DoctorBD objDoctor = new DoctorBD();
            objDoctor.IDDoctor = UserLoginCache.IIDoctor;
            objDoctor.CorreoEBD = txtCorreo.Text;
            objDoctor.TelefonoEBD = txtCelular.Text;

            UserLoginCache.Telefono = objDoctor.TelefonoEBD;
            UserLoginCache.Correo = objDoctor.CorreoEBD;

            return objDoctor;
        }

        private bool ActualizarDatos()
        {
            bool respuesta = conn.ActualizarEmpleadoFB(RecoleccionDatos());

            if (respuesta == true)
            {
                LoadDataToTextBox();
                MessageBox.Show("Actuliazción de datos correcta", "Transacción finalizada", 0, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Transacción fallida", "Error", 0, MessageBoxIcon.Error);
            }

            EstadoTextBox(false);

            return respuesta;
        }

        #endregion

        #region eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
        private void Actualizar_Tick(object sender, EventArgs e)
        {
            SetDataToGridViewUser();
        }

        #endregion
    }
}
