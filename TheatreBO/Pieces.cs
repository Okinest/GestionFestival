using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Pieces
    {

        //ATTRIBUT
        private int play_id;
        private string play_name;
        private string play_description;
        private string play_duration;
        private string play_price;
        private string auth_name;
        private string theme_name;
        private string aud_categ;
        private string comp_name;



        //CONSTRUCTEUR

        public Pieces(int play_id, string play_name, string play_description, string play_duration, string play_price, string auth_name, string theme_name, string aud_categ, string comp_name)
        {
            this.play_id = play_id;
            this.play_name = play_name;
            this.play_description = play_description;
            this.play_duration = play_duration;
            this.play_price = play_price;
            this.auth_name = auth_name;
            this.theme_name = theme_name;
            this.aud_categ = aud_categ;
            this.comp_name = comp_name;
        }

        public int Play_id { get => play_id; set => play_id = value; }
        public string Play_name { get => play_name; set => play_name = value; }
        public string Play_description { get => play_description; set => play_description = value; }
        public string Play_duration { get => play_duration; set => play_duration = value; }
        public string Play_price { get => play_price; set => play_price = value; }
        public string Auth_name { get => auth_name; set => auth_name = value; }
        public string Theme_name { get => theme_name; set => theme_name = value; }
        public string Aud_categ { get => aud_categ; set => aud_categ = value; }
        public string Comp_name { get => comp_name; set => comp_name = value; }


    }
}
