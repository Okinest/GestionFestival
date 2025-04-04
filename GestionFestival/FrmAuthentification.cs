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
    public partial class FrmAuthentification : Form
    {

        public FrmAuthentification()
        {
            //PERMET DE METTRE DE DETECTER L'ÉVENEMENT
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FrmAuthentification_KeyDown);
            InitializeComponent();
        }

        private void FrmAuthentification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConnexion_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (txtUsername.Focused)
                {
                    txtPassword.Select();
                }
                else if (txtPassword.Focused)
                {
                    btnConnexion.Select();
                }
                else if (btnConnexion.Focused)
                {
                    txtUsername.Select();
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (txtUsername.Focused)
                {
                    btnConnexion.Select();
                }
                else if (btnConnexion.Focused)
                {
                    txtPassword.Select();
                }
                else if (txtPassword.Focused)
                {
                    txtUsername.Select();
                }
                
            }
        }


        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            GestionUtilisateurs gestionUtilisateurs = new GestionUtilisateurs();
            GestionUtilisateurs.ConnexionResultat resultat = gestionUtilisateurs.CheckConnexion(username, password);
            if (resultat == GestionUtilisateurs.ConnexionResultat.Reussi)
            {
                FrmMenu FrmMenu = new FrmMenu();
                this.Hide();
                FrmMenu.StartPosition = FormStartPosition.CenterScreen;
                FrmMenu.Show();
            }
            //SI C'EST VIDE
            else if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                lblinconnu.Visible = false;
                lblpassword.Visible = true;
                lblUtilisteurs.Visible = true;
            }
            //SI INCORRECTE
            else if (resultat == GestionUtilisateurs.ConnexionResultat.UtilisateurIncorrect || resultat == GestionUtilisateurs.ConnexionResultat.MotDePasseIncorrect)
            {
                lblUtilisteurs.Visible = false;
                lblpassword.Visible = false;
                lblinconnu.Visible = true;

            }
            //SI AUTRE ERREUR
            else
            {
                lblUtilisteurs.Visible = false;
                lblpassword.Visible = false;
                lblinconnu.Visible = true;
            }

        }

        private void FrmAuthentification_Load(object sender, EventArgs e)
        {
            txtUsername.Select();
        }

        private void lblconnexion_Click(object sender, EventArgs e)
        {
            txtUsername.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtUsername.Select();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtPassword.Select();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
