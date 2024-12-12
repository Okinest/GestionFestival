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
    public partial class FrmAjoutReservation : Form
    {
        private readonly GestionReservations gestionReservations;
        private static GestionPieces uneGestionPiece = new GestionPieces();
        private static GestionRepresentations GestionRepresentations = new GestionRepresentations();
        // ErrorProvider pour afficher les messages d'erreur
        private ErrorProvider errorProvider = new ErrorProvider();
        public FrmAjoutReservation()
        {
            InitializeComponent();
            gestionReservations = new GestionReservations();
        }

        private void FrmAjoutReservation_Load(object sender, EventArgs e)
        {
            List<Pieces> pieceList = uneGestionPiece.GetListePieces();
            cmbPiece.DataSource = pieceList;
            cmbPiece.ValueMember = "Play_id";
            cmbPiece.DisplayMember = "Play_name";
            cmbPiece.SelectedIndex = -1;// Désactiver la sélection initiale

            List<Representation> representations = GestionRepresentations.GetListeRepresentations();
            cmbRepresentation.DataSource = representations;
            cmbRepresentation.ValueMember = "rep_id";
            cmbRepresentation.DisplayMember = "DateTimeFormatted";
            cmbRepresentation.SelectedIndex = -1;// Désactiver la sélection initiale
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

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Veuillez entrer une email valide.");
                isValid = false;
            }

            if (!int.TryParse(txtTelephone.Text, out _) || txtTelephone.Text.Length != 10)
            {
                errorProvider.SetError(txtTelephone, "Veuillez entrer un numéro valide.");
                isValid = false;
            }

            if (!IsValidMaxPlace(txtNbPlace, GetSelectedRepresentationId())) //VALIDATION PLACE
            {
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

        //POUR VERIFIER LE NOMBRE DE PLACE MAXIMUM
        private bool IsValidMaxPlace(TextBox txtNbPlace, int repId)
        {
            bool isValid = true;

            if (!int.TryParse(txtNbPlace.Text, out int nbPlace) || nbPlace <= 0)
            {
                errorProvider.SetError(txtNbPlace, "Veuillez entrer un nombre valide (supérieur à 0).");
                isValid = false;
            }
            else
            {
                //RECUPERER DU NOMBRE DE PLACE MAXIMUM
                int MaxnbPlaces = gestionReservations.GetMaxPlacesForRepresentation(repId);

                //COMPARER MAX PERSONNE PAR RAPPORT AU NOMBRE DE PLACE
                if (nbPlace > MaxnbPlaces)
                {
                    errorProvider.SetError(txtNbPlace, $"Le nombre de places ne peut pas dépasser {MaxnbPlaces}.");
                    isValid = false;
                }
            }

            return isValid;
        }

        private int GetSelectedRepresentationId()
        {
            if (cmbRepresentation.SelectedItem != null)
            {
                var selectedItem = (Representation)cmbRepresentation.SelectedItem;
                return selectedItem.Rep_id;
            }
            //SI RIEN SELECTIONNER
            return 0;
        }

        //POUR VERIFIER L'EMAIL
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    // CUSTOMER
                    string customerLastName = txtNom.Text;
                    string customerFirstName = txtPrenom.Text;
                    string customerEmail = txtEmail.Text;
                    string customerPhone = txtTelephone.Text;

                    //OBJET CUSTOMER
                    Customer customer = new Customer(customerFirstName, customerLastName, customerEmail, customerPhone);

                    // RESERVATION
                    string pieceName = cmbPiece.Text;
                    string representationName = cmbRepresentation.Text;
                    int numSeats = int.Parse(txtNbPlace.Text);

                    //PIECE ASSOCIER  A LA COMBOBOX
                    Pieces selectedPiece = (Pieces)cmbPiece.SelectedItem;

                    //REPRESENTATIO ASSOCIER A LA COMBOBOX
                    Representation selectedRepresentation = (Representation)cmbRepresentation.SelectedItem;

                    //OBJET RESERVATION
                    Reservation res = new Reservation(customer, selectedRepresentation, numSeats);

                    
                    int result = GestionReservations.AjoutReservation(res);

                    //VERIF
                    if (result > 0)
                    {
                        MessageBox.Show("Réservation ajoutée avec succès !");
                        btnRetour_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout de la réservation.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout de la réservation : " + ex.Message);
                }
            }
        }

        private void cmbPiece_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
