﻿using System;
using System.Collections.Generic;
using System.Linq;
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

            // Empêcher la modification de la taille des colonnes
            dtgRepresentations.AllowUserToResizeColumns = false;

            // Définir le mode de redimensionnement automatique des colonnes
            dtgRepresentations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Création d'une en-tête de colonne pour la colonne Nom (Pièce associée)
            DataGridViewTextBoxColumn Nom_column = new DataGridViewTextBoxColumn();
            Nom_column.DataPropertyName = "Piece_name";  // Lier à Play_name dans l'objet Play
            Nom_column.HeaderText = "Nom";

            // Création d'une en-tête de colonne pour la colonne Date
            DataGridViewTextBoxColumn Date_column = new DataGridViewTextBoxColumn();
            Date_column.DataPropertyName = "Rep_date";  // Lier à Rep_date
            Date_column.HeaderText = "Date";

            // Création d'une en-tête de colonne pour la colonne Heure
            DataGridViewTextBoxColumn Heure_column = new DataGridViewTextBoxColumn();
            Heure_column.DataPropertyName = "Rep_time";  // Lier à Rep_time
            Heure_column.HeaderText = "Heure";

            // Création d'une en-tête de colonne pour la colonne Nombre places maximum
            DataGridViewTextBoxColumn NombrePlaces_column = new DataGridViewTextBoxColumn();
            NombrePlaces_column.DataPropertyName = "Rep_max_seats";  // Lier à Rep_max_seats
            NombrePlaces_column.HeaderText = "Nombre places maximum";

            // Création d'une en-tête de colonne pour la colonne Lieu
            DataGridViewTextBoxColumn Lieu_column = new DataGridViewTextBoxColumn();
            Lieu_column.DataPropertyName = "Rep_lieu";  // Lier à Rep_lieu
            Lieu_column.HeaderText = "Lieu";

            // Création d'une en-tête de colonne pour la colonne Rate_period
            DataGridViewTextBoxColumn RatePeriod_column = new DataGridViewTextBoxColumn();
            RatePeriod_column.DataPropertyName = "Rate_period";  // Lier à Rate_period
            RatePeriod_column.HeaderText = "Tarif";

            // AJOUT DE CHAQUE COLONNE
            dtgRepresentations.Columns.Add(Nom_column);  // Ajouter la colonne "Nom"
            dtgRepresentations.Columns.Add(Date_column);
            dtgRepresentations.Columns.Add(Heure_column);
            dtgRepresentations.Columns.Add(NombrePlaces_column);
            dtgRepresentations.Columns.Add(Lieu_column);
            dtgRepresentations.Columns.Add(RatePeriod_column);  // Ajouter la colonne "Période du tarif"

            dtgRepresentations.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //POUR SELECTIONNER TOUTES LA LIGNE
        }
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            // Récupérer la période sélectionnée
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // Récupérer la pièce de théâtre saisie
            string pieceName = txtSearchPiece.Text.ToLower(); // Convertir en minuscule pour comparaison insensible à la casse

            // Filtrer les représentations
            List<Representation> filteredRepresentations = gestionRepresentations.GetListeRepresentations();

            // Appliquer le filtre par date
            filteredRepresentations = filteredRepresentations
                .Where(rep => rep.Rep_date >= startDate && rep.Rep_date <= endDate)
                .ToList();

            // Appliquer le filtre par pièce de théâtre
            if (!string.IsNullOrEmpty(pieceName))
            {
                filteredRepresentations = filteredRepresentations
                    .Where(rep => rep.Piece_name.ToLower().Contains(pieceName))
                    .ToList();
            }

            // Lier les données filtrées au DataGridView
            dtgRepresentations.DataSource = filteredRepresentations;
        }

        private void FrmGestionRepresentation_Load(object sender, EventArgs e)
        {
            List<Representation> listeRepresentations = gestionRepresentations.GetListeRepresentations();
            // Lier la liste des représentations au DataGridView
            dtgRepresentations.DataSource = listeRepresentations;
        }

        // Ouvre FrmAjoutRepresentation
        private void BtnAjout_Click(object sender, EventArgs e)
        {
            FrmAjoutRepresentation frmAjoutRepresentation = new FrmAjoutRepresentation();
            this.Hide();
            frmAjoutRepresentation.StartPosition = FormStartPosition.CenterScreen;
            frmAjoutRepresentation.Show();
        }
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if(dtgRepresentations.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgRepresentations.SelectedRows[0];
                Representation rep = (Representation)row.DataBoundItem;

                if (rep != null)
                {
                    FrmModifierRepresentation frmModifierRepresentation = new FrmModifierRepresentation(rep);
                    this.Hide();
                    frmModifierRepresentation.StartPosition = FormStartPosition.CenterScreen;
                    frmModifierRepresentation.Show();
                }
            }
        }

        // Retourne à FrmMenu
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Hide();
            frmMenu.StartPosition = FormStartPosition.CenterScreen;
            frmMenu.Show();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            //SI UNE LIGNE EST SELECTIONNÉE
            if(dtgRepresentations.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgRepresentations.SelectedRows[0];
                Representation selectedRepresentation = (Representation)selectedRow.DataBoundItem;

                // Demande de confirmation
                DialogResult dialogResult = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer la représentation '{selectedRepresentation.Piece_name}' ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int result = GestionRepresentations.SupprimerRepresentation(selectedRepresentation.Rep_id);
                    if (result > 0)
                    {
                        MessageBox.Show("Pièce supprimée avec succès.", "Suppression de la pièce", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmGestionRepresentation_Load(sender, e); // Recharger les pièces après suppression
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression de la représentation.", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une représentation à supprimer.", "Sélection d'une représentation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
