using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheatreDAL;


namespace GestionFestival
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnPiece_Click(object sender, EventArgs e)
        {
            FrmGestionPièce FrmGestionPièce = new FrmGestionPièce();
            this.Hide();
            FrmGestionPièce.Show();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {


            ConnexionBD.GetConnexionBD().CloseConnexion();
            FrmAuthentification FrmAuthentification = new FrmAuthentification();
            this.Hide();
            FrmAuthentification.Show();
        }
    }
}
