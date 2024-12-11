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
            DateRepresentation.DataPropertyName = "Rep_date";
            DateRepresentation.HeaderText = "Representation";

            DataGridViewTextBoxColumn LieuRepresentation = new DataGridViewTextBoxColumn();
            LieuRepresentation.DataPropertyName = "Rep_lieu";
            LieuRepresentation.HeaderText = "Lieu";

            DataGridViewTextBoxColumn NomReservation = new DataGridViewTextBoxColumn();
            NomReservation.DataPropertyName = "Cus_lastname";
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
            frmMenu.Show();
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            FrmAjoutReservation frmAjoutReservation = new FrmAjoutReservation();
            this.Hide();
            frmAjoutReservation.Show();

        }
        private void BtnModifier_Click(object sender, EventArgs e)
        {

            FrmModifierReservation frmModifierReservation = new FrmModifierReservation();
            this.Hide();
            frmModifierReservation.Show();



        }
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
