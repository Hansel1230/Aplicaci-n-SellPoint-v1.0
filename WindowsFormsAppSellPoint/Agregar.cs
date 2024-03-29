﻿using ProyectoEntidades;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppSellPoint
{
    public partial class Agregar : Form
    {
        public bool isValid { get; set; } = true;
        public bool numValid { get; set; } = true;

        clsBeEntidades beEntidades = new clsBeEntidades();
        Entidades entidades = new Entidades();
        clsLnEntidades daEntidades = new clsLnEntidades();
        public Agregar()
        {
            InitializeComponent();
        }
        #region Metodos
        public void FullCombobox()
        {
            comboBoxTipoEntidad.SelectedItem = 0;
            comboBoxTipoDoc.SelectedIndex = 0;
            comboBoxRolUsuario.SelectedIndex = 0;
            comboBoxEstatus.SelectedIndex = 0;
            comboBoxEliminable.SelectedIndex = 1;
        }
        public void AddValid()
        {
            if (comboBoxTipoEntidad.SelectedItem == null)
            {
                isValid = false;
                MessageBox.Show("Debe seleccinar un tipo de entidad!!");
            }
            else if (TextBoxNoDoc.Text == "")
            {
                isValid = false;
                MessageBox.Show("Debe ingresar un Numero de documento!!");
            }
            else if (TextBoxTelefono.Text == "")
            {
                isValid = false;
                MessageBox.Show("Debe ingresar un Numero de telefono!!");
            }
            else if (TextBoxNombreUsuario.Text == "")
            {
                isValid = false;
                MessageBox.Show("Debe ingresar un nombre de usuario!!");
            }
            else if (TextBoxContrasena.Text == "")
            {
                isValid = false;
                MessageBox.Show("Debe ingresar una contraseña!!");
            }
            else if (comboBoxRolUsuario.SelectedItem == null)
            {
                isValid = false;
                MessageBox.Show("Debe seleccinar un rol!!");
            }
            else if (comboBoxEstatus.SelectedItem == null)
            {
                isValid = false;
                MessageBox.Show("Debe seleccinar un status!!");
            }
            else if (comboBoxEliminable.SelectedItem == null)
            {
                isValid = false;
                MessageBox.Show("Debe seleccinar si es eliminable o no!!");
            }
            else { isValid = true; }
        }
        public void insertar()
        {

            try
            {
                beEntidades.NumeroDocumento = Convert.ToInt32(TextBoxNoDoc.Text);
                beEntidades.Teléfonos = Convert.ToString(TextBoxTelefono.Text);
                beEntidades.LimiteCredito = Convert.ToInt32(TextBoxLimiteCredito.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insertar solo numeros por favor");
            }
            beEntidades.TipoEntidad = Convert.ToString(comboBoxTipoEntidad.SelectedItem);

            beEntidades.TipoDocumento = Convert.ToString(comboBoxTipoDoc.SelectedItem);
            beEntidades.UserNameEntidad = Convert.ToString(TextBoxNombreUsuario.Text);
            beEntidades.PassworEntidad = Convert.ToString(TextBoxContrasena.Text);
            beEntidades.RolUserEntidad = Convert.ToString(comboBoxRolUsuario.SelectedItem);
            beEntidades.Statuss = Convert.ToString(comboBoxEstatus.SelectedItem);
            if (comboBoxEliminable.SelectedIndex == 0)
            {
                beEntidades.NoEliminable = true;
            }
            else
            {
                beEntidades.NoEliminable = false;
            }
            beEntidades.Descripcion = Convert.ToString(TextBoxNoDoc.Text);
            beEntidades.Direccion = Convert.ToString(TextBoxDireccion.Text);
            beEntidades.Localidad = Convert.ToString(TextBoxLocalidad.Text);
            beEntidades.URLPaginaWeb = Convert.ToString(TextBoxURL_Web.Text);
            beEntidades.URLFacebook = Convert.ToString(TextBoxURL_face.Text);
            beEntidades.URLInstagram = Convert.ToString(TextBoxURL_Istagram.Text);
            beEntidades.URLTwitter = Convert.ToString(TextBoxURL_Twiter.Text);
            beEntidades.URLTikTok = Convert.ToString(TextBoxURL_Tiktok.Text);
            beEntidades.Comentario = Convert.ToString(TextEditorComentario.Text);
            daEntidades.Insertar(ref beEntidades);
            MessageBox.Show("Entidad Guardada con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void VaciarData()
        {
            comboBoxTipoEntidad.SelectedItem = null;
            comboBoxTipoDoc.SelectedItem = null;
            comboBoxRolUsuario.SelectedItem = null;
            comboBoxEstatus.SelectedItem = null;
            comboBoxEliminable.SelectedItem = null;

            TextBoxContrasena.Text = "";
            TextBoxDescripcion.Text = "";
            TextBoxDireccion.Text = "";
            TextBoxLimiteCredito.Text = "";
            TextBoxLocalidad.Text = "";
            TextBoxNoDoc.Text = "";
            TextBoxNombreUsuario.Text = "";
            TextBoxTelefono.Text = "";
            TextBoxURL_face.Text = "";
            TextBoxURL_Istagram.Text = "";
            TextBoxURL_Tiktok.Text = "";
            TextBoxURL_Twiter.Text = "";
            TextBoxURL_Web.Text = "";
        }
        #endregion

        #region Eventos
        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            AddValid();
            if (isValid == true)
            {
                if (entidades.Modificar == true)
                {

                }
                else
                {
                    insertar();
                    this.Close();
                    entidades.CargarData();
                    VaciarData();
                    entidades.labelEntidades.Text = "Entidades";
                    entidades.Show();
                }
            }
        }
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            VaciarData();
            entidades.Show();
            this.Close();
        }

        #endregion

        private void TextBoxNoDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TextBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TextBoxLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
