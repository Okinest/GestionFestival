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
