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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionFestival
{
    public partial class FrmModifierReservation : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        private Reservation currentRep;
        private Customer currentCus;
        private Representation currentRepresentation;
        private static GestionPieces uneGestionPiece = new GestionPieces();
        private static GestionRepresentations GestionRepresentations = new GestionRepresentations();

        public FrmModifierReservation(Reservation res, Customer cus, Representation rep)
        {
            InitializeComponent();
            if (res == null)
            {
                MessageBox.Show("Erreur lors de la récupération de la représentation");
                this.Close();
                return;
            }
            currentRep = res;
            currentCus = cus;
            currentRepresentation = rep;
            LoadCmb();
            LoadData();
        }

        private void LoadCmb()
        {
            List<Pieces> pieceList = uneGestionPiece.GetListePieces();
            cmbPiece.DataSource = pieceList;
            cmbPiece.ValueMember = "Play_id";
            cmbPiece.DisplayMember = "Play_name";

            List<Representation> representations = GestionRepresentations.GetListeRepresentations();
            cmbRepresentation.DataSource = representations;
            cmbRepresentation.ValueMember = "rep_id";
            cmbRepresentation.DisplayMember = "rep_date";
        }

        private void LoadData()
        {
            if (string.IsNullOrWhiteSpace(currentCus.Cus_lastname))
            {
                errorProvider.SetError(txtNom, "Le nom ne peut pas être vide.");
            }
            else
            {
                txtNom.Text = currentRep.Cus_lastname;
                errorProvider.SetError(txtNom, string.Empty);
            }

            // Vérification et assignation du prénom
            if (string.IsNullOrWhiteSpace(currentCus.Cus_firstname))
            {
                errorProvider.SetError(txtPrenom, "Le prénom ne peut pas être vide.");
            }
            else
            {
                txtPrenom.Text = currentCus.Cus_firstname;
                errorProvider.SetError(txtPrenom, string.Empty);
            }

            // Vérification et assignation de l'email
            if (string.IsNullOrWhiteSpace(currentCus.Cus_email))
            {
                errorProvider.SetError(txtEmail, "L'email ne peut pas être vide.");
            }
            else
            {
                txtEmail.Text = currentCus.Cus_email;
                errorProvider.SetError(txtEmail, string.Empty);
            }

            if (!string.IsNullOrWhiteSpace(currentCus.Cus_phone_number) && !int.TryParse(currentCus.Cus_phone_number, out _))
            {
                errorProvider.SetError(txtTelephone, "Numéro de téléphone invalide.");
            }
            else
            {
                txtTelephone.Text = currentCus.Cus_phone_number;
                errorProvider.SetError(txtTelephone, string.Empty);
            }

            if (currentRep.Res_num_seats <= 0)
            {
                errorProvider.SetError(txtNbPlace, "Le nombre de sièges doit être supérieur à zéro.");
            }
            else
            {
                txtNbPlace.Text = currentRep.Res_num_seats.ToString();
                errorProvider.SetError(txtNbPlace, string.Empty);
            }

            //COMBOBOX PIECE
            if (currentRepresentation.Piece != null)
            {
                cmbPiece.SelectedValue = currentRepresentation.Piece.Play_id;
                errorProvider.SetError(cmbPiece, string.Empty);
            }
            else
            {
                errorProvider.SetError(cmbPiece, "La pièce sélectionnée est invalide.");
            }
            //COMBOBOX REPRESENTATION
            if (currentRepresentation.Piece != null)
            {
                cmbRepresentation.SelectedValue = currentRepresentation.Piece.Play_id;
                errorProvider.SetError(cmbRepresentation, string.Empty);
            }
            else
            {
                errorProvider.SetError(cmbRepresentation, "La pièce sélectionnée est invalide.");
            }
        }

        private void lblReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmGestionReservation frmGestionReservation = new FrmGestionReservation();
            this.Hide();
            frmGestionReservation.StartPosition = FormStartPosition.CenterScreen;
            frmGestionReservation.Show();
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                errorProvider.SetError(txtNom, "Veuillez entrer un nom.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                errorProvider.SetError(txtPrenom, "Veuillez entrer un prénom.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Veuillez entrer un email.");
                isValid = false;
            }

            if (!int.TryParse(txtTelephone.Text, out _))
            {
                errorProvider.SetError(txtTelephone, "Veuillez entrer un numéro valide.");
                isValid = false;
            }

            if (!int.TryParse(txtNbPlace.Text, out int nbPlace) || nbPlace <= 0)
            {
                errorProvider.SetError(txtNbPlace, "Veuillez entrer un nombre valide (supérieur à 0).");
                isValid = false;
            }

            if (cmbPiece.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbPiece, "Veuillez sélectionner une pièce.");
                isValid = false;
            }

            if (cmbRepresentation.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbRepresentation, "Veuillez sélectionner une représentation.");
                isValid = false;
            }

            return isValid;
        }

        private void FrmModifierReservation_Load(object sender, EventArgs e)
        {

        }
    }
}
