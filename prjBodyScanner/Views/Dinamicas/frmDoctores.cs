using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using prjBodyScanner.Clases;
using prjBodyScanner.Data.Infraestructura;
using prjBodyScanner.Data.Modelo;
using prjBodyScanner.Data.Repository;

namespace prjBodyScanner.Views.Dinamicas
{
    public partial class frmDoctores : Form
    {

        private IRepositoryDoctores contexto = new RepositoryDoctor();
        public frmDoctores()
        {
            InitializeComponent();
        }

        private void frmDoctores_Load(object sender, EventArgs e)
        {
            InicializadorCustom();
        } 
        private void InicializadorCustom()
        {
            ResizeDGVAction();
            DisabledTextBox();
            SetDataToDGVe();
        }

        private int RowSeleccionada = 0;
        private bool EdiOrCr = false;

        #region Diseño responsivo

        private void ResizeDGVAction()
        {
            foreach (DataGridViewColumn _col in dgvDoctores.Columns)
            {
                _col.Width = CTamaño();
            }

        }

        private int CTamaño()
        {
            int Tamano = this.dgvDoctores.Width / this.dgvDoctores.Columns.Count;

            return Tamano;
        }

        private void Empledos_Resize(object sender, EventArgs e)
        {
            ResizeDGVAction();
        }

        #endregion

        #region EstadoVariables

        private void DisabledTextBox()
        {

            this.txtNombre.Enabled = this.txtApaterno.Enabled = this.txtAmaterno.Enabled = this.txttelefono.Enabled = this.txtCorreo.Enabled = this.txtContrasena.Enabled = this.btnGuardar.Enabled = false;

            this.btnGuardar.BackColor = Color.PaleGreen;
            this.SplitComtroles.SplitterDistance = this.Width;
            this.SplitEdicionP.Visible = false;
        }

        private void EnabledTextBox()
        {

            this.txtNombre.Enabled = this.txtApaterno.Enabled = this.txtAmaterno.Enabled = this.txttelefono.Enabled = this.txtCorreo.Enabled = this.btnGuardar.Enabled = true;

            this.btnGuardar.BackColor = Color.Lime;

            if (EdiOrCr == true)
            {
                this.txtContrasena.Enabled = true;
                this.txtContrasena.BackColor = Color.White;
            }

            this.SplitComtroles.SplitterDistance = 940;
            this.SplitEdicionP.Visible = true;
        }

        private void Limpiar()
        {
            this.txtID.Clear();
            this.txtNombre.Clear();
            this.txtApaterno.Clear();
            this.txtAmaterno.Clear();
            this.txttelefono.Clear();
            this.txtCorreo.Clear();
            this.txtContrasena.Clear();
            this.txtMatricula.Clear();

        }


        #endregion

        #region Creacion de usuario y contraseña

        private string GenerarContrasenia()
        {
            string c = GenerarPassword.GetPassword();
            return c;
        }

        #endregion

        #region Metodos de control

        private DialogResult Desicion()
        {

            string Mensaje = "Se esta editando otro item\n\n¿Desea continuar?";
            string tt = "Alerta";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(Mensaje, tt, botones, MessageBoxIcon.Warning);

            return result;
        }

        private int ContarSeleccionados()
        {

            int Conta = (int)dgvDoctores.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (Conta > 1)
            {
                MessageBox.Show("Selecciona solo uno", "Alerta", 0, MessageBoxIcon.Information);
            }

            return Conta;

        }

        private void SeleccionarUltimoC()
        {
            this.dgvDoctores.Rows[dgvDoctores.Rows.Count - 1].Selected = true;
            this.dgvDoctores.CurrentCell = dgvDoctores.Rows[dgvDoctores.Rows.Count - 1].Cells[0];
        }

        private void SeleccionarEditado()
        {
            this.dgvDoctores.Rows[RowSeleccionada].Selected = true;
            this.dgvDoctores.CurrentCell = dgvDoctores.Rows[RowSeleccionada].Cells[0];
        }

        private int ControlVacio(string _accion)
        {

            int TotalS = dgvDoctores.Rows.Count;

            if (TotalS == 0)
            {
                MessageBox.Show("No hay suficientes items para " + _accion, "Alerta", 0, MessageBoxIcon.Information);
            }

            return TotalS;
        }


        #endregion

        #region Metodos Insertar
        private DoctorBD GetDataFromTextBox(DoctorBD _pac)
        {

            _pac.NombreEBD = txtNombre.Text;
            _pac.Matricula = txtMatricula.Text;
            _pac.APaternoBD = txtApaterno.Text;
            _pac.AMarteno = txtAmaterno.Text;
            _pac.TelefonoEBD = txttelefono.Text;
            _pac.CorreoEBD = txtCorreo.Text;
            _pac.ContraseniaBD = txtContrasena.Text;
            return _pac;

        }
        private DoctorBD CreateObjectDoctor()
        {

            DoctorBD doctor = new DoctorBD();
            DoctorBD Retornable = null;

            if (EdiOrCr == true)
            {
                Retornable = GetDataFromTextBox(doctor);
            }
            else
            {
                int idE = int.Parse(txtID.Text);
                Retornable = GetDataFromTextBox(doctor);
                Retornable.IDDoctor = idE;
            }

            return Retornable;
        }
        private void ControlInsertar()
        {
            if (txtID.Text == "")
            {
                EdiOrCr = true;
                EnabledTextBox();
                ControlMatriculaContrasenia();
            }
            else
            {
                if (Desicion() == DialogResult.Yes)
                {
                    Limpiar();
                    EdiOrCr = true;
                    EnabledTextBox();
                    ControlMatriculaContrasenia();
                }
            }
        }

