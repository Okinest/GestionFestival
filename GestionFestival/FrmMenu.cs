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
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FrmAuthentification_KeyLeft);
        }

        private void FrmAuthentification_KeyLeft(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Si la touche est Entrée, on déclenche le clic du bouton de connexion
                btnPiece_Click(sender, e);
                btnRepresentations_Click(sender, e);
                btnReservations_Click(sender, e);
                btnSynthese_Click(sender, e);
            }
       
            else if (e.KeyCode == Keys.Right)
            {
                // Utilise Down pour aller au champ suivant
                if (btnPiece.Focused)
                {
                    btnRepresentations.Select();
                }
                else if (btnRepresentations.Focused)
                {
                    btnReservations.Focus();
                }
                else if (btnReservations.Focused)
                {
                    btnSynthese.Focus();
                }
                else if (btnSynthese.Focused)
                {
                    btnPiece.Focus();  
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (btnPiece.Focused)
                {
                    btnSynthese.Select(); 
                }
                else if (btnRepresentations.Focused)
                {
                    btnPiece.Focus();
                }
                else if (btnReservations.Focused)
                {
                    btnRepresentations.Focus();
                }
                else if (btnSynthese.Focused)
                {
                    btnReservations.Focus();
                }
            }
        }


        private void btnPiece_Click(object sender, EventArgs e)
        {
            FrmGestionPièce frmGestionPièce = new FrmGestionPièce();
            this.Hide();
            frmGestionPièce.StartPosition = FormStartPosition.CenterScreen;
            frmGestionPièce.Show();
        }

        private void btnRepresentations_Click(object sender, EventArgs e)
        {
            FrmGestionRepresentation frmListeRepresentations = new FrmGestionRepresentation();
            this.Hide();
            frmListeRepresentations.StartPosition = FormStartPosition.CenterScreen;
            frmListeRepresentations.Show();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            FrmGestionReservation frmGestionReservation = new FrmGestionReservation();
            this.Hide();
            frmGestionReservation.StartPosition = FormStartPosition.CenterScreen;
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
            frmAuthentification.StartPosition = FormStartPosition.CenterScreen;
            frmAuthentification.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
