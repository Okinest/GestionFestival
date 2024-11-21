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
    public class GestionPieces
    {

        private static GestionPieces uneGestionPiece;
        private List<Pieces> listePieces = new List<Pieces>();
        private List<Theme> listeThemes = new List<Theme>();
        private List<Audience> listeAudience= new List<Audience>();
        private List<Author> listeAuthor = new List<Author>();

        //Ascesseur lecture
        private static GestionPieces GetPieces()
        {
            if (uneGestionPiece == null)
            {
                uneGestionPiece = new GestionPieces();
            }

            return uneGestionPiece;
        }

        public List<Pieces> GetListePieces()
        {
            listePieces = PiecesDAO.GetPièceDAO().GetPieceInfos();
            return listePieces;
        }

        /*Récupère les thèmes*/
        public List<Theme> GetListeThemes()
        {
            listeThemes = PiecesDAO.GetThemes();
            return listeThemes;
        }

        //Récupère l'audience
        public List<Audience> GetListeAudiences()
        {
            listeAudience = PiecesDAO.GetAudiences();
            return listeAudience;
        }

        //Récupère les auteurs
        public List<Author> GetListeAuthor()
        {
            listeAuthor = PiecesDAO.GetAuthors();
            return listeAuthor;
        }

        public static int CreerPieces(Pieces piece)
        {
            return PiecesDAO.AjoutPieces(piece);
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
    }
}
