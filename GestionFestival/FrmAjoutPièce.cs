using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TheatreBO;
using TheatreBLL;

namespace GestionFestival
{
    public partial class FrmAjoutPièce : Form
    {
        private static GestionPieces uneGestionPiece = new GestionPieces();

        public FrmAjoutPièce()
        {
            InitializeComponent();
        }

        private void FrmAjoutPièce_Load(object sender, EventArgs e)
        {
            List<Theme> themeList = uneGestionPiece.GetListeThemes();
            cmbThemes.DataSource = themeList;
            cmbThemes.DisplayMember = "Theme_name";
            cmbThemes.ValueMember = "Theme_id";

            List<Audience> audienceList = uneGestionPiece.GetListeAudiences();
            cmbAudience.DataSource = audienceList;
            cmbAudience.DisplayMember = "Aud_categ";
            cmbAudience.ValueMember = "Aud_id";

            List<Author> authorList = uneGestionPiece.GetListeAuthors(); // Correction ici
            cmbAuteur.DataSource = authorList;
            cmbAuteur.DisplayMember = "Auth_name";
            cmbAuteur.ValueMember = "Auth_id";
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmGestionPièce frmGestionPièce = new FrmGestionPièce();
            this.Hide();
            frmGestionPièce.StartPosition = FormStartPosition.CenterScreen;
            frmGestionPièce.Show();
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            string playName = txtNom.Text;
            string playDescription = txtDescription.Text;
            string playDuration = txtDuree.Text;
            string playPrice = txtPrix.Text;
            int.TryParse(playDuration, out int playDurationConvert);
            float.TryParse(playPrice, out float playPriceConvert);

            bool isValid = true;

            // Réinitialisation des messages d'erreur
            lblErreurNom.Visible = false;
            lblErreurDescription.Visible = false;
            lblErreurPrix.Visible = false;
            lblErreurDuree.Visible = false;

            // Validation des champs
            if (string.IsNullOrEmpty(playName))
            {
                lblErreurNom.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrEmpty(playDescription))
            {
                lblErreurDescription.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrEmpty(playPrice) || !float.TryParse(playPrice, out playPriceConvert))
            {
                lblErreurPrix.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrEmpty(playDuration) || !int.TryParse(playDuration, out playDurationConvert))
            {
                lblErreurDuree.Visible = true;
                isValid = false;
            }

            // Vérification si tous les champs sont vides
            if (string.IsNullOrEmpty(playName) && string.IsNullOrEmpty(playDescription) && string.IsNullOrEmpty(playPrice) && string.IsNullOrEmpty(playDuration))
            {
                lblErreurNom.Visible = true;
                lblErreurDescription.Visible = true;
                lblErreurPrix.Visible = true;
                lblErreurDuree.Visible = true;
                isValid = false;
            }

            // Si tous les champs sont valides
            if (isValid)
            {
                try
                {
                    Author selectedAuthor = (Author)cmbAuteur.SelectedItem;
                    Theme selectedTheme = (Theme)cmbThemes.SelectedItem;
                    Audience selectedAudience = (Audience)cmbAudience.SelectedItem;

                    Pieces newPiece = new Pieces(playName, playDescription, playDurationConvert, playPriceConvert, selectedAuthor, selectedTheme, selectedAudience);

                    int result = GestionPieces.CreerPieces(newPiece);

                    if (result > 0)
                    {
                        MessageBox.Show("Pièce ajoutée avec succès !");
                        BtnRetour_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Échec de l'ajout de la pièce.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout de la pièce : " + ex.Message);
                }
            }
        }
    }
}
