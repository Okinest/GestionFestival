using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Customer
    {
        private int cus_id;
        private string cus_firstname;
        private string cus_lastname;
        private string cus_email;
        private string cus_phone_number;

        public Customer(int cus_id, string cus_firstname, string cus_lastname, string cus_email, string cus_phone_number) 
        {
            this.cus_id = cus_id;
            this.cus_firstname = cus_firstname;
            this.cus_lastname = cus_lastname;
            this.cus_email = cus_email;
            this.cus_phone_number = cus_phone_number;
        }  
        
        public Customer(string cus_firstname, string cus_lastname, string cus_email, string cus_phone_number)
        {
            this.cus_firstname = cus_firstname;
            this.cus_lastname = cus_lastname;
            this.cus_email = cus_email;
            this.cus_phone_number = cus_phone_number;
        }

        public int Cus_id { get { return cus_id; } set { cus_id = value; } }
        public string Cus_firstname { get { return cus_firstname; } set { cus_firstname = value; } }
        public string Cus_lastname { get { return cus_lastname; } set { cus_lastname = value; } }
        public string Cus_email { get { return cus_email; } set { cus_email = value; } }
        public string Cus_phone_number { get { return cus_phone_number; } set { cus_phone_number = value; } }
    }
}
