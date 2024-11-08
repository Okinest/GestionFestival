using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBO
{
    public class Users
    {
        private int id;
        protected string name;
        protected string password;

        //CONSTRUCTEUR

        public Users(int Id, string Name, string Password)
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
        //SET (EN COMMENTAIRE CAR AUCUNE GESTION DES UTILISATEURS
        /*public void SetId(int id)
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
        }*/
    }
}
