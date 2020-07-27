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
    public partial class frmPacientes : Form
    {
        private IRepositoryPaciente contexto = new RepositoryPaciente();
        public frmPacientes()
        {
            InitializeComponent();
        }
        private void frmPacientes_Load(object sender, EventArgs e)
        {
            InicializadorCustom();
        }
        private void InicializadorCustom()
        {
            ResizeDGVAction();
            SetDataToDGVe();
            DisabledTextBox();
            ddlListarTipossangre();
            ddlListarSexo();
            ddlListarOcupaciones();
        }
        private int RowSeleccionada = 0;
        private bool EdiOrCr = false;

        #region Diseño responsivo

        private void ResizeDGVAction()
        {
            foreach (DataGridViewColumn _col in dgvPacientes.Columns)
            {
                _col.Width = CTamaño() * 2;
            }

        }

        private int CTamaño()
        {
            int Tamano = this.dgvPacientes.Width / this.dgvPacientes.Columns.Count;

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

            this.txtNombre.Enabled = this.txtApaterno.Enabled = this.txtAmaterno.Enabled = this.txttelefono.Enabled = this.txtCorreo.Enabled = this.txtEdad.Enabled = this.btnGuardar.Enabled = false;

            this.btnGuardar.BackColor = Color.PaleGreen;
            this.SplitComtroles.SplitterDistance = this.Width;
            this.SplitEdicionP.Visible = false;
        }

        private void EnabledTextBox()
        {

            this.txtNombre.Enabled = true;
            this.txtApaterno.Enabled = true;
            this.txtAmaterno.Enabled = true;
            this.txttelefono.Enabled = true;
            this.txtCorreo.Enabled = true;
            this.btnGuardar.Enabled = true;
            this.txtEdad.Enabled = true;

            this.btnGuardar.BackColor = Color.Lime;
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
            this.txtEdad.Clear();

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

            int Conta = (int)dgvPacientes.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (Conta > 1)
            {
                MessageBox.Show("Selecciona solo uno", "Alerta", 0, MessageBoxIcon.Information);
            }

            return Conta;

        }

        private void SeleccionarUltimoC()
        {
            this.dgvPacientes.Rows[dgvPacientes.Rows.Count - 1].Selected = true;
            this.dgvPacientes.CurrentCell = dgvPacientes.Rows[dgvPacientes.Rows.Count - 1].Cells[0];
        }

        private void SeleccionarEditado()
        {
            this.dgvPacientes.Rows[RowSeleccionada].Selected = true;
            this.dgvPacientes.CurrentCell = dgvPacientes.Rows[RowSeleccionada].Cells[0];
        }

        private int ControlVacio(string _accion)
        {

            int TotalS = dgvPacientes.Rows.Count;

            if (TotalS == 0)
            {
                MessageBox.Show("No hay suficientes items para " + _accion, "Alerta", 0, MessageBoxIcon.Information);
            }

            return TotalS;
        }


        #endregion

        #region Metodos Insertar

        private void ControlInsertar()
        {
            if (txtID.Text == "")
            {
                EdiOrCr = true;
                EnabledTextBox();
            }
            else
            {
                if (Desicion() == DialogResult.Yes)
                {
                    Limpiar();
                    EdiOrCr = true;
                    EnabledTextBox();
                }
            }
        }





        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ControlEliminar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PermitirActualizacion();
        }

        private void btnAgregarEm_Click(object sender, EventArgs e)
        {
            ControlInsertar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Desea cancelar la operación?\nLos datos sin guardar se perderan", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Limpiar();
                DisabledTextBox();
            }


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EdiOrCr == true)
            {
                InsertarPaciente();
            }
            else
            {
                actualizar();
            }
        }

        #region MetodosControladores

        private IRepositoryList repository = new RepositoryList();
        public void ddlListarTipossangre()
        {

            this.ddlTipoSangre.DataSource = repository.GetTipoSangre();
            this.ddlTipoSangre.DisplayMember = "NomTipoSangre";
            this.ddlTipoSangre.ValueMember = "IDTipoSangre";
            if (repository.GetTipoSangre().Count > 0)
            {
                this.ddlTipoSangre.SelectedIndex = 0;
            }
        }
        public void ddlListarSexo()
        {

            this.ddlSexo.DataSource = repository.GetSexo();
            this.ddlSexo.DisplayMember = "NomSexo";
            this.ddlSexo.ValueMember = "IDSexo";
            if (repository.GetSexo().Count > 0)
            {
                this.ddlSexo.SelectedIndex = 0;
            }
        }
        public void ddlListarOcupaciones()
        {

            this.ddlOcupacion.DataSource = repository.GetOcupacion();
            this.ddlOcupacion.DisplayMember = "NomOcuBD";
            this.ddlOcupacion.ValueMember = "IDOcupBD";
            if (repository.GetOcupacion().Count > 0)
            {
                this.ddlOcupacion.SelectedIndex = 0;
            }
        }

        #endregion

        #region InsertarPacientes
        private PacientesBD GetDataFromTextBox(PacientesBD _pac)
        {

            _pac.NombPCBD = txtNombre.Text;
            _pac.APaterBD = txtApaterno.Text;
            _pac.AMaterBD = txtAmaterno.Text;
            _pac.TelPCBD = txttelefono.Text;
            _pac.CorreoPCBD = txtCorreo.Text;
            _pac.EdadBD = int.Parse(txtEdad.Text);
            _pac.IDOcupBD = int.Parse(ddlOcupacion.SelectedValue.ToString());
            _pac.IDSexo = int.Parse(ddlSexo.SelectedValue.ToString());
            _pac.IDTipoSangre = int.Parse(ddlTipoSangre.SelectedValue.ToString());
            return _pac;

        }

        private PacientesBD CreateObjectPacientes()
        {

            PacientesBD pacientes = new PacientesBD();
            PacientesBD Retornable = null;

            if (EdiOrCr == true)
            {
                Retornable = GetDataFromTextBox(pacientes);
            }
            else
            {
                int idE = int.Parse(txtID.Text);
                Retornable = GetDataFromTextBox(pacientes);
                Retornable.IDPacienteBD = idE;
            }

            return Retornable;
        }

        private void InsertarPaciente()
        {
            bool Confirma = contexto.InsertarPaciente(CreateObjectPacientes());

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

        #endregion

        #region Data
        private void SetDataToDGVe()
        {

            this.dgvPacientes.AutoGenerateColumns = false;
            this.dgvPacientes.DataSource = contexto.GetPacientes();

            this.dgvPacientes.Columns[0].DataPropertyName = "IDPacienteBD";
            this.dgvPacientes.Columns[1].DataPropertyName = "NombPCBD";
            this.dgvPacientes.Columns[2].DataPropertyName = "APaterBD";
            this.dgvPacientes.Columns[3].DataPropertyName = "AMaterBD";
            this.dgvPacientes.Columns[4].DataPropertyName = "EdadBD";
            this.dgvPacientes.Columns[5].DataPropertyName = "IDTipoSangre";
            this.dgvPacientes.Columns[6].DataPropertyName = "TelPCBD";
            this.dgvPacientes.Columns[7].DataPropertyName = "CorreoPCBD";
            this.dgvPacientes.Columns[8].DataPropertyName = "IDSexo";
            this.dgvPacientes.Columns[9].DataPropertyName = "IDOcupBD";
        }
        #endregion

        #region ActualizarPacientes
        private void SetDataToTextBox()
        {
            int IdA = (int)dgvPacientes.CurrentRow.Cells[0].Value;
            PacientesBD paciente = contexto.GetPacienteById(IdA);

            txtID.Text = paciente.IDPacienteBD.ToString();
            txtNombre.Text = paciente.NombPCBD;
            txttelefono.Text = paciente.TelPCBD;
            txtCorreo.Text = paciente.CorreoPCBD;
            txtAmaterno.Text = paciente.AMaterBD;
            txtApaterno.Text = paciente.APaterBD;
            txtEdad.Text = paciente.EdadBD.ToString();
            ddlSexo.SelectedValue = paciente.IDSexo;
            ddlTipoSangre.SelectedValue = paciente.IDTipoSangre;
            ddlOcupacion.SelectedValue = paciente.IDOcupBD;

        }
        private void PermitirActualizacion()
        {

            if (txtID.Text == "")
            {

                RowSeleccionada = (int)dgvPacientes.CurrentCell.RowIndex;
                EdiOrCr = false;
                SetDataToTextBox();
                EnabledTextBox();
            }
            else
            {
                if (Desicion() == DialogResult.Yes)
                {

                    RowSeleccionada = (int)dgvPacientes.CurrentCell.RowIndex;
                    EdiOrCr = false;
                    SetDataToTextBox();
                    EnabledTextBox();
                }
            }
        }
        private void dgvPacientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPacientes.CurrentRow.Index >= 0 && dgvPacientes.CurrentCell.ColumnIndex >= 0)
            {
                PermitirActualizacion();
            }
        }

        public void actualizar()
        {
            bool Confirma = contexto.ActualizarPaciente(CreateObjectPacientes());

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

        #region EliminarPaciente
        public void ControlEliminar()
        {
            int idElim = (int)dgvPacientes.CurrentRow.Cells["clmIDEmpleado"].Value;
            string cn = dgvPacientes.CurrentRow.Cells["clmNomPac"].Value.ToString();
            string mn = "¿Desea eliminar al Paciente con ID: " + idElim + "?\n\nNombre: " + cn;
            MessageBoxButtons bn = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(mn, "Alerta", bn, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                contexto.EliminarPaciente(idElim);
                SetDataToDGVe();
            }
        }
        #endregion

        private void dgvPacientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ControlEliminar();
                e.Handled = true;
            }
        }
    }
}
