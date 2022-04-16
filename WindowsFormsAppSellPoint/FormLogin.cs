using System;
using System.Windows.Forms;


namespace WindowsFormsAppSellPoint
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Fultxt();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Metodos

        public void Fultxt()
        {
            textBoxUsuario.Text = "Ingrese usuario";
            textBoxContrasena.Text = "Ingrese Contraseña";
        }

        #endregion
        #region Eventos
        private void textBoxUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Ingrese usuario")
            {
                 textBoxUsuario.Text = "";
            }
        }
        #endregion

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "Ingrese usuario";
            }
        }
        private void textBoxContrasena_Click(object sender, EventArgs e)
        {
            if (textBoxContrasena.Text == "Ingrese Contraseña")
            {
                textBoxContrasena.Text = "";
            }
        }

        private void textBoxContrasena_Leave(object sender, EventArgs e)
        {
            if (textBoxContrasena.Text == "")
            {
                textBoxContrasena.Text = "Ingrese Contraseña";
            }
        }
    }
}
