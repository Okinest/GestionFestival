using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;
using System.Data.SqlClient;

namespace TheatreDAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;
        // Accesseur en lecture, renvoi une instance
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }
        public List<Users> GetListeUtilisateurs()
        {
            List<Users> utilisateurs = new List<Users>();
            string query = "SELECT * FROM USERS";

            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //CONSTRUCTEUR CREATION D'UTILISATEUR
                    Users utilisateur = new Users(
                        reader.GetInt32(0),  
                        reader.GetString(1),  
                        reader.GetString(2)  
                    );
                    utilisateurs.Add(utilisateur);
                }
                reader.Close();
            }

            return utilisateurs;
        }

    }
}
