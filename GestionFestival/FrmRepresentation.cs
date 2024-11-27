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
        }

        private void FrmGestionRepresentation_Load(object sender, EventArgs e)
        {
            // Récupérer la liste des représentations
            List<Representation> listeRepresentations = gestionRepresentations.GetListeRepresentations();

            // Vérifier si des représentations ont été récupérées
            if (listeRepresentations.Count > 0)
            {
                dtgRepresentations.DataSource = listeRepresentations;
            }
            else
            {
                MessageBox.Show("Aucune représentation trouvée.");
            }

            // Rafraîchir le DataGridView pour afficher les données
            dtgRepresentations.Refresh();
        }

        // Méthodes pour les événements des boutons (laisser les méthodes vides pour l'instant)
        // Ces méthodes seront définies plus tard lorsque vous souhaiterez ajouter des fonctionnalités
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Fonctionnalité à ajouter plus tard
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Fonctionnalité à ajouter plus tard
        }
    }
}
