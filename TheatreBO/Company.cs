using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Company
    {
        private int comp_id;
        private string comp_name;
        private string comp_region;
        private Director dir;

        public Company(int comp_id, string comp_name, string comp_region, Director dir)
        {
            this.comp_id = comp_id;
            this.comp_name = comp_name;
            this.comp_region = comp_region;
            this.dir = dir;
        }

        public Company(string comp_name, string comp_region, Director dir)
        {
            this.comp_name = comp_name;
            this.comp_region = comp_region;
            this.dir = dir;
        }

        public int Comp_id { get { return comp_id; } set { comp_id = value; } }
        public string Comp_name { get { return comp_name; } set { comp_name = value; } }
        public string Comp_region { get { return comp_region; } set { comp_region = value; } }
        public Director Dir { get { return dir; } set { dir = value; } }

        public string Dir_name => dir != null ? dir.Dir_name : string.Empty;
    }
}
