using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using prjBodyScanner.Views.Bases;

namespace prjBodyScanner.Seguridad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region Movilidad Panel

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsgm, int wparam, int lparam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            AccederSistema();
        }

        private void AccederSistema() {

            ControlPanel frmP = new ControlPanel();
            frmP.Show();
            this.Hide();

        }

    }
}
