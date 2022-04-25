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
        clsBeEntidades beEntidades = new clsBeEntidades();  
        clsLnEntidades daEntidades = new clsLnEntidades();  

        public Entidades()
        {
            InitializeComponent();
        }
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
            agregar.ShowDialog(); 
        }
        #endregion

        #region Metodos
        public void CargarData() 
        {
            var data = new clsLnEntidades();
            DataGridViewEntidades.DataSource = data.Listar();
        }   
        #endregion

        private Agregar add2;
        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            if (add2 == null)
            {
                add2 = new Agregar();
                add2.FormClosed += (o, args) => add2 = null;
            }
            add2.Show();
            add2.BringToFront();
            add2.TextBoxDescripcion.Text = DataGridViewEntidades.CurrentRow.Cells[0].Value.ToString();
            add2.

        }
    }
}