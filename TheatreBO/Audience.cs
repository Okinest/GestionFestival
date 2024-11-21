using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Audience
    {
        private int aud_id;
        private string aud_categ;

        public Audience(int aud_id, string aud_categ)
        {
            this.aud_id = aud_id;
            this.aud_categ = aud_categ;
        }

        public int Aud_id { get => aud_id; set => aud_id = value; }
        public string Aud_categ { get => aud_categ; set => aud_categ = value; }
    }
}
