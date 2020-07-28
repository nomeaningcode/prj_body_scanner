using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using prjBodyScanner.Data.Infraestructura;
using prjBodyScanner.Data.Modelo;
using prjBodyScanner.Data.Repository;
using prjBodyScanner.Clases;
using prjBodyScanner.Cache;

namespace prjBodyScanner.Views.Dinamicas
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }
        #region Metodos de inicio

        private IRepositoryResultado resultado = new RepositoryResultado();
        private int idenfermedad = 0;
        private void frmConsulta_Load(object sender, EventArgs e)
        {
            InicializarCustom();
        }

        private void InicializarCustom()
        {
            RenderGrid();
            insertDatos();
            StatMaquina();
            PaintDocD();
        }

        private void RenderGrid()
        {
            this.dgvBitacora.Columns[1].Width = this.dgvBitacora.Width;
        }
        #endregion

        #region Random
        public void GenerarNumerosRandom()
        {
            //Variables y Objetos

            Random numero = new Random();
            idenfermedad = numero.Next(1, 19);
            int pulsaciones = numero.Next(60, 104);
            int SIS = numero.Next(105, 160);
            int DIA = numero.Next(60, 100);
            int Azucar = numero.Next(60, 360);
            //Creacion de Cadenas
            string ritmocadiaco = pulsaciones.ToString() + " " + "Pulsaciones x Minuto";
            string presionSistolica = SIS.ToString();
            string presionDiastolica = DIA.ToString();
            string glucosa = Azucar.ToString();
            //Envio de Datos a los texbox y grid
            txtDIA.Text = presionDiastolica;
            txtSis.Text = presionSistolica;
            txtRitcar.Text = ritmocadiaco;
            txtGlucosa.Text = glucosa;
            setGridView(idenfermedad);
        }
        public void setGridView(int _id)
        {
            this.dgvBitacora.AutoGenerateColumns = false;
            EnfermedadesBD enfermedades = resultado.GetEnfermedadById(_id);
            this.dgvBitacora.Rows.Add(enfermedades.IDEnfermedadBD, enfermedades.NomEnfermedad);


        }
        #endregion

        #region Llenado de datos

        private void insertDatos() {

            GenerarPassword _mat = new GenerarPassword();
            txtIdBodS.Text = _mat.GetNewPassword();
            this.btnEscanear.Enabled = false;
        }
        private void StatMaquina() {

            this.cmbEstado.Items.Insert(0,"Seleccionar");
            this.cmbEstado.Items.Insert(1,"Encender");
            this.cmbEstado.Items.Insert(2,"Suspender");

            this.cmbEstado.SelectedIndex = 0;
            ChangeStatBtn(false, Color.DarkGray);

        }
        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int estc = this.cmbEstado.SelectedIndex;

            switch (estc)
            {
                case 0:
                    MessageBox.Show("Seleccione una opción valida");
                    ChangeStatBtn(false, Color.DarkGray);
                    break;
                case 1:
                    ChangeStatBtn(true, Color.GreenYellow);
                    break;
                case 2:
                    ChangeStatBtn(false, Color.DarkGray);
                    break;
            }
        }

        private void ChangeStatBtn(bool _est, Color _bcb) {

            this.btnEscanear.Enabled = _est;
            this.btnEscanear.BackColor = _bcb;
        }

        #endregion

        #region Datos doc
        private void PaintDocD()
        {
            this.txtMatMedico.Text = UserLoginCache.Matricula;
        }

        #endregion

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            GenerarNumerosRandom();
        }

    }
}
