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

        public static int AjoutReservation(Reservation rep)
        {
            return ReservationDAO.AjoutReservation(rep);
        }

        public static int ModifierReservation(Reservation rep, Pieces pie, Customer cus) 
        {
            return ReservationDAO.ModifierReservation(rep, pie, cus);
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

        /*public static double GetPiecePriceByTime(int playId, TimeSpan repTime)
        {
            // Déterminer si la représentation est le matin (AM) ou l'après-midi/soir (PM)
            string timeOfDay = repTime.Hours < 12 ? "AM" : "PM";

            // Appeler la méthode DAO pour obtenir le prix ajusté en fonction de la période de la journée (AM/PM)
            double price = GestionReservations.GetPiecePriceByTime(playId, timeOfDay);

            return price;
        }*/

    }
}
