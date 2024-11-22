using System;
using System.Windows.Forms;
using TheatreBO;
using TheatreBLL;

namespace GestionFestival
{
    public partial class FrmModifierPièce : Form
    {
        private Pieces pieceCourante;

        // Modifie le constructeur pour inclure une vérification de null
        public FrmModifierPièce(Pieces piece)
        {
            InitializeComponent();

            // Vérifie si la pièce passée en paramètre est null
            if (piece == null)
            {
                MessageBox.Show("Aucune pièce sélectionnée pour la modification.");
                this.Close(); // Ferme le formulaire si aucune pièce n'est fournie
                return;
            }

            pieceCourante = piece;
            ChargerCombos();
            ChargerDonnées();
        }

        private void ChargerCombos()
        {
            cmbAuteur.DataSource = GestionPieces.GetPieces().GetListeAuthors();
            cmbAuteur.DisplayMember = "Auth_name";
            cmbAuteur.ValueMember = "Auth_id";

            cmbTheme.DataSource = GestionPieces.GetPieces().GetListeThemes();
            cmbTheme.DisplayMember = "Theme_name";
            cmbTheme.ValueMember = "Theme_id";

            cmbAudience.DataSource = GestionPieces.GetPieces().GetListeAudiences();
            cmbAudience.DisplayMember = "Aud_categ";
            cmbAudience.ValueMember = "Aud_id";
        }

        private void ChargerDonnées()
        {
            // Vérifie que pieceCourante n'est pas null avant d'accéder à ses propriétés
            if (pieceCourante != null)
            {
                txtNom.Text = pieceCourante.Play_name;
                txtDescription.Text = pieceCourante.Play_description;
                txtDuree.Text = pieceCourante.Play_duration.ToString();

                if (pieceCourante.Auth != null)
                    cmbAuteur.SelectedValue = pieceCourante.Auth.Auth_id;

                if (pieceCourante.Theme != null)
                    cmbTheme.SelectedValue = pieceCourante.Theme.Theme_id;

                if (pieceCourante.Aud != null)
                    cmbAudience.SelectedValue = pieceCourante.Aud.Aud_id;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Vérification de nullité de pieceCourante avant modification
            if (pieceCourante == null)
            {
                MessageBox.Show("Erreur : aucune pièce à modifier.");
                return;
            }

            // Mise à jour des champs
            pieceCourante.Play_name = txtNom.Text;
            pieceCourante.Play_description = txtDescription.Text;
            pieceCourante.Play_duration = int.Parse(txtDuree.Text);
            pieceCourante.Auth.Auth_id = (int)cmbAuteur.SelectedValue;
            pieceCourante.Theme.Theme_id = (int)cmbTheme.SelectedValue;
            pieceCourante.Aud.Aud_id = (int)cmbAudience.SelectedValue;

            try
            {
                GestionPieces.GetPieces().ModifierPiece(pieceCourante);
                MessageBox.Show("Pièce modifiée avec succès !");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
