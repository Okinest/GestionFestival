using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;
using TheatreDAL;

namespace TheatreBLL
{
    public class GestionSyntheses
    {
        private static GestionSyntheses uneGestionSynthese;
        private List<Synthese> listeSyntheses = new List<Synthese>();

        public static GestionSyntheses GetSyntheses()
        {
            if (uneGestionSynthese == null)
            {
                uneGestionSynthese = new GestionSyntheses();
            }
            return uneGestionSynthese;
        }

        public List<Synthese> GetListeSyntheses(DateTime? startDate = null, DateTime? endDate = null)
        {
            listeSyntheses = SyntheseDAO.GetSynthese(startDate, endDate);
            return listeSyntheses;
        }

    }
}
