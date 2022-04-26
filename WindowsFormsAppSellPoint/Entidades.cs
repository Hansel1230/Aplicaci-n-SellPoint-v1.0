using ProyectoEntidades;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppSellPoint
{
    public partial class Entidades : Form
    {
        #region propiedades
        public bool Modificar { get; set; } = false;
        #endregion

        #region Referencias
        clsBeEntidades beEntidades = new clsBeEntidades();  
        clsLnEntidades daEntidades = new clsLnEntidades();
        #endregion

        #region Costructor
        public Entidades()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void Entidades_Load(object sender, EventArgs e)
        {
            CargarData();
        }
        private Agregar add;
        private void radButton1_Click(object sender, EventArgs e)
        {
            if (add == null)
            {
                add = new Agregar();
                add.FormClosed += (o, args) => add = null;
            }
            //add.Show();
            add.BringToFront();
        }
        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            this.Close();
            agregar.ShowDialog();

        }
        private Agregar add2;
        private void ButtonModificar_Click(object sender, EventArgs e)
        {

            if (DataGridViewEntidades.SelectedRows.Count > 0)
            {
                if (add2 == null)
                {
                    add2 = new Agregar();
                    add2.FormClosed += (o, args) => add2 = null;
                    add2.Show();
                    add2.BringToFront();
                    add2.TextBoxDescripcion.Text = DataGridViewEntidades.CurrentRow.Cells[0].Value.ToString();
                    add2.TextBoxDireccion.Text = DataGridViewEntidades.CurrentRow.Cells[1].Value.ToString();
                    add2.TextBoxLocalidad.Text = DataGridViewEntidades.CurrentRow.Cells[2].Value.ToString();
                    add2.comboBoxTipoEntidad.Text = DataGridViewEntidades.CurrentRow.Cells[3].Value.ToString();
                    add2.comboBoxTipoDoc.Text = DataGridViewEntidades.CurrentRow.Cells[4].Value.ToString();
                    add2.TextBoxNoDoc.Text = DataGridViewEntidades.CurrentRow.Cells[5].Value.ToString();
                    add2.TextBoxTelefono.Text = DataGridViewEntidades.CurrentRow.Cells[6].Value.ToString();
                    add2.TextBoxURL_Web.Text = DataGridViewEntidades.CurrentRow.Cells[7].Value.ToString();
                    add2.TextBoxURL_face.Text = DataGridViewEntidades.CurrentRow.Cells[8].Value.ToString();
                    add2.TextBoxURL_Istagram.Text = DataGridViewEntidades.CurrentRow.Cells[9].Value.ToString();
                    add2.TextBoxURL_Twiter.Text = DataGridViewEntidades.CurrentRow.Cells[10].Value.ToString();
                    add2.TextBoxURL_Tiktok.Text = DataGridViewEntidades.CurrentRow.Cells[11].Value.ToString();
                    add2.TextBoxLimiteCredito.Text = DataGridViewEntidades.CurrentRow.Cells[12].Value.ToString();
                    add2.TextBoxNombreUsuario.Text = DataGridViewEntidades.CurrentRow.Cells[13].Value.ToString();
                    add2.TextBoxContrasena.Text = DataGridViewEntidades.CurrentRow.Cells[14].Value.ToString();
                    add2.comboBoxRolUsuario.Text = DataGridViewEntidades.CurrentRow.Cells[15].Value.ToString();
                    add2.TextEditorComentario.Text = DataGridViewEntidades.CurrentRow.Cells[16].Value.ToString();
                    add2.comboBoxEstatus.Text = DataGridViewEntidades.CurrentRow.Cells[17].Value.ToString();
                    add2.comboBoxEliminable.Text = DataGridViewEntidades.CurrentRow.Cells[18].Value.ToString();
                    //add2.TextBoxDireccion.Text = DataGridViewEntidades.CurrentRow.Cells[19].Value.ToString();
                    //add2.TextBoxDireccion.Text = DataGridViewEntidades.CurrentRow.Cells[20].Value.ToString();
                    //add2.TextBoxDireccion.Text = DataGridViewEntidades.CurrentRow.Cells[21].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila!!");
            }
        }
        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (DataGridViewEntidades.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Esta seguro de eliminar la entidad?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    beEntidades.IdEntidad= Convert.ToInt32(DataGridViewEntidades.CurrentRow.Cells[0].ToString());
                    daEntidades.Eliminar(ref beEntidades);
                    MessageBox.Show("Entidad eliminada de manera exitosa");
                    CargarData();
                }
            }else 
            {
                MessageBox.Show("Debe seleccionar una fila!!");
            }
        }
        #endregion

        #region Metodos
        public void CargarData()
        {
            var data = new clsLnEntidades();
            DataGridViewEntidades.DataSource = data.Listar();
            DataGridViewEntidades.ClearSelection();

        }

        #endregion
        public void ObtenerEntidad(String IdEntidad)
        {
            beEntidades.IdEntidad = Convert.ToInt32(IdEntidad);
            DataGridViewEntidades.DataSource = daEntidades.ObtenerEntidad(ref beEntidades);
        }

        private void TextBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxBuscar.Text != "")
            {
                ObtenerEntidad(TextBoxBuscar.Text);
            }
            else
            {
                CargarData();
            }
        }

        private void TextBoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}