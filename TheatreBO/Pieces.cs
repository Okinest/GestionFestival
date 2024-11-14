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
        private int play_duration;
        private decimal play_price;
        private int auth_id;
        private int theme_id;
        private int aud_id;
        private int comp_id;



        //CONSTRUCTEUR

        public Pieces(int play_id, string play_name, string play_description, int play_duration, decimal play_price, int auth_id, int theme_id, int aud_id, int comp_id)
        {
            this.play_id = play_id;
            this.play_name = play_name;
            this.play_description = play_description;
            this.play_duration = play_duration;
            this.play_price = play_price;
            this.auth_id = auth_id;
            this.theme_id = theme_id;
            this.aud_id = aud_id;
            this.comp_id = comp_id;
        }

        public int Play_id { get => play_id; set => play_id = value; }
        public string Play_name { get => play_name; set => play_name = value; }
        public string Play_description { get => play_description; set => play_description = value; }
        public int Play_duration { get => play_duration; set => play_duration = value; }
        public decimal Play_price { get => play_price; set => play_price = value; }
        public int Auth_id { get => auth_id; set => auth_id = value; }
        public int Theme_id { get => theme_id; set => theme_id = value; }
        public int Aud_id { get => aud_id; set => aud_id = value; }
        public int Comp_id { get => comp_id; set => comp_id = value; }


    }
}
