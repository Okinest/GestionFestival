using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheatreBO
{
    public class Rate
    {
        public int Rate_id { get; set; }
        public string Rate_period { get; set; }
        public int Rate_value { get; set; }

        public Rate(int rate_id, string rate_period, int rate_value)
        {
            Rate_id = rate_id;
            Rate_period = rate_period;
            Rate_value = rate_value;
        }
    }
}



