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

        private void radMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem3_Click_1(object sender, EventArgs e)
        {
            GrupoEntidades Gentidades = new GrupoEntidades();
            Gentidades.Show();
        }

        private void radMenuItem4_Click_1(object sender, EventArgs e)
        {
            TiposEntidades Tentidades = new TiposEntidades();
            Tentidades.Show();
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            Entidades entidades = new Entidades();
            entidades.Show();
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
    }
}
