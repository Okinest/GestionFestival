using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;
using TheatreDAL;
using System.Configuration;

namespace TheatreBLL
{
    public class GestionUtilisateurs
    {
        private static GestionUtilisateurs uneGestionUtilisateurs;
        private List<Users> listeAuthentifications = new List<Users>();
        public enum ConnexionResultat
        {
            Reussi,            
            UtilisateurIncorrect,
            MotDePasseIncorrect,
            ErreurInconnue,
        }

        // Accesseur en lecture
        public static GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }
            return uneGestionUtilisateurs;
        }
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Récupère dans une liste des utilisateurs
        public List<Users> GetListeUtilisateurs()
        {
            listeAuthentifications = UtilisateurDAO.GetunUtilisateurDAO().GetListeUtilisateurs();
            return listeAuthentifications;
        }

        // Vérifie la connexion d'un utilisateur
        public ConnexionResultat CheckConnexion(string NameUsers, string PasswordUsers)
        {
            GetListeUtilisateurs();
            foreach (var utilisateur in listeAuthentifications)
            {
                if (utilisateur.GetName() == NameUsers && utilisateur.GetPassword() == PasswordUsers)
                {
                    //CONNEXION REUSSI + Redirection de la page vers "gestion des pièces de théâtres"
                    return ConnexionResultat.Reussi;

                }
                //SI USERNAME INCORRECT
                else if(utilisateur.GetName()!= NameUsers)
                {
                    return ConnexionResultat.UtilisateurIncorrect;
                }
                //SI PASSWORD INCORRECT
                else if(utilisateur.GetPassword() != PasswordUsers)
                {
                    return ConnexionResultat.MotDePasseIncorrect;
                }
                
            }
            //CONNEXION ECHOUÉ + Affichage message d'erreur
            return ConnexionResultat.ErreurInconnue;
        }


    }
}
