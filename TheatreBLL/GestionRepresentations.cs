using System;
using System.Collections.Generic;
using TheatreBO;
using TheatreDAL;

namespace TheatreBLL
{
    public class GestionRepresentations
    {
        private static GestionRepresentations uneGestionRepresentation;
        private List<Representation> listeRepresentations = new List<Representation>();
        private List<Rate> listeRates = new List<Rate>();
        private List<Place> listePlaces = new List<Place>();

        // Accesseur pour obtenir une instance unique de GestionRepresentations
        public static GestionRepresentations GetRepresentations()
        {
            if (uneGestionRepresentation == null)
            {
                uneGestionRepresentation = new GestionRepresentations();
            }
            return uneGestionRepresentation;
        }

        public static int AjoutRepresentation(Representation rep)
        {
            return RepresentationDAO.AjoutRepresentation(rep);
        }
        public static int ModifierRepresentation(Representation rep)
        {
            return RepresentationDAO.ModifierRepresentation(rep);
        }

        // Récupère la liste des représentations
        public List<Representation> GetListeRepresentations()
        {
            listeRepresentations = RepresentationDAO.GetRepresentations(); // Appel au DAO pour récupérer les représentations
            return listeRepresentations;
        }

//         public List<Representation> GetListeRepresentationsWithReservation()
//         {
//             listeRepresentations = RepresentationDAO.GetRepresentations(); // Appel au DAO pour récupérer les représentations
//             return listeRepresentations;
//         }

        public static int SupprimerRepresentation(int id)
        {
            return RepresentationDAO.SupprimerRepresentation(id);
        }

        public List<Rate> GetListeRates()
        {
            listeRates = RepresentationDAO.GetRates();
            return listeRates;
        }

        public List<Place> GetListePlaces()
        {
            listePlaces = RepresentationDAO.GetPlaces();
            return listePlaces;
        }
    }
}
