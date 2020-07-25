using prjBodyScanner.Clases;
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
    public partial class frmDoctores : Form
    {
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
                MessageBox.Show("El empleado debe de poseer nombre", "Alerta", 0, MessageBoxIcon.Warning);
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
                    bool Confirma = true;
                    //bool Confirma = contexto.InsertEmpleado(CreateObjectEmpleado());

                    if (Confirma == true)
                    {
                        MessageBox.Show("Registro exitoso", "Operación finalizada", 0, MessageBoxIcon.Information);
                        //SetDataToDGVe();
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

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
