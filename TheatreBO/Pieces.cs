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
        private double play_price;
        private Author auth;
        private Theme theme;
        private Audience aud;
        //private string comp_name;



        //CONSTRUCTEUR SANS ID

        public Pieces(string play_name, string play_description, int play_duration, double play_price, Author auth, Theme theme, Audience aud)
        {
            this.play_name = play_name;
            this.play_description = play_description;
            this.play_duration = play_duration;
            this.play_price = play_price;
            this.auth = auth;
            this.theme = theme;
            this.aud = aud; 
        }

        //CONSTRUCTEUR AVEC ID
        public Pieces(int play_id, string play_name, string play_description, int play_duration, double play_price, Author auth, Theme theme, Audience aud)
        {
            this.play_id = play_id;
            this.play_name = play_name;
            this.play_description = play_description;
            this.play_duration = play_duration;
            this.play_price = play_price;
            this.auth = auth;
            this.theme = theme;
            this.aud = aud;
        }

        public int Play_id { get => play_id; set => play_id = value; }
        public string Play_name { get => play_name; set => play_name = value; }
        public string Play_description { get => play_description; set => play_description = value; }
        public int Play_duration { get => play_duration; set => play_duration = value; }
        public double Play_price { get => play_price; set => play_price = value; }
        public Author Auth { get => auth; set => auth = value; }
        public Theme Theme { get => theme; set => theme = value; }
        public Audience Aud { get => aud; set => aud = value; }

        public string Auth_name => auth != null ? auth.Auth_name : string.Empty; // Expose le nom de l'auteur
        public string Theme_name => theme != null ? theme.Theme_name : string.Empty; // Expose le nom du thème
        public string Aud_categ => aud != null ? aud.Aud_categ : string.Empty; // Expose la catégorie de l'audience
    }

}

