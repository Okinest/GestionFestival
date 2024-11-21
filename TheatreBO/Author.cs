using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Author
    {
        private int auth_id;
        private string auth_name;

        public Author(int auth_id, string auth_name)
        {
            this.auth_id = auth_id;
            this.auth_name = auth_name;
        }

        public int Auth_id { get => auth_id; set => auth_id = value; }
        public string Auth_name { get => auth_name; set => auth_name = value; }
    }
}
