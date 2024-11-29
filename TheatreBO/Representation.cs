using System;

namespace TheatreBO
{
    public class Representation
    {
        private int rep_id;
        private DateTime rep_date;
        private TimeSpan rep_time;
        private string rep_lieu;
        private int rep_max_seats;
        private Pieces piece;
        private Rate rate;
        //private Reserver rep; AJOUT DE L'OBJET Reserver

        // Constructeur avec ID
        public Representation(int rep_id, DateTime rep_date, TimeSpan rep_time, string rep_lieu, int rep_max_seats, Pieces piece, Rate rate)
        {
            this.rep_id = rep_id;
            this.rep_date = rep_date;
            this.rep_time = rep_time;
            this.rep_lieu = rep_lieu;
            this.rep_max_seats = rep_max_seats;
            this.piece = piece;
            this.rate = rate;
        }

        // Constructeur sans ID
        public Representation(DateTime rep_date, TimeSpan rep_time, string rep_lieu, int rep_max_seats, Pieces piece, Rate rate)
        {
            this.rep_date = rep_date;
            this.rep_time = rep_time;
            this.rep_lieu = rep_lieu;
            this.rep_max_seats = rep_max_seats;
            this.piece = piece;
            this.rate = rate;
        }

        public int Rep_id { get { return rep_id; } set { rep_id = value; } }
        public DateTime Rep_date { get { return rep_date; } set { rep_date = value; } }
        public TimeSpan Rep_time { get { return rep_time; } set { rep_time = value; } }
        public string Rep_lieu { get { return rep_lieu; } set { rep_lieu = value; } }
        public int Rep_max_seats { get { return rep_max_seats; } set { rep_max_seats = value; } }
        public Pieces Piece { get { return piece; } set { piece = value; } }
        public Rate Rate { get { return rate; } set { rate = value; } }

        //public Reserver Rep { get => rep; set => rep = value; }

        public string Piece_name => piece != null ? piece.Play_name : string.Empty; // Expose le nom de la pièce
        public string Rate_period => rate != null ? rate.Rate_period : string.Empty; // Expose la valeur du tarif

        //public int Rep_id => rep !=null ? rep.Rep_id : int.Empty; 
    }
}
