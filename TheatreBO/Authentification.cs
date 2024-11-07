using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Authentification
    {
        private int id;
        private string name;
        private string password;

        //CONSTRUCTEUR

        public Authentification(int Id, string Name, string Password)
        {
            id = Id;
            name = Name;
            password = Password;
        }

        //GET
        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        
        public string GetPassword()
        {
            return password;
        }
        //SET
        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }
    }
}
