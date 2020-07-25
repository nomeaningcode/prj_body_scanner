using prjBodyScanner.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBodyScanner.Views.Bases
{
    public partial class BaseMenu : Form
    {
        public BaseMenu()
        {
            InitializeComponent();
            lblInicio.ForeColor = System.Drawing.Color.MediumTurquoise;
        }

        #region Variables

        private Label ultimoVTexto = null;
        private Label nuevoVTexto = null;
        private bool comprueba = true;
        private bool ControlDeVentana = false;

        #endregion

        #region Control de eventos

        private void ControlFormsInvocados(Label myLabel)
        {

            if (comprueba == true)
            {
                nuevoVTexto = myLabel;
                ultimoVTexto = lblInicio;
                lblInicio.ForeColor = System.Drawing.Color.White;
                nuevoVTexto.ForeColor = System.Drawing.Color.MediumTurquoise;
                comprueba = false;
            }
            else
            {
                ultimoVTexto = nuevoVTexto;
                nuevoVTexto = myLabel;

                ultimoVTexto.ForeColor = System.Drawing.Color.White;
                nuevoVTexto.ForeColor = System.Drawing.Color.MediumTurquoise;
            }
        }


        #endregion

        #region Acciones botones menu

        private void lblInicio_Click(object sender, EventArgs e)
        {
            ControlPanel.DoctorPanel();
            ControlFormsInvocados(lblInicio);
        }

        private void lblEscaneo_Click(object sender, EventArgs e)
        {
            ControlPanel.EscaneoPanel();
            ControlFormsInvocados(lblEscaneo);
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {
            ControlPanel.PacientesPanel();
            ControlFormsInvocados(lblPacientes);
        }

        private void lbBitacoraRes_Click(object sender, EventArgs e)
        {
            ControlPanel.frmBTResultPanel();
            ControlFormsInvocados(lbBitacoraRes);
        }

        private void lblDoctores_Click(object sender, EventArgs e)
        {
            ControlPanel.DoctoresPanel();
            ControlFormsInvocados(lblDoctores);
        }
        #endregion

        #region Accion boton retorno - Adelante

        private void lblRetro_Click(object sender, EventArgs e)
        {
            switch (ultimoVTexto.Name)
            {
                case "lblInicio":
                    lblInicio_Click(sender,e);
                    break;
                case "lblEscaneo":
                    lblEscaneo_Click(sender, e);
                    break;
                case "lblDoctores":
                    lblDoctores_Click(sender, e);
                    break;
                case "lblPacientes":
                    lblPacientes_Click(sender, e);
                    break;
                case "lbBitacoraRes":
                    lbBitacoraRes_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        #endregion B Ad _ At

        #region Metodos de cierre

        private DialogResult CerrarS(bool control)
        {

            DialogResult respuesta = 0;

            if (UserLoginCache.AccionCerrar == false)
            {
                DialogResult result = MessageBox.Show("¿Desea cerrar la aplicación?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                respuesta = result;

                if (ControlDeVentana == false)
                {
                    CerrarDesdeLabel(result);
                }
                else
                {
                    CerrarDesdeFormClosing(result);
                }

            }
            return respuesta;
        }

        private void CerrarDesdeLabel(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                try
                {
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    string em = ex.Message;
                    MessageBox.Show("Error inesperado: \n" + em + "\n\nSe cerrara la aplicación");
                    Environment.Exit(1);
                }
            }
        }

        private void CerrarDesdeFormClosing(DialogResult result)
        {
            if (result != DialogResult.No)
            {
                try
                {
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    string em = ex.Message;
                    MessageBox.Show("Error inesperado: \n" + em + "\n\nSe cerrara la aplicación");
                    Environment.Exit(1);
                }
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CerrarS(ControlDeVentana);

        }

        private void BaseMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            ControlDeVentana = true;

            CerrarS(ControlDeVentana);
            e.Cancel = true;
        }

        #endregion
        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContrasenia cambiar = new CambiarContrasenia();
            cambiar.Show();
        }
    }
}
