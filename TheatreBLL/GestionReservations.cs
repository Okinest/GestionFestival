using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;
using TheatreDAL;

namespace TheatreBLL
{
    public class GestionReservations
    {
        private static GestionReservations uneGestionReservation;
        private List<Reservation> listeReservations = new List<Reservation>();

        public static GestionReservations GetGestionReservations()
        {
            if (uneGestionReservation == null)
            {
                uneGestionReservation = new GestionReservations();
            }
            return uneGestionReservation;
        }

        public List<Reservation> GetListeReservations()
        {
            listeReservations = ReservationDAO.GetReservations();
            return listeReservations;
        }

        public static int AjoutReservation(Reservation res)
        {
            return ReservationDAO.AjoutReservation(res);
        }

        public static int ModifierReservation(Reservation res) 
        {
            return ReservationDAO.ModifierReservation(res);
        }

        public int GetMaxPlacesForRepresentation(int repId)
        {
            return ReservationDAO.GetMaxPlacesForRepresentation(repId);
        }

        public static double GetPiecePrice(int pieceId)
        {
            double price = ReservationDAO.GetPriceForSelectedPiece(pieceId);
            return price;
        }

        public static double GetPiecePriceByTime(int playId, string timeOfDay)
        {
            return ReservationDAO.GetPiecePriceByTime(playId,timeOfDay);
        }

    }
}
