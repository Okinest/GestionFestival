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
        public FrmGestionPièce()
        {
            GestionPieces gestionPieces = new GestionPieces();
            List<Pieces> listePieces = gestionPieces.GetListePieces();
            InitializeComponent();
            dtgPieces.Columns.Clear();
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
