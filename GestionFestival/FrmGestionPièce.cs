﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFestival
{
    public partial class FrmGestionPièce : Form
    {
        public FrmGestionPièce()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            this.Hide();
            FrmMenu.Show();
        }
    }
}
