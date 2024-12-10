using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Reservation
    {
        private Customer customer;
        private Representation representation;
        private int res_num_seats;

        public Reservation(Customer customer, Representation representation, int res_num_seats)
        {
            this.customer = customer;
            this.representation = representation;
            this.res_num_seats = res_num_seats;
        }

        public Customer Customer { get { return customer; } set { customer = value; } }
        public Representation Representation { get { return representation; } set { representation = value; } }
        public int Res_num_seats { get { return res_num_seats; } set { res_num_seats = value; } }

        public string Cus_lastname => customer != null ? customer.Cus_lastname : string.Empty; // Expose le nom du client
        public string Piece_name => representation != null ? representation.Piece_name : string.Empty; // Expose le nom de la pièce
        public DateTime Rep_date => representation != null ? representation.Rep_date : DateTime.MinValue; // Expose la date de la représentation
        public string Rep_lieu => representation != null ? representation.Rep_lieu : string.Empty; // Expose le lieu de la représentation
        public string Rate_period => representation != null ? representation.Rate_period : string.Empty; // Expose le tarif de la représentation

    }
}
