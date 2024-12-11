using System;
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
            FrmGestionPièce frmGestionPièce = new FrmGestionPièce();
            this.Hide();
            frmGestionPièce.Show();
        }

        private void btnRepresentations_Click(object sender, EventArgs e)
        {
            FrmGestionRepresentation frmListeRepresentations = new FrmGestionRepresentation();
            this.Hide();
            frmListeRepresentations.Show();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            FrmGestionReservation frmGestionReservation = new FrmGestionReservation();
            this.Hide();
            frmGestionReservation.Show();
        }

        private void btnSynthese_Click(object sender, EventArgs e)
        {
            // Logique pour accéder à la synthèse (si nécessaire)
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            ConnexionBD.GetConnexionBD().CloseConnexion();
            FrmAuthentification frmAuthentification = new FrmAuthentification();
            this.Hide();
            frmAuthentification.Show();
        }
    }
}
