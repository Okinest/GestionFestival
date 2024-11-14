using System;
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
    public partial class FrmAjoutPièce : Form
    {
        public FrmAjoutPièce()
        {
            InitializeComponent();
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            FrmGestionPièce frmGestionPièce = new FrmGestionPièce();
            this.Hide();
            frmGestionPièce.Show();
            
        }
    }
}
