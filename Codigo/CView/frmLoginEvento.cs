using System;
using System.Windows.Forms;
using CData.SQL;

namespace CView
{
    public partial class frmLoginEvento : Form
    {
        public frmLoginEvento()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Advertencia");
                return;
            }

            UserLoginValidator validador = new UserLoginValidator();
            bool loginValido = validador.ValidarUsuario(usuario, clave);

            if (loginValido)
            {
                // Abrir frmMenu y cerrar login
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.FormClosed += (s, args) => this.Close(); // Para cerrar todo al cerrar frmMenu
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
