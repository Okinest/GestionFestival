using System;
using System.Windows.Forms;
using TheatreBO;
using TheatreBLL;

namespace GestionFestival
{
    public partial class FrmModifierPièce : Form
    {
        private Pieces pieceCourante;

        public FrmModifierPièce(Pieces piece)
        {
            InitializeComponent();
            pieceCourante = piece;

            if (pieceCourante != null)
            {
                ChargerDonnées();
            }
            else
            {
                MessageBox.Show("La pièce à modifier n'est pas valide.");
            }
        }

        private void ChargerDonnées()
        {
            // Charger les données de la pièce dans les contrôles
            txtNom.Text = pieceCourante.Play_name;
            txtDescription.Text = pieceCourante.Play_description;
            txtDuree.Text = pieceCourante.Play_duration.ToString();
            txtPrix.Text = pieceCourante.Play_price.ToString();

            // Vérifier si les données pour les auteurs sont disponibles
            if (pieceCourante.Auth != null)
            {
                cmbAuteur.SelectedValue = pieceCourante.Auth.Auth_id;
            }

            // Vérifier si les données pour les thèmes sont disponibles
            if (pieceCourante.Theme != null)
            {
                cmbTheme.SelectedValue = pieceCourante.Theme.Theme_id;
            }

            // Vérifier si les données pour l'audience sont disponibles
            if (pieceCourante.Aud != null)
            {
                cmbAudience.SelectedValue = pieceCourante.Aud.Aud_id;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Vérifiez si la pièce courante est initialisée
            if (pieceCourante != null)
            {
                // Vérification des valeurs avant de les assigner
                if (cmbAuteur.SelectedValue != null && cmbAuteur.SelectedIndex != -1)
                {
                    pieceCourante.Auth.Auth_id = (int)cmbAuteur.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un auteur.");
                    return;
                }

                if (cmbTheme.SelectedValue != null && cmbTheme.SelectedIndex != -1)
                {
                    pieceCourante.Theme.Theme_id = (int)cmbTheme.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un thème.");
                    return;
                }

                if (cmbAudience.SelectedValue != null && cmbAudience.SelectedIndex != -1)
                {
                    pieceCourante.Aud.Aud_id = (int)cmbAudience.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une catégorie d'audience.");
                    return;
                }

                // Mettre à jour les autres données de la pièce
                pieceCourante.Play_name = txtNom.Text;
                pieceCourante.Play_description = txtDescription.Text;
                pieceCourante.Play_duration = int.Parse(txtDuree.Text);
                pieceCourante.Play_price = double.Parse(txtPrix.Text);

                try
                {
                    // Enregistrer les modifications de la pièce
                    GestionPieces.GetPieces().ModifierPiece(pieceCourante);
                    MessageBox.Show("Pièce modifiée avec succès !");
                    this.Close();  // Fermer le formulaire après l'enregistrement
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("La pièce courante est invalide.");
            }
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            this.Close();  // Retour à la fenêtre précédente
        }
    }
}
