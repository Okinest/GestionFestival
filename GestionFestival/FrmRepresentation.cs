using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TheatreBLL;
using TheatreBO;

namespace GestionFestival
{
    public partial class FrmGestionRepresentation : Form
    {
        private GestionRepresentations gestionRepresentations;

        public FrmGestionRepresentation()
        {
            InitializeComponent();
            gestionRepresentations = new GestionRepresentations();
            dtgRepresentations.Columns.Clear();
            dtgRepresentations.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne Date
            DataGridViewTextBoxColumn Date_column = new DataGridViewTextBoxColumn();
            Date_column.DataPropertyName = "Rep_date";
            Date_column.HeaderText = "Date";

            // Création d'une en-tête de colonne pour la colonne Heure
            DataGridViewTextBoxColumn Heure_column = new DataGridViewTextBoxColumn();
            Heure_column.DataPropertyName = "Rep_time";
            Heure_column.HeaderText = "Heure";

            // Création d'une en-tête de colonne pour la colonne Nombre places maximum
            DataGridViewTextBoxColumn NombrePlaces_column = new DataGridViewTextBoxColumn();
            NombrePlaces_column.DataPropertyName = "Rep_max_seats";
            NombrePlaces_column.HeaderText = "Nombre places maximum";

            // Création d'une en-tête de colonne pour la colonne Lieu
            DataGridViewTextBoxColumn Lieu_column = new DataGridViewTextBoxColumn();
            Lieu_column.DataPropertyName = "Rep_lieu";
            Lieu_column.HeaderText = "Lieu";

            // Création d'une en-tête de colonne pour la colonne Nom (Pièce associée)
            DataGridViewTextBoxColumn Nom_column = new DataGridViewTextBoxColumn();
            Nom_column.DataPropertyName = "Play.Play_name";
            Nom_column.HeaderText = "Nom";

            // AJOUT DE CHAQUE COLONNE
            dtgRepresentations.Columns.Add(Date_column);
            dtgRepresentations.Columns.Add(Heure_column);
            dtgRepresentations.Columns.Add(NombrePlaces_column);
            dtgRepresentations.Columns.Add(Lieu_column);
            dtgRepresentations.Columns.Add(Nom_column);
        }

        private void FrmGestionRepresentation_Load(object sender, EventArgs e)
        {
            List<Representation> listeRepresentations = gestionRepresentations.GetListeRepresentations();
            // Lier la liste des représentations au DataGridView
            dtgRepresentations.DataSource = listeRepresentations;
        }

        // Retourne à FrmMenu
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Hide();
            frmMenu.Show();
        }

        
    }
}
