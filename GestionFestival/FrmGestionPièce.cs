﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using TheatreBO;
using TheatreBLL;

namespace GestionFestival
{
    public partial class FrmGestionPièce : Form
    {
        public FrmGestionPièce()
        {
            GestionPieces gestionPieces = new GestionPieces();
            List<Pieces> listePieces = gestionPieces.GetListePieces();
            InitializeComponent();
            dtgPieces.Columns.Clear();
            dtgPieces.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne  Nom
            DataGridViewTextBoxColumn Nom_column = new DataGridViewTextBoxColumn();
            Nom_column.DataPropertyName = "play_name";
            Nom_column.HeaderText = "Nom";
            // Création d'une en-tête de colonne pour la colonne Description
            DataGridViewTextBoxColumn Description_column = new DataGridViewTextBoxColumn();
            Description_column.DataPropertyName = "play_description";
            Description_column.HeaderText = "Description";
            // Création d'une en-tête de colonne pour la colonne Durée
            DataGridViewTextBoxColumn Duration_column = new DataGridViewTextBoxColumn();
            Duration_column.DataPropertyName = "play_duration";
            Duration_column.HeaderText = "Durée";
            // Création d'une en-tête de colonne pour la colonne Prix
            DataGridViewTextBoxColumn Price_column = new DataGridViewTextBoxColumn();
            Price_column.DataPropertyName = "play_price";
            Price_column.HeaderText = "Prix";
            // Création d'une en-tête de colonne pour la colonne Auteur
            DataGridViewTextBoxColumn Auth_column = new DataGridViewTextBoxColumn();
            Auth_column.DataPropertyName = "auth_name";
            Auth_column.HeaderText = "Auteur";
            // Création d'une en-tête de colonne pour la colonne Theme
            DataGridViewTextBoxColumn Theme_column = new DataGridViewTextBoxColumn();
            Theme_column.DataPropertyName = "theme_name";
            Theme_column.HeaderText = "Thème";
            // Création d'une en-tête de colonne pour la colonne Audience
            DataGridViewTextBoxColumn Audience_column = new DataGridViewTextBoxColumn();
            Audience_column.DataPropertyName = "aud_categ";
            Audience_column.HeaderText = "Audience";

            //AJOUT DE CHAQUE COLUMN
            dtgPieces.Columns.Add(Nom_column);
            dtgPieces.Columns.Add(Description_column);
            dtgPieces.Columns.Add(Duration_column);
            dtgPieces.Columns.Add(Price_column);
            dtgPieces.Columns.Add(Auth_column);
            dtgPieces.Columns.Add(Theme_column);
            dtgPieces.Columns.Add(Audience_column);

            // Lier la liste des pièces au DataGridView
            dtgPieces.DataSource = listePieces;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmModifierPièce frmModifierPièce = new FrmModifierPièce();
            this.Hide();
            frmModifierPièce.Show();
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            this.Hide();
            FrmMenu.Show();
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            FrmAjoutPièce frmAjoutPièce = new FrmAjoutPièce();
            this.Hide();
            frmAjoutPièce.Show();
        }


        private void FrmGestionPièce_Load(object sender, EventArgs e)
        {

        }

        private void dtgPieces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
