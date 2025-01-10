using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheatreBO;
using TheatreBLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionFestival
{
    public partial class FrmAjoutRepresentation : Form
    {
        private static GestionRepresentations uneGestionRepresentation = new GestionRepresentations();
        private static GestionPieces uneGestionPiece = new GestionPieces();

        // ErrorProvider pour afficher les messages d'erreur
        private ErrorProvider errorProvider = new ErrorProvider();

        public FrmAjoutRepresentation()
        {
            InitializeComponent();
        }

        private void FrmAjoutRepresentation_Load(object sender, EventArgs e)
        {
            List<Pieces> pieceList = uneGestionPiece.GetListePieces();
            cmbPieces.DataSource = pieceList;
            cmbPieces.DisplayMember = "Play_name";
            cmbPieces.ValueMember = "Play_id";
            cmbPieces.SelectedIndex = -1;// Désactiver la sélection initiale

            List<Rate> rateList = uneGestionRepresentation.GetListeRates();
            cmbRates.DataSource = rateList;
            cmbRates.DisplayMember = "Rate_period";
            cmbRates.ValueMember = "Rate_id";
            cmbRates.SelectedIndex = -1;// Désactiver la sélection initiale

            //RECUPERATION DES DIFFÉRENTS LIEUX
            List<Place> placeList = uneGestionRepresentation.GetListePlaces();
            cmbLieu.DataSource = placeList;
            cmbLieu.DisplayMember = "name";
            cmbLieu.ValueMember = "id";
            cmbLieu.SelectedIndex = -1;// Désactiver la sélection initiale
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    // Récupérer et valider l'horaire
                    string timeString = txtHeure.Text;
                    if (TimeSpan.TryParseExact(timeString, "hh\\:mm", null, out TimeSpan repTime))
                    {
                        Representation rep = new Representation(
                            dtpDate.Value.Date,
                            repTime,
                            (Place)cmbLieu.SelectedItem,
                            int.Parse(txtSeat.Text),
                            (Pieces)cmbPieces.SelectedItem,
                            (Rate)cmbRates.SelectedItem
                        );

                        int result = GestionRepresentations.AjoutRepresentation(rep);

                        if (result > 0)
                        {
                            MessageBox.Show("Représentation ajoutée avec succès !");
                            btnRetour_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de l'ajout de la représentation.");
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txtHeure, "Veuillez entrer l'horaire au format HH:MM.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout de la représentation : " + ex.Message);
                }
            }
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmGestionRepresentation frmGestionRepresentation = new FrmGestionRepresentation();
            this.Hide();
            frmGestionRepresentation.StartPosition = FormStartPosition.CenterScreen;
            frmGestionRepresentation.Show();
    
        }
        private bool ValidateForm()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (cmbPieces.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbPieces, "Veuillez sélectionner une pièce.");
                isValid = false;
            }

            if (cmbRates.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbRates, "Veuillez sélectionner un tarif.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(cmbLieu.Text))
            {
                errorProvider.SetError(cmbLieu, "Veuillez selectionner un lieu."); //ERREUR PROVIDER SELECTION D'UN LIEU
                isValid = false;
            }

            if (!int.TryParse(txtSeat.Text, out _))
            {
                errorProvider.SetError(txtSeat, "Veuillez entrer un nombre valide pour les places maximum.");
                isValid = false;
            }

            string timeString = txtHeure.Text;
            if (!TimeSpan.TryParseExact(timeString, "hh\\:mm", null, out _))
            {
                errorProvider.SetError(txtHeure, "Veuillez entrer l'horaire au format HH:MM.");
                isValid = false;
            }

            return isValid;
        }

        private void cmbRates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLieu.SelectedIndex != -1)
            {
                // Récupérer l'objet Place sélectionné
                var selectedPlace = (Place)cmbLieu.SelectedItem;

                // Affiche le range dans lblPlace
                lblPlace.Text = $"Situé à {selectedPlace.Range} Km de Paris";
            }
            else
            {
                // Efface le texte si rien n'est sélectionné
                lblPlace.Text = string.Empty;
            }
        }
    }
}
