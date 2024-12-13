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
    public partial class FrmGestionReservation : Form
    {
        private GestionReservations gestionReservations;

        public FrmGestionReservation()
        {
            InitializeComponent();
            gestionReservations = new GestionReservations();
            dtgReservations.Columns.Clear();
            dtgReservations.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn NomPiece = new DataGridViewTextBoxColumn();
            NomPiece.DataPropertyName = "Piece_name";
            NomPiece.HeaderText = "Pièce";

            DataGridViewTextBoxColumn DateRepresentation = new DataGridViewTextBoxColumn();
            DateRepresentation.DataPropertyName = "DateTimeFormatted";
            DateRepresentation.HeaderText = "Representation";

            DataGridViewTextBoxColumn LieuRepresentation = new DataGridViewTextBoxColumn();
            LieuRepresentation.DataPropertyName = "Rep_lieu";
            LieuRepresentation.HeaderText = "Lieu";

            DataGridViewTextBoxColumn NomReservation = new DataGridViewTextBoxColumn();
            NomReservation.DataPropertyName = "CustomerFullName";
            NomReservation.HeaderText = "Nom";

            DataGridViewTextBoxColumn NombrePlacesReservation = new DataGridViewTextBoxColumn();
            NombrePlacesReservation.DataPropertyName = "res_num_seats";
            NombrePlacesReservation.HeaderText = "Nombre de Places";

            DataGridViewTextBoxColumn TarifReservation = new DataGridViewTextBoxColumn();   
            TarifReservation.DataPropertyName = "Rate_period";
            TarifReservation.HeaderText = "Tarif";

            dtgReservations.Columns.Add(NomPiece);
            dtgReservations.Columns.Add(DateRepresentation);
            dtgReservations.Columns.Add(LieuRepresentation);
            dtgReservations.Columns.Add(NomReservation);
            dtgReservations.Columns.Add(NombrePlacesReservation);
            dtgReservations.Columns.Add(TarifReservation);

            dtgReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void FrmGestionReservation_Load(object sender, EventArgs e)
        {
            List<Reservation> reservations = gestionReservations.GetListeReservations();
            dtgReservations.DataSource = reservations;
        }
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Hide();
            frmMenu.StartPosition = FormStartPosition.CenterScreen;
            frmMenu.Show();
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            FrmAjoutReservation frmAjoutReservation = new FrmAjoutReservation();
            this.Hide();
            frmAjoutReservation.StartPosition = FormStartPosition.CenterScreen;
            frmAjoutReservation.Show();

        }
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (dtgReservations.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgReservations.SelectedRows[0];
                Reservation res = (Reservation)row.DataBoundItem;


                if (res != null)
                {
                    FrmModifierReservation frmModifierReservation = new FrmModifierReservation(res);
                    this.Hide();
                    frmModifierReservation.StartPosition = FormStartPosition.CenterScreen;
                    frmModifierReservation.Show();
                }
            }
        }
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (dtgReservations.SelectedRows.Count > 0)
            {
                // Récupération des identifiants sélectionnés
                DataGridViewRow selectedRow = dtgReservations.SelectedRows[0];
                Reservation selectedReservation = (Reservation)selectedRow.DataBoundItem;

                int cusId = selectedReservation.Customer.Cus_id; // Assurez-vous que Customer expose Cus_id
                int repId = selectedReservation.Representation.Rep_id; // Assurez-vous que Representation expose Rep_id

                DialogResult dialogResult = MessageBox.Show(
                    "Voulez-vous vraiment supprimer cette réservation ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo
                );

                if (dialogResult == DialogResult.Yes)
                {
                    bool success = gestionReservations.SupprimerReservation(cusId, repId);
                    if (success)
                    {
                        MessageBox.Show("Réservation supprimée avec succès.");
                        dtgReservations.DataSource = gestionReservations.GetListeReservations();
                    }
                    else
                    {
                        MessageBox.Show("La réservation ne peut pas être supprimée car elle est liée à une représentation.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une réservation à supprimer.");
            }
        }

    }
}
