﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSellPoint
{
    public partial class TiposEntidades : GrupoEntidades
    {
        public TiposEntidades()
        {
            InitializeComponent();
        }

        private void TiposEntidades_Load(object sender, EventArgs e)
        {

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
    }
}
