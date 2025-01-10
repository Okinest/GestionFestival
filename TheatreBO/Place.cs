using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Place
    {
        //PROPRIETÉ
        private int id;
        private string name;
        private int range;

        //CONSTRUCTEUR
        public Place(int id, string name, int range)
        {
            this.id = id;
            this.name = name;
            this.range = range;
        }

        //GETTEUR & SETTEUR
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Range { get => range; set => range = value; }

    }
}
