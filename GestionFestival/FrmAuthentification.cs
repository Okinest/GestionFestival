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
    public partial class FrmAuthentification : Form
    {
        public FrmAuthentification()
        {
            InitializeComponent();
        }
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            GestionUtilisateurs gestionUtilisateurs = new GestionUtilisateurs();
            GestionUtilisateurs.ConnexionResultat resultat = gestionUtilisateurs.CheckConnexion(username, password);
            if (resultat == GestionUtilisateurs.ConnexionResultat.Reussi)
            {
                FrmGestionPièce GestionForm = new FrmGestionPièce();
                this.Hide();
                GestionForm.Show();
            }

            else if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                lblinconnu.Visible = true;
                lblpassword.Visible = true;
                lblUtilisteurs.Visible = true;
            }
            else if (resultat == GestionUtilisateurs.ConnexionResultat.UtilisateurIncorrect)
            {
                lblUtilisteurs.Visible = true;
                lblpassword.Visible = false;

            }
            else if (resultat == GestionUtilisateurs.ConnexionResultat.MotDePasseIncorrect)
            {
                lblUtilisteurs.Visible = false;
                lblpassword.Visible = true;
            }

            else if (resultat == GestionUtilisateurs.ConnexionResultat.ErreurInconnue)
            {
                lblUtilisteurs.Visible = false;
                lblpassword.Visible = false;
                lblinconnu.Visible = true;
            }
            //SI C'EST VIDE
            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
