using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheatreBO;
using TheatreBLL;

namespace GestionFestival
{
    public partial class FrmAjoutPièce : Form
    {
        private static GestionPieces uneGestionPiece = new GestionPieces();
        public FrmAjoutPièce()
        {
            InitializeComponent();
        }
        private void FrmAjoutPièce_Load(object sender, EventArgs e)
        {
            List<Audience> audienceList = uneGestionPiece.GetListeAudiences();
            cmbAudience.DataSource = audienceList;
            cmbAudience.DisplayMember = "Aud_categ";
            cmbAudience.ValueMember = "Aud_id";
         }

        private void btnretour_Click(object sender, EventArgs e)
        {
            FrmGestionPièce frmGestionPièce = new FrmGestionPièce();
            this.Hide();
            frmGestionPièce.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
