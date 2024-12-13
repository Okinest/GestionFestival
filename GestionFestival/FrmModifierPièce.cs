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

            if (piece == null)
            {
                MessageBox.Show("Aucune pièce sélectionnée pour la modification.");
                this.Close();
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
            if (pieceCourante != null)
            {
                txtNom.Text = pieceCourante.Play_name;
                txtDescription.Text = pieceCourante.Play_description;
                txtDuree.Text = pieceCourante.Play_duration.ToString();
                txtPrix.Text = pieceCourante.Play_price.ToString();  // Afficher le prix dans le textbox

                if (pieceCourante.Auth != null)
                    cmbAuteur.SelectedValue = pieceCourante.Auth.Auth_id;

                if (pieceCourante.Theme != null)
                    cmbTheme.SelectedValue = pieceCourante.Theme.Theme_id;

                if (pieceCourante.Aud != null)
                    cmbAudience.SelectedValue = pieceCourante.Aud.Aud_id;
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (pieceCourante == null)
            {
                MessageBox.Show("Erreur : aucune pièce à modifier.");
                return;
            }

            // Mise à jour des champs
            pieceCourante.Play_name = txtNom.Text;
            pieceCourante.Play_description = txtDescription.Text;
            pieceCourante.Play_duration = int.Parse(txtDuree.Text);
            pieceCourante.Play_price = double.Parse(txtPrix.Text);  // Récupérer le prix depuis la textbox
            pieceCourante.Auth.Auth_id = (int)cmbAuteur.SelectedValue;
            pieceCourante.Theme.Theme_id = (int)cmbTheme.SelectedValue;
            pieceCourante.Aud.Aud_id = (int)cmbAudience.SelectedValue;

            try
            {
                int result = GestionPieces.ModifierPiece(pieceCourante);
                Console.WriteLine("id :" + pieceCourante.Play_id);
                if (result > 0)
                {
                    MessageBox.Show("Pièce modifiée avec succès !");
                    BtnRetour_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmGestionPièce frmGestionPièce = new FrmGestionPièce();
            this.Hide();
            frmGestionPièce.StartPosition = FormStartPosition.CenterScreen;
            frmGestionPièce.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
