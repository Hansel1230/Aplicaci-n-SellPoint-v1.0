using System;
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

        private void radMenuItem3_Click_1(object sender, EventArgs e)
        {
            GrupoEntidades Gentidades = new GrupoEntidades();
            Gentidades.label1.Text = "Grupo Entidades";
            Gentidades.Show();
        }

        private void radMenuItem4_Click_1(object sender, EventArgs e)
        {
            GrupoEntidades Gentidades = new GrupoEntidades();
            Gentidades.label1.Text = "Tipo Entidades";
            Gentidades.Show();
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            GrupoEntidades Gentidades = new GrupoEntidades();
            Gentidades.label1.Text = "Entidades";
            Gentidades.Show();
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
            this.Close();        }
    }
}
