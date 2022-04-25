using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoEntidades.Data;
using ProyectoEntidades;

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
        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            if (DataGridViewEntidades.SelectedRows.Count > 0) 
            {
                agregar.label1.Text = "Modificar Entidad";
                Modificar = true;
                agregar.ShowDialog();
                this.Close();
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
    }
}