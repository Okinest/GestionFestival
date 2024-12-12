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
        public bool SupprimerReservation(int cusId, int repId)
        {
            return ReservationDAO.SupprimerReservation(cusId, repId);
        }

    }
}
