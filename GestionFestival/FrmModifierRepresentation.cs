using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheatreBLL;
using TheatreBO;

namespace GestionFestival
{
    public partial class FrmModifierRepresentation : Form
    {
        private static GestionRepresentations uneGestionRepresentation = new GestionRepresentations();
        private static GestionPieces uneGestionPiece = new GestionPieces();
        private Representation currentRep;

        // ErrorProvider pour afficher les messages d'erreur
        private ErrorProvider errorProvider = new ErrorProvider();

        public FrmModifierRepresentation(Representation rep)
        {
            InitializeComponent();
            if (rep == null)
            {
                MessageBox.Show("Erreur lors de la récupération de la représentation");
                this.Close();
                return;
            }
            currentRep = rep;
            LoadCmb();
            LoadData();

        }

        private void LoadCmb()
        {
            List<Pieces> pieceList = uneGestionPiece.GetListePieces();
            cmbPieces.DataSource = pieceList;
            cmbPieces.DisplayMember = "Play_name";
            cmbPieces.ValueMember = "Play_id";

            List<Rate> rateList = uneGestionRepresentation.GetListeRates();
            cmbRates.DataSource = rateList;
            cmbRates.DisplayMember = "Rate_period";
            cmbRates.ValueMember = "Rate_id";
        }

        private void LoadData()
        {
            // Vérification et assignation du lieu
            if (string.IsNullOrWhiteSpace(currentRep.Rep_lieu))
            {
                errorProvider.SetError(txtLieu, "Le lieu ne peut pas être vide.");
            }
            else
            {
                txtLieu.Text = currentRep.Rep_lieu;
                errorProvider.SetError(txtLieu, string.Empty);
            }

            // Vérification et assignation du nombre de sièges
            if (currentRep.Rep_max_seats <= 0)
            {
                errorProvider.SetError(txtSeat, "Le nombre de sièges doit être supérieur à zéro.");
            }
            else
            {
                txtSeat.Text = currentRep.Rep_max_seats.ToString();
                errorProvider.SetError(txtSeat, string.Empty);
            }

            // Assignation de la pièce
            if (currentRep.Piece != null)
            {
                cmbPieces.SelectedValue = currentRep.Piece.Play_id;
                errorProvider.SetError(cmbPieces, string.Empty);
            }
            else
            {
                errorProvider.SetError(cmbPieces, "La pièce sélectionnée est invalide.");
            }

            // Assignation du tarif
            if (currentRep.Rate != null)
            {
                cmbRates.SelectedValue = currentRep.Rate.Rate_id;
                errorProvider.SetError(cmbRates, string.Empty);
            }
            else
            {
                errorProvider.SetError(cmbRates, "Le tarif sélectionné est invalide.");
            }

            // Assignation de la date
            if (currentRep.Rep_date != DateTime.MinValue)
            {
                dtpDate.Value = currentRep.Rep_date;
                errorProvider.SetError(dtpDate, string.Empty);
            }
            else
            {
                errorProvider.SetError(dtpDate, "La date sélectionnée est invalide.");
            }

            // Vérification et assignation de l'heure
            if (TimeSpan.TryParse(currentRep.Rep_time.ToString(), out TimeSpan repTime))
            {
                txtHeure.Text = repTime.ToString(@"hh\:mm");
                errorProvider.SetError(txtHeure, string.Empty);
            }
            else
            {
                errorProvider.SetError(txtHeure, "L'heure sélectionnée est invalide.");
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (currentRep == null)
            {
                MessageBox.Show("Erreur lors de la récupération de la représentation");
                this.Close();
                return;
            }

            if (ValidateForm())
            {
                try
                {
                    // Récupérer et valider l'horaire
                    string timeString = txtHeure.Text;
                    if (TimeSpan.TryParseExact(timeString, "hh\\:mm", null, out TimeSpan repTime))
                    {
                        Representation rep = new Representation(currentRep.Rep_id,
                            dtpDate.Value.Date,
                            repTime,txtLieu.Text,
                            int.Parse(txtSeat.Text),
                            (Pieces)cmbPieces.SelectedItem,
                            (Rate)cmbRates.SelectedItem);

                        int result = GestionRepresentations.ModifierRepresentation(rep);

                        if (result > 0)
                        {
                            MessageBox.Show("Représentation modifiée avec succès !");
                            btnRetour_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la modification de la représentation.");
                        }
                    }
                    else
                    {
                        errorProvider.SetError(txtHeure, "Veuillez entrer l'horaire au format HH:MM.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification de la représentation : " + ex.Message);
                }
            }

        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmGestionRepresentation frmGestionRepresentation = new FrmGestionRepresentation();
            this.Hide();
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

            if (string.IsNullOrWhiteSpace(txtLieu.Text))
            {
                errorProvider.SetError(txtLieu, "Veuillez entrer un lieu.");
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
    }
}
