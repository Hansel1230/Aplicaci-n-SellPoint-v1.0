using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;

namespace WindowsFormsAppSellPoint
{
    public partial class FormLogin : Form
    {
        #region Constructor
        public FormLogin()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();

            Thread.Sleep(6800);

            InitializeComponent();

            t.Abort();
        }
        #endregion

        #region Propiedades
        public static bool UserValid { get; set; } = false;
        public static string UserName { get; set; } 
        #endregion

        #region Eventos
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Fultxt();
            if (textBoxContrasena.Text != "Ingrese Contraseña")
            {
                textBoxContrasena.PasswordChar = '*';
            }
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Ingrese usuario" || textBoxContrasena.Text == "Ingrese Contraseña")
            {
                MessageBox.Show("Ingrese usuario y Contraseña.");
            }
            else
            {
                logins();
            }
            
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Ingrese usuario")
            {
                textBoxUsuario.Text = "";
            }
        }
        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "Ingrese usuario";
            }
        }
        private void textBoxContrasena_Click(object sender, EventArgs e)
        {
            
        }
        private void textBoxContrasena_Leave(object sender, EventArgs e)
        {
            if (textBoxContrasena.Text == "")
            {
                textBoxContrasena.PasswordChar = '\0';
                textBoxContrasena.Text = "Ingrese Contraseña";
            }
        }
        private void textBoxContrasena_Enter(object sender, EventArgs e)
        {
            if (textBoxContrasena.Text == "Ingrese Contraseña")
            {
                textBoxContrasena.Text = "";
                textBoxContrasena.PasswordChar = '*';
            }

        }
        private void pictureBoxMostrar_Click(object sender, EventArgs e)
        {
            //Imagen ocultar la mostramos
            pictureBoxOcultar.BringToFront();
            //Mostramos la contrasena
            textBoxContrasena.PasswordChar = '\0';
        }

        private void pictureBoxOcultar_Click(object sender, EventArgs e)
        {
            //Imagen mostrar la mostramos
            pictureBoxMostrar.BringToFront();
            //Ocultamos la contrasena
            if (textBoxContrasena.Text != "Ingrese Contraseña")
            {
                textBoxContrasena.PasswordChar = '*';
            }
        }
        #endregion

        #region Metodos
        public void Fultxt()
        {
            textBoxUsuario.Text = "Ingrese usuario";
            textBoxContrasena.Text = "Ingrese Contraseña";
        }
        public void logins()
        {
            try
            {
                string DBConnection = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(DBConnection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT UserNameEntidad, PassworEntidad FROM Entidades WHERE UserNameEntidad='" + textBoxUsuario.Text + "' AND PassworEntidad='" + textBoxContrasena.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login exitoso.");
                            UserName = textBoxUsuario.Text;
                            UserValid= true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                        }
                        dr.Close();
                        dr.Dispose();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void SplashStart() 
        {
            Application.Run(new FormSplash());
        }
        #endregion
    }
}