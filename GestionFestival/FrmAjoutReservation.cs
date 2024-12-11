using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFestival
{
    public partial class FrmAjoutReservation : Form
    {

        // ErrorProvider pour afficher les messages d'erreur
        private ErrorProvider errorProvider = new ErrorProvider();
        public FrmAjoutReservation()
        {
            InitializeComponent();
        }

        private void FrmAjoutReservation_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmGestionReservation frmGestionReservation = new FrmGestionReservation();
            this.Hide();
            frmGestionReservation.Show();
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            errorProvider.Clear();

            if(string.IsNullOrWhiteSpace(txtNom.Text))
            {
                errorProvider.SetError(cmbPiece, "Veuillez entrer un nom.");
                isValid = false;
            }

            if(string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                errorProvider.SetError(cmbPiece, "Veuillez entrer un prénom.");
                isValid = false;
            }

            if(string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(cmbPiece, "Veuillez entrer un email.");
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
    }
}
