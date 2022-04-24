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

        private GrupoEntidades frm1;
        private void radMenuItem3_Click_1(object sender, EventArgs e)
        {
            if (frm1 == null)
            {
                frm1 = new GrupoEntidades();
                frm1.FormClosed += (o, args) => frm1 = null;
            }
            frm1.Show();
            frm1.label1.Text = "Grupo Entidades";
            frm1.BringToFront();
        }

        private TiposEntidades frm2;
        private void radMenuItem4_Click_1(object sender, EventArgs e)
        {
            if (frm2 == null)
            {
                frm2 = new TiposEntidades();
                frm2.FormClosed += (o, args) => frm3 = null;
            }
            frm2.Show();
            frm2.label1.Text = "Tipos Entidades";
            frm2.BringToFront();
        }

        private Entidades frm3;
        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            if (frm3 == null)
            {
                frm3 = new Entidades();
                frm3.FormClosed += (o, args) => frm3 = null;
            }
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
            statusBar1.Panels[2].Text = FormLogin.UserName;
            //StatusBarPanel userPanel = new StatusBarPanel();
            //userPanel.Text = FormLogin.UserName;
            //statusBar1.Panels.Add(userPanel);
            //statusBar1.Panels.Add("User");
            //statusBar1.Panels[2].Text = "MIP"; //FormLogin.UserName;
            //statusBar1.Panels[2].AutoSize = StatusBarPanelAutoSize.Contents;
            //StatusBarPanel UserName = new StatusBarPanel();

        }

        private void radMenuItem8_Click(object sender, EventArgs e)
        {
            this.Close();        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }
    }
}
