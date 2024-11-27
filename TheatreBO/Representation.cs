using System;

namespace TheatreBO
{
    public class Representation
    {
        public int Rep_id { get; set; }
        public DateTime Rep_date { get; set; }
        public TimeSpan Rep_time { get; set; }
        public int Rep_max_seats { get; set; }
        public string Rep_lieu { get; set; }
        public Pieces Play { get; set; }
        public string Rate_period { get; set; }  // Nouvelle propriété pour rate_period

        public Representation(int rep_id, DateTime rep_date, TimeSpan rep_time, int rep_max_seats, string rep_lieu, Pieces play, string rate_period)
        {
            Rep_id = rep_id;
            Rep_date = rep_date;
            Rep_time = rep_time;
            Rep_max_seats = rep_max_seats;
            Rep_lieu = rep_lieu;
            Play = play;
            Rate_period = rate_period;  // Initialiser rate_period
        }
    }
}
