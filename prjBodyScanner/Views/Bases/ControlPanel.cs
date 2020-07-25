using prjBodyScanner.Views.Dinamicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjBodyScanner.Views.Bases
{
    public partial class ControlPanel : prjBodyScanner.Views.Bases.BaseMenu
    {
        public ControlPanel()
        {
            InitializeComponent();
            DoctorPanel();
        }

        #region VariableInterfaces

        protected static Form newInterfaz = null;
        protected static Form oldInterfaz = null;

        public static frmConsulta frmConsulta = new frmConsulta();
        public static frmDoctor frmDoctor = new frmDoctor();
        public static frmDoctores frmDoctores = new frmDoctores();
        public static frmPacientes frmPacientes = new frmPacientes();
        public static frmBResultados frmBresultados = new frmBResultados();

        #endregion

        #region Metodos de pintado

        protected static void InvocarForm(Form invocado)
        {
            newInterfaz = invocado;
            newInterfaz.Size = new Size(pnlPrincipal.Size.Width, pnlPrincipal.Size.Height);
            newInterfaz.Top = 0;
            newInterfaz.Left = 0;
            newInterfaz.FormBorderStyle = FormBorderStyle.None;
            newInterfaz.TopLevel = false;
            pnlPrincipal.Controls.Add(newInterfaz);
            newInterfaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom)));
            newInterfaz.Show();
        }

        protected static void ControlForm(Form CyA)
        {

            if (oldInterfaz != null)
            {
                pnlPrincipal.Controls.Remove(oldInterfaz);
                oldInterfaz.Hide();
                InvocarForm(CyA);
            }
            else
            {
                InvocarForm(CyA);
            }

            oldInterfaz = newInterfaz;
            newInterfaz = null;
        }

        #endregion

        #region Metodos de control


        public static void DoctorPanel()
        {
            ControlForm(frmDoctor);
        }

        public static void EscaneoPanel()
        {
            ControlForm(frmConsulta);
        }

        public static void DoctoresPanel()
        {
            ControlForm(frmDoctores);
        }

        public static void PacientesPanel()
        {
            ControlForm(frmPacientes);
        }

        public static void frmBTResultPanel()
        {
            ControlForm(frmBresultados);
        }

        #endregion
    }
}
