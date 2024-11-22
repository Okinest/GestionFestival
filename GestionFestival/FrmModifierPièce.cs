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

            // Charger les données dans les champs
            ChargerCombos();
            ChargerDonnées();
        }

        private void ChargerCombos()
        {
            cmbAuteur.DataSource = GestionPieces.GetPieces().GetListeAuthors();
            cmbAuteur.DisplayMember = "Auth_name";
            cmbAuteur.ValueMember = "Auth_id";
            cmbAuteur.SelectedIndex = -1;

            cmbTheme.DataSource = GestionPieces.GetPieces().GetListeThemes();
            cmbTheme.DisplayMember = "Theme_name";
            cmbTheme.ValueMember = "Theme_id";
            cmbTheme.SelectedIndex = -1;

            cmbAudience.DataSource = GestionPieces.GetPieces().GetListeAudiences();
            cmbAudience.DisplayMember = "Aud_categ";
            cmbAudience.ValueMember = "Aud_id";
            cmbAudience.SelectedIndex = -1;
        }

        private void ChargerDonnées()
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Mettre à jour les champs
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
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
