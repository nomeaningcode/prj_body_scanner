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

using prjBodyScanner.Data.Modelo;
using prjBodyScanner.Data.Infraetructura;
using prjBodyScanner.Data.Repository;
using System.Diagnostics;
using prjBodyScanner.Cache;

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

        #region Bitacora
        private void InsertarEnBitacora(int _id)
        {

            IRepositorioDoctorUs repositoryBitacora = new RepositorioDoctorUs();
            BitacoraBD bitacoraBD = new BitacoraBD();

            string Dia = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();

            bitacoraBD.IDDorctorBD = _id;
            bitacoraBD.FechaBD = Dia;
            bitacoraBD.HoraBD = hora;
            bitacoraBD.NombreDocBD = UserLoginCache.Nombre + "  " + UserLoginCache.ApellidoP;
            bitacoraBD.EquipoBD = GetUserName();

            repositoryBitacora.InsertarRegistro(bitacoraBD);
        }

        #endregion

        #region Metodos de acceso

        private void CompararContrasenia()
        {

            if (txtUser.Text != "")
            {

                if (txtPassword.Text != "")
                {
                    AccederSistema();
                }
                else
                {
                    lblError.Text = "Ingrese la contraseña";
                }

            }
            else
            {
                lblError.Text = "Ingrese la matrícula de usuario";
            }

        }
        private void AccederSistema()
        {
            IRepositorioDoctorUs dusconn = new RepositorioDoctorUs();

            DoctorBD objDoctor = dusconn.GetDoctorByMatricula(txtUser.Text);

            if (objDoctor != null)
            {
                if (txtPassword.Text.Equals(objDoctor.ContraseniaBD)) {

                    ControlPanel frmP = new ControlPanel();
                    CreateCacheEmpleado(objDoctor);
                    InsertarEnBitacora(objDoctor.IDDoctor);

                    frmP.Show();
                    this.Hide();

                }
                else
                {
                    lblError.Text = "La contraseña es incorrecta";
                }
            }
            else
            {
                lblError.Text = "La matrícula no existe dentro del sistema";
            }

        }

        #endregion

        #region Cache (?
        private String GetUserName() {

            string eud = Environment.UserName.ToString();

            return eud;

        }

        private void CreateCacheEmpleado(DoctorBD _doc)
        {
            UserLoginCache.IIDoctor = _doc.IDDoctor;
            UserLoginCache.Matricula = _doc.Matricula;
            UserLoginCache.Nombre = _doc.NombreEBD;
            UserLoginCache.ApellidoP = _doc.APaternoBD;
            UserLoginCache.ApellidoM = _doc.AMarteno;
            UserLoginCache.Telefono = _doc.TelefonoEBD;
            UserLoginCache.Correo = _doc.CorreoEBD;
            UserLoginCache.AccionCerrar = false;
        }

        #endregion 

        #region eventos de la interfaz

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
            CompararContrasenia();
        }

        #endregion

    }
}
