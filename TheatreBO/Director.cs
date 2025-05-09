using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Director
    {
        private int dir_id;
        private string dir_name;

        public Director(int dir_id, string dir_name)
        {
            this.dir_id = dir_id;
            this.dir_name = dir_name;
        }

        public Director(string dir_name)
        {
            this.dir_name = dir_name;
        }

        public int Dir_id { get { return dir_id; } set { dir_id = value; } }
        public string Dir_name { get { return dir_name; } set { dir_name = value; } }
    }
}