        private void ControlMatriculaContrasenia()
        {
            txtMatricula.Text = GenerarContrasenia();
            txtContrasena.Enabled = true;
            txtContrasena.ReadOnly = false;
        }

        private void Insertar()
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("El Doctor debe de poseer nombre", "Alerta", 0, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtContrasena.Text == "")
                {
                    MessageBox.Show("Agregue una contraseña para el primer logeo\n\nPosteriomente la podra configurar desde:\nPrivacidad ",
                        "Alerta", 0, MessageBoxIcon.Warning);
                }
                else
                {
                    bool Confirma = contexto.InsertarDoctor(CreateObjectDoctor());

                    if (Confirma == true)
                    {
                        MessageBox.Show("Registro exitoso", "Operación finalizada", 0, MessageBoxIcon.Information);
                        SetDataToDGVe();
                        SeleccionarUltimoC();
                        Limpiar();
                        DisabledTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Registro fallido", "Error inesperado", 0, MessageBoxIcon.Information);
                    }
                }
            }

        }

        #endregion

        #region Data
        private void SetDataToDGVe()
        {

            this.dgvDoctores.AutoGenerateColumns = false;
            this.dgvDoctores.DataSource = contexto.GetDoctores();

            this.dgvDoctores.Columns[0].DataPropertyName = "IDDoctor";
            this.dgvDoctores.Columns[1].DataPropertyName = "Matricula";
            this.dgvDoctores.Columns[2].DataPropertyName = "NombreEBD";
            this.dgvDoctores.Columns[3].DataPropertyName = "APaternoBD";
            this.dgvDoctores.Columns[4].DataPropertyName = "AMarteno";
            this.dgvDoctores.Columns[5].DataPropertyName = "TelefonoEBD";
            this.dgvDoctores.Columns[6].DataPropertyName = "CorreoEBD";
        }
        #endregion

        #region ActualizarDoctor
        private void SetDataToTextBox()
        {
            int IdA = (int)dgvDoctores.CurrentRow.Cells[0].Value;
            DoctorBD doctor = contexto.GetDoctorById(IdA);

            txtID.Text = doctor.IDDoctor.ToString();
            txtMatricula.Text = doctor.Matricula;
            txtNombre.Text = doctor.NombreEBD;
            txtApaterno.Text = doctor.APaternoBD;
            txtAmaterno.Text = doctor.AMarteno;
            txttelefono.Text = doctor.TelefonoEBD;
            txtCorreo.Text = doctor.CorreoEBD;
            txtContrasena.Text = doctor.ContraseniaBD;
        }
        private void PermitirActualizacion()
        {

            if (txtID.Text == "")
            {

                RowSeleccionada = (int)dgvDoctores.CurrentCell.RowIndex;
                EdiOrCr = false;
                SetDataToTextBox();
                EnabledTextBox();
            }
            else
            {
                if (Desicion() == DialogResult.Yes)
                {

                    RowSeleccionada = (int)dgvDoctores.CurrentCell.RowIndex;
                    EdiOrCr = false;
                    SetDataToTextBox();
                    EnabledTextBox();
                }
            }
        }
        private void dgvDoctores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDoctores.CurrentRow.Index >= 0 && dgvDoctores.CurrentCell.ColumnIndex >= 0)
            {
                PermitirActualizacion();
            }
        }

        public void actualizar()
        {
            bool Confirma = contexto.ActualizarDoctor(CreateObjectDoctor());

            if (Confirma == true)
            {
                MessageBox.Show("Actualización exitosa", "Proceso finalizado", 0, MessageBoxIcon.Information);
                SetDataToDGVe();
                RegistroExitoso();
                SeleccionarEditado();
            }
            else
            {
                MessageBox.Show("Actualización fallida", "Error", 0, MessageBoxIcon.Error);
            }
        }
        private void RegistroExitoso()
        {
            Limpiar();
            DisabledTextBox();
        }
        #endregion

        #region EliminarDoctor
        public void ControlEliminar()
        {
            int idElim = (int)dgvDoctores.CurrentRow.Cells["clmIDDoctor"].Value;
            string cn = dgvDoctores.CurrentRow.Cells["clmNomEm"].Value.ToString();
            string mn = "¿Desea eliminar al Doctor con ID: " + idElim + "?\n\nNombre: " + cn;
            MessageBoxButtons bn = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(mn, "Alerta", bn, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                contexto.EliminarDoctor(idElim);
                SetDataToDGVe();
            }
        }
        #endregion
        private void btnAgregarEm_Click(object sender, EventArgs e)
        {
            ControlInsertar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text != "")
            {

                DialogResult result = MessageBox.Show("¿Desea cancelar la operación?\nLos datos sin guardar se perderan", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Limpiar();
                    DisabledTextBox();
                }

            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PermitirActualizacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ControlEliminar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EdiOrCr == true)
            {
                Insertar();
            }
            else
            {
                actualizar();
                label5.Visible = false;
                txtContrasena.Visible = false;
            }
        }


    }
}
