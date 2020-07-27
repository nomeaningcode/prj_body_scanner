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
using prjBodyScanner.Data.Repository;

namespace prjBodyScanner.Views.Dinamicas
{
    public partial class frmBResultados : Form
    {
        private IRepositoryBitacoraResultados contexto = new RepositoryBitacoraResultados();
        public frmBResultados()
        {
            InitializeComponent();
        }
        private void frmBResultados_Load(object sender, EventArgs e)
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

        #region Diseño responsivo

        private void ResizeDGVAction()
        {
            foreach (DataGridViewColumn _col in dgvResultado.Columns)
            {
                _col.Width = CTamaño();
            }
        }

        private int CTamaño()
        {
            int Tamano = this.dgvResultado.Width / this.dgvResultado.Columns.Count;

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
            this.SplitComtroles.SplitterDistance = this.Width;
        }


        #endregion

        #region Metodos de control

        private DialogResult Decision()
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

            int Conta = (int)dgvResultado.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (Conta > 1)
            {
                MessageBox.Show("Selecciona solo uno", "Alerta", 0, MessageBoxIcon.Information);
            }

            return Conta;

        }

        private void SeleccionarUltimoC()
        {
            this.dgvResultado.Rows[dgvResultado.Rows.Count - 1].Selected = true;
            this.dgvResultado.CurrentCell = dgvResultado.Rows[dgvResultado.Rows.Count - 1].Cells[0];
        }

        private void SeleccionarEditado()
        {
            this.dgvResultado.Rows[RowSeleccionada].Selected = true;
            this.dgvResultado.CurrentCell = dgvResultado.Rows[RowSeleccionada].Cells[0];
        }

        private int ControlVacio(string _accion)
        {

            int TotalS = dgvResultado.Rows.Count;

            if (TotalS == 0)
            {
                MessageBox.Show("No hay suficientes items para " + _accion, "Alerta", 0, MessageBoxIcon.Information);
            }

            return TotalS;
        }


        #endregion

        #region Data
        private void SetDataToDGVe()
        {

            this.dgvResultado.AutoGenerateColumns = false;
            this.dgvResultado.DataSource = contexto.GetBitacora();

            this.dgvResultado.Columns[0].DataPropertyName = "IDResultado";
            this.dgvResultado.Columns[1].DataPropertyName = "IDPacienteBD";
            this.dgvResultado.Columns[2].DataPropertyName = "IDDoctorBD";
            this.dgvResultado.Columns[3].DataPropertyName = "IDEnfermedadBD";
        }
        #endregion

        #region EliminarResultado
        public void ControlEliminar()
        {
            int idElim = (int)dgvResultado.CurrentRow.Cells["clmIDEscaneo"].Value;
            string mn = "¿Desea eliminar el Resultado con ID: " + idElim;
            MessageBoxButtons bn = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(mn, "Alerta", bn, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                contexto.EliminarBitacora(idElim);
                SetDataToDGVe();
            }
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ControlEliminar();
        }
    }
}
