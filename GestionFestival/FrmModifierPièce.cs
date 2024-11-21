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

            // Charger les données dans les ComboBox
            ChargerCombos();

            if (pieceCourante != null)
            {
                ChargerDonnées(); // Charger les informations de la pièce dans les champs
            }
            else
            {
                MessageBox.Show("La pièce à modifier n'est pas valide.");
            }
        }

        private void ChargerCombos()
        {
            // Charger les auteurs dans cmbAuteur
            cmbAuteur.DataSource = GestionPieces.GetPieces().GetListeAuthors();  // Récupérer les auteurs
            cmbAuteur.DisplayMember = "Auth_name";  // Afficher le nom de l'auteur
            cmbAuteur.ValueMember = "Auth_id";     // Utiliser l'ID de l'auteur
            cmbAuteur.SelectedIndex = -1;          // Initialiser sans sélection

            // Charger les thèmes dans cmbTheme
            cmbTheme.DataSource = GestionPieces.GetPieces().GetListeThemes();  // Récupérer les thèmes
            cmbTheme.DisplayMember = "Theme_name";  // Afficher le nom du thème
            cmbTheme.ValueMember = "Theme_id";      // Utiliser l'ID du thème
            cmbTheme.SelectedIndex = -1;            // Initialiser sans sélection

            // Charger les audiences dans cmbAudience
            cmbAudience.DataSource = GestionPieces.GetPieces().GetListeAudiences();  // Récupérer les audiences
            cmbAudience.DisplayMember = "Aud_categ"; // Afficher la catégorie d'audience
            cmbAudience.ValueMember = "Aud_id";      // Utiliser l'ID de l'audience
            cmbAudience.SelectedIndex = -1;          // Initialiser sans sélection
        }

        private void ChargerDonnées()
        {
            // Charger les données de la pièce dans les champs de texte
            txtNom.Text = pieceCourante.Play_name;
            txtDescription.Text = pieceCourante.Play_description;
            txtDuree.Text = pieceCourante.Play_duration.ToString();
            txtPrix.Text = pieceCourante.Play_price.ToString();

            // Charger les ComboBox avec les valeurs de la pièce (sélectionner l'élément correspondant)
            if (pieceCourante.Auth != null)
            {
                cmbAuteur.SelectedValue = pieceCourante.Auth.Auth_id;  // Sélectionner l'auteur associé à la pièce
            }

            if (pieceCourante.Theme != null)
            {
                cmbTheme.SelectedValue = pieceCourante.Theme.Theme_id;  // Sélectionner le thème associé à la pièce
            }

            if (pieceCourante.Aud != null)
            {
                cmbAudience.SelectedValue = pieceCourante.Aud.Aud_id;  // Sélectionner l'audience associée à la pièce
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
