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
    public partial class CambiarContrasenia : Form
    {
        public CambiarContrasenia()
        {
            InitializeComponent();
        }
        private string Contrasenia = "";
        private void GetData()
        {/*
            txtIDConf.Text = UserLoginCache.IdUser.ToString();
            int idE = UserLoginCache.IdUser;
            EmpleadoBD empleado = contexto.ReturnEmpleadoByID(idE);
            txtNombre.Text = empleado.NombreEBD;
            Contrasenia = empleado.ContraseniaBD;*/

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasenia.Text != "")
            {
                if (txtContrasenia.Text == Contrasenia)
                {
                    txtNeC.Enabled = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNeC.Text != "")
            {

                txtCC.Enabled = true;

                MetodoComparacion();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtCC.Text != "")
            {
                MetodoComparacion();
            }
        }

        private void MetodoComparacion()
        {
            if (txtCC.Text == txtNeC.Text)
            {
                btnGuardar.Enabled = true;
                btnGuardar.BackColor = Color.Lime;
                btnGuardar.FlatAppearance.BorderColor = Color.LimeGreen;
            }
            else
            {
                btnGuardar.Enabled = false;
                btnGuardar.BackColor = Color.DarkGray;
                btnGuardar.FlatAppearance.BorderColor = Color.Gray;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }
    }
}
