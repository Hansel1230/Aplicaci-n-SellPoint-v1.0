using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace WindowsFormsAppSellPoint
{
    public partial class FormLogin : Form
    {
        #region Constructor
        public FormLogin()
        {
            InitializeComponent();
        }
        #endregion
        public static bool UserValid { get; set; } = false;

        #region Eventos
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Fultxt();
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            logins();
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
        #endregion
    }
}