using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsAppSellPoint
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private GrupoEntidades frm;
        private void radMenuItem3_Click_1(object sender, EventArgs e)
        {
            if (frm == null)
            {
                frm = new GrupoEntidades();
                frm.FormClosed += (o, args) => frm = null;
            }
            //Codigo para agregar el formulario en el mismo formulario.
            //frm.TopLevel = false;
            //panel1.Controls.Add(frm);
            frm.Show();
            frm.label1.Text = "Grupo Entidades";
            frm.BringToFront();

        }

        private Entidades frm2;
        private void radMenuItem4_Click_1(object sender, EventArgs e)
        {
            if (frm2 == null)
            {
                frm2 = new Entidades();
                frm2.FormClosed += (o, args) => frm2 = null;
            }
            //Codigo para agregar el formulario en el mismo formulario.

            frm2.Show();
            frm2.label1.Text = "Entidades";
            frm2.BringToFront();
        }

        private TiposEntidades frm3;
        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            if (frm3 == null)
            {
                frm3 = new TiposEntidades();
                frm3.FormClosed += (o, args) => frm3 = null;
            }
            //Codigo para agregar el formulario en el mismo formulario.

            frm3.Show();
            frm3.label1.Text = "Entidades";
            frm3.BringToFront();
        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void radMenuItem6_Click(object sender, EventArgs e)
        {
            FormAcercaDe formAcercaDe = new FormAcercaDe();
            formAcercaDe.Show();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToLongTimeString();
            statusBar1.Panels[1].Text = DateTime.Now.ToLongDateString();
        }

        private void radMenuItem8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            //statusBar1.Panels[2].Text = 
        }

        private void RegistroBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
