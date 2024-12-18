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
    public partial class FrmSynthèse : Form
    {
        private GestionSyntheses gestionSyntheses;
        public FrmSynthèse()
        {
            InitializeComponent();
            gestionSyntheses = new GestionSyntheses();
            dtgSynthese.Columns.Clear();

            // Empêcher la génération automatique des colonnes
            dtgSynthese.AutoGenerateColumns = false;

            // Empêcher la modification de la taille des colonnes
            dtgSynthese.AllowUserToResizeColumns = false;

            // Empêcher la modification des cellules
            dtgSynthese.ReadOnly = true;

            // Définir le mode de redimensionnement automatique des colonnes
            dtgSynthese.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Sélection de la ligne entière
            dtgSynthese.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            DataGridViewTextBoxColumn Piece_column = new DataGridViewTextBoxColumn();
            Piece_column.DataPropertyName = "Piece_name";
            Piece_column.HeaderText = "Pièce";

            DataGridViewTextBoxColumn NbRep_column = new DataGridViewTextBoxColumn();
            NbRep_column.DataPropertyName = "NbRepresentation";
            NbRep_column.HeaderText = "Nombre de représentations";

            DataGridViewTextBoxColumn NbSpecTot_column = new DataGridViewTextBoxColumn();
            NbSpecTot_column.DataPropertyName = "NbSpectateur";
            NbSpecTot_column.HeaderText = "Nombre de spectateurs total";

            DataGridViewTextBoxColumn NbSpecMoy_column = new DataGridViewTextBoxColumn();
            NbSpecMoy_column.DataPropertyName = "NbSpectateurMoyen";
            NbSpecMoy_column.HeaderText = "Nombre de spectateurs moyen";

            DataGridViewTextBoxColumn Ca_column = new DataGridViewTextBoxColumn();
            Ca_column.DataPropertyName = "ChiffreAffaire";
            Ca_column.HeaderText = "CA réalisé";
            Ca_column.DefaultCellStyle.Format = "C2";

            DataGridViewTextBoxColumn CaMoy_column = new DataGridViewTextBoxColumn();
            CaMoy_column.DataPropertyName = "ChiffreAffaireMoyen";
            CaMoy_column.HeaderText = "CA réalisé moyen";
            CaMoy_column.DefaultCellStyle.Format = "C2";


            dtgSynthese.Columns.Add(Piece_column);
            dtgSynthese.Columns.Add(NbRep_column);
            dtgSynthese.Columns.Add(NbSpecTot_column);
            dtgSynthese.Columns.Add(NbSpecMoy_column);
            dtgSynthese.Columns.Add(Ca_column);
            dtgSynthese.Columns.Add(CaMoy_column);
        }

        private void FrmSynthèse_Load(object sender, EventArgs e)
        {
            LoadSyntheses();
        }

        // Retourne à FrmMenu
        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Hide();
            frmMenu.StartPosition = FormStartPosition.CenterScreen;
            frmMenu.Show();
        }
        private void LoadSyntheses(DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                // Appel à la méthode GetSynthese avec les dates optionnelles
                List<Synthese> fiteredSyntheses = gestionSyntheses.GetListeSyntheses(startDate, endDate);
                dtgSynthese.DataSource = fiteredSyntheses;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime? startDate = dtpStartDate.Checked ? dtpStartDate.Value.Date : (DateTime?)null;
            DateTime? endDate = dtpEndDate.Checked ? dtpEndDate.Value.Date : (DateTime?)null;

            // Charger les données avec les filtres
            LoadSyntheses(startDate, endDate);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpStartDate.Checked = false;
            dtpEndDate.Checked = false;
            LoadSyntheses();
        }
    }
}
