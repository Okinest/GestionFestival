using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Place
    {
        private int placeId;
        private string placeName;
        private int placeDistanceParis;

        // CONSTRUCTEUR AVEC ID
        public Place(int placeId, string placeName, int placeDistanceParis)
        {
            this.placeId = placeId;
            this.placeName = placeName;
            this.placeDistanceParis = placeDistanceParis;
        }

        // CONSTRUCTEUR SANS ID
        public Place(string placeName, int placeDistanceParis)
        {
            this.placeName = placeName;
            this.placeDistanceParis = placeDistanceParis;
        }

        public int PlaceId { get { return placeId; } set { placeId = value; } }
        public string PlaceName { get { return placeName; } set { placeName = value; } }
        public int PlaceDistanceParis { get { return placeDistanceParis; } set { placeDistanceParis = value; }
        }
    }
}
