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
using TheatreDAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionFestival
{
    public partial class FrmModifierReservation : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        private Reservation currentRes;
        private static GestionPieces uneGestionPiece = new GestionPieces();
        private static GestionRepresentations GestionRepresentations = new GestionRepresentations();
        private readonly GestionReservations gestionReservations;

        public FrmModifierReservation(Reservation res)
        {
            InitializeComponent();
            cmbPiece.SelectedIndexChanged += cmbPiece_SelectedIndexChanged; //CHANGEMENT DU TARIF INTITIAL EN FONCTION DE LA PIECE
            cmbRepresentation.SelectedIndexChanged += cmbRepresentation_SelectedIndexChanged; //CHANGEMENT DU TARIF EN FONCTION DE LA REPRESENTATION
            txtNbPlace.TextChanged += txtNbPlace_TextChanged; // AJOUTER CETTE LIGNE
            if (res == null)
            {
                MessageBox.Show("Erreur lors de la récupération de la représentation");
                this.Close();
                return;
            }
            currentRes = res;
            LoadCmb();
            LoadData();
            gestionReservations = new GestionReservations();
        }

        private void LoadCmb()
        {
            List<Pieces> pieceList = uneGestionPiece.GetListePieces();
            cmbPiece.DataSource = pieceList;
            cmbPiece.ValueMember = "Play_id";
            cmbPiece.DisplayMember = "Play_name";

            List<Representation> representations = GestionRepresentations.GetListeRepresentations();
            cmbRepresentation.DataSource = representations;
            cmbRepresentation.ValueMember = "Rep_id";
            cmbRepresentation.DisplayMember = "DateTimeFormatted";

        }

        private void LoadData()
        {
            if (string.IsNullOrWhiteSpace(currentRes.Customer.Cus_lastname))
            {
                errorProvider.SetError(txtNom, "Le nom ne peut pas être vide.");
            }
            else
            {
                txtNom.Text = currentRes.Customer.Cus_lastname;
                errorProvider.SetError(txtNom, string.Empty);
            }

            // Vérification et assignation du prénom
            if (string.IsNullOrWhiteSpace(currentRes.Customer.Cus_firstname))
            {
                errorProvider.SetError(txtPrenom, "Le prénom ne peut pas être vide.");
            }
            else
            {
                txtPrenom.Text = currentRes.Customer.Cus_firstname;
                errorProvider.SetError(txtPrenom, string.Empty);
            }

            // Vérification et assignation de l'email
            if (string.IsNullOrWhiteSpace(currentRes.Customer.Cus_email))
            {
                errorProvider.SetError(txtEmail, "L'email ne peut pas être vide.");
            }
            else
            {
                txtEmail.Text = currentRes.Customer.Cus_email;
                errorProvider.SetError(txtEmail, string.Empty);
            }

            if (!string.IsNullOrWhiteSpace(currentRes.Customer.Cus_phone_number) && !int.TryParse(currentRes.Customer.Cus_phone_number, out _))
            {
                errorProvider.SetError(txtTelephone, "Numéro de téléphone invalide.");
            }
            else
            {
                txtTelephone.Text = currentRes.Customer.Cus_phone_number;
                errorProvider.SetError(txtTelephone, string.Empty);
            }

            if (currentRes.Res_num_seats <= 0)
            {
                errorProvider.SetError(txtNbPlace, "Le nombre de sièges doit être supérieur à zéro.");
            }
            else
            {
                txtNbPlace.Text = currentRes.Res_num_seats.ToString();
                errorProvider.SetError(txtNbPlace, string.Empty);
            }

            //COMBOBOX PIECE
            if (currentRes.Representation.Piece != null)
            {
                cmbPiece.SelectedValue = currentRes.Representation.Piece.Play_id;
                errorProvider.SetError(cmbPiece, string.Empty);
            }
            else
            {
                errorProvider.SetError(cmbPiece, "La pièce sélectionnée est invalide.");
            }
            //COMBOBOX REPRESENTATION
            if (currentRes.Representation != null && currentRes.Representation.Rep_date != DateTime.MinValue && currentRes.Representation.Rep_time != TimeSpan.Zero)
            {
                cmbRepresentation.SelectedValue = currentRes.Representation.Rep_id;
                errorProvider.SetError(cmbRepresentation, string.Empty);
            }
            else
            {
                errorProvider.SetError(cmbRepresentation, "La date de la représentation sélectionnée est invalide.");
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

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Veuillez entrer un email valide.");
                isValid = false;
            }

            if (!int.TryParse(txtTelephone.Text, out _) || txtTelephone.Text.Length != 10)
                {
                errorProvider.SetError(txtTelephone, "Veuillez entrer un numéro valide.");
                isValid = false;
            }

            int repId = GetSelectedRepresentationId();
            int nbPlaceTotal = ReservationDAO.GetNbPlaceTotalForReservation(repId);

            if (!IsValidMaxPlace(txtNbPlace, repId, nbPlaceTotal)) //VALIDATION PLACE MAX
            {
                isValid = false;
            }

            if (cmbPiece.SelectedItem == null)
            {
                errorProvider.SetError(cmbPiece, "Veuillez sélectionner une pièce.");
                isValid = false;
            }

            if (cmbRepresentation.SelectedItem == null)
            {
                errorProvider.SetError(cmbRepresentation, "Veuillez sélectionner une représentation.");
                isValid = false;
            }

            return isValid;
        }

        //POUR VERIFIER LE NOMBRE DE PLACE MAXIMUM
        private bool IsValidMaxPlace(TextBox txtNbPlace, int repId, int nbPlaceTotal)
        {
            bool isValid = true;

            if (!int.TryParse(txtNbPlace.Text, out int nbPlace) || nbPlace <= 0)
            {
                errorProvider.SetError(txtNbPlace, "Veuillez entrer un nombre valide (supérieur à 0).");
                isValid = false;
            }
            else
            {
                int totalPlacesReservees = gestionReservations.GetNbPlaceTotal(repId);
                int maxPlacesPossible = gestionReservations.GetMaxPlacesForRepresentation(repId);
                int placesRestantes = maxPlacesPossible - totalPlacesReservees;//CALCUL RESTANT PLACE                    

                if (nbPlace > maxPlacesPossible)
                {
                    errorProvider.SetError(txtNbPlace, $"Le nombre de places ne peut pas dépasser {maxPlacesPossible}.");
                    isValid = false;
                }
                //SI PLACE DEPASSE LE NOMBRE DE PLACE
                else if (nbPlace > placesRestantes)
                {
                    errorProvider.SetError(txtNbPlace, $"Le nombre de places dépasse les places restantes. Places restantes : {placesRestantes}.");
                    isValid = false;
                }
                else
                {
                    // Si tout est valide, aucune erreur
                    errorProvider.SetError(txtNbPlace, string.Empty);
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

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (currentRes == null)
            {
                MessageBox.Show("Erreur lors de la récupération de la réservation");
                this.Close();
                return;
            }

            if (ValidateForm())
            {
                try
                {
                    // Création de l'objet Customer
                    int customerId = currentRes.Customer.Cus_id;
                    string customerLastName = txtNom.Text;
                    string customerFirstName = txtPrenom.Text;
                    string customerEmail = txtEmail.Text;
                    string customerPhone = txtTelephone.Text;

                    Customer customer = new Customer(customerId, customerFirstName, customerLastName, customerEmail, customerPhone);

                    //OBJET RESERVATION
                    Pieces selectedPiece = (Pieces)cmbPiece.SelectedItem;
                    Representation selectedRepresentation = (Representation)cmbRepresentation.SelectedItem;
                    int numSeats = int.Parse(txtNbPlace.Text);

                    Reservation res = new Reservation(customer, selectedRepresentation, numSeats);

                    // Appel à la méthode de modification
                    int result = GestionReservations.ModifierReservation(res);

                    if (result > 0)
                    {
                        MessageBox.Show("Réservation modifiée avec succès !");
                        btnRetour_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la modification de la réservation.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification de la réservation : " + ex.Message);
                }
            }
        }

        private void cmbPiece_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pieces selectedPiece = (Pieces)cmbPiece.SelectedItem;

            if (selectedPiece != null)
            {
                double price = GestionReservations.GetPiecePrice(selectedPiece.Play_id);
                txtTarifPlace.Text = price.ToString("C");

                // Si une représentation est déjà sélectionnée, recalculer également le tarif
                if (cmbRepresentation.SelectedItem is Representation selectedRepresentation)
                {
                    // Récupérer l'heure de la représentation
                    string timeOfDay = selectedRepresentation.Rep_time.ToString(@"hh\:mm");

                    //RECALCULER LE TARIF
                    double updatedPrice = GestionReservations.GetPiecePriceByTime(selectedPiece.Play_id, timeOfDay);

                    // Afficher le tarif actualisé pour la représentation
                    txtTarifReservation.Visible = true;
                    txtTarifReservation.Text = updatedPrice.ToString("C");
                }
            }
            else
            {
                txtTarifPlace.Text = "Veuillez sélectionner une pièce.";
            }
        }
        private bool ValidateNbPlace(out int nbPlace)
        {
            if (int.TryParse(txtNbPlace.Text, out nbPlace) && nbPlace > 0)
            {
                return true;
            }
            else
            {
                nbPlace = 0;
                return false;
            }
        }
        private void txtNbPlace_TextChanged(object sender, EventArgs e)
        {
            if (ValidateNbPlace(out int nbPlace))
            {
                txtNbPlace.BackColor = SystemColors.Window; // Couleur de fond normale
                UpdateTotalPrice();
            }
            else
            {
                txtNbPlace.BackColor = Color.LightCoral; // Couleur de fond pour indiquer une erreur
                txtTarifReservation.Visible = false; // Masquer le tarif si la validation échoue
            }
        }
        private void UpdateTotalPrice()
        {
            if (cmbPiece.SelectedItem is Pieces selectedPiece && cmbRepresentation.SelectedItem is Representation selectedRepresentation)
            {
                string timeOfDay = selectedRepresentation.Rep_time.ToString(@"hh\:mm");

                if (float.TryParse(txtNbPlace.Text, out float nbPlace) && nbPlace > 0)
                {
                    double pricePerPlace = GestionReservations.GetPiecePriceByTime(selectedPiece.Play_id, timeOfDay);

                    // Calculer le tarif total
                    double totalPrice = pricePerPlace * nbPlace;

                    txtTarifReservation.Visible = true;
                    txtTarifReservation.Text = totalPrice.ToString("C2"); // Format monétaire
                }
                else
                {
                    txtTarifReservation.Visible = false;
                }
            }
            else
            {
                txtTarifReservation.Visible = false;
            }
        }

        private void cmbRepresentation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VERIFIER SI L'ITEMS PIECE ET REPRENSENTATION EST BIEN SELECTIONNER
            if (cmbPiece.SelectedItem is Pieces selectedPiece && cmbRepresentation.SelectedItem is Representation selectedRepresentation)
            {
                string timeOfDay = selectedRepresentation.Rep_time.ToString(@"hh\:mm");
                //RECALCULER
                double price = GestionReservations.GetPiecePriceByTime(selectedPiece.Play_id, timeOfDay);

                txtTarifReservation.Visible = true;
                txtTarifReservation.Text = price.ToString("C");
            }
            else
            {
                txtTarifReservation.Visible = false;
            }
        }
    }
}
