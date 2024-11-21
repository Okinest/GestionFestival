using System;
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
        private List<Pieces> listePieces;

        public FrmGestionPièce()
        {
            InitializeComponent();
        }

        private void FrmGestionPièce_Load(object sender, EventArgs e)
        {
            // Charger la liste des pièces
            listePieces = GestionPieces.GetPieces().GetListePieces();

            // Afficher les pièces dans le DataGridView
            foreach (var piece in listePieces)
            {
                dtgPieces.Rows.Add(piece.Play_name, piece.Play_description, piece.Theme_name, piece.Play_duration, piece.Aud_categ, piece.Auth_name);
            }
        }

        private void dtgPieces_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgPieces.Rows[e.RowIndex];
                string nom = row.Cells["colNom"].Value.ToString();

                Pieces piece = listePieces.Find(p => p.Play_name == nom);

                if (piece != null)
                {
                    FrmModifierPièce frmModifier = new FrmModifierPièce(piece);
                    this.Hide();
                    frmModifier.Show();
                }
            }
        }
        private void dtgPieces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Logique lorsque l'utilisateur clique sur une cellule du DataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgPieces.Rows[e.RowIndex];
                string nom = row.Cells["colNom"].Value.ToString();

                // Exemple : Afficher les informations de la pièce dans une nouvelle fenêtre
                Pieces piece = listePieces.Find(p => p.Play_name == nom);
                if (piece != null)
                {
                    FrmModifierPièce frmModifier = new FrmModifierPièce(piece);
                    this.Hide();
                    frmModifier.Show();
                }
            }
        }
        private void btnajout_Click(object sender, EventArgs e)
        {
            // Logique pour ajouter une nouvelle pièce
            FrmModifierPièce frmAjouter = new FrmModifierPièce(null); // null si c'est pour ajouter
            this.Hide();
            frmAjouter.Show();
        }
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (dtgPieces.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgPieces.SelectedRows[0];
                string nom = selectedRow.Cells["colNom"].Value.ToString();

                // Rechercher la pièce correspondante
                Pieces piece = listePieces.Find(p => p.Play_name == nom);
                if (piece != null)
                {
                    FrmModifierPièce frmModifier = new FrmModifierPièce(piece);
                    this.Hide();
                    frmModifier.Show();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une pièce à modifier.");
            }
        }


        private void btnretour_Click(object sender, EventArgs e)
        {
            this.Close(); // Retour à la fenêtre précédente
        }
    }
}
