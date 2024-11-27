using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheatreBO;

namespace TheatreDAL
{
    public class RepresentationDAO
    {
        // Récupérer la liste des représentations avec rate_period
        public static List<Representation> GetRepresentations()
        {
            List<Representation> representations = new List<Representation>();
            string query = "SELECT r.rep_id, r.rep_date, r.rep_time, r.rep_max_seats, " +
                           "p.play_id, p.play_name, r.rep_lieu, rt.rate_period " +  // Ajout de rate_period
                           "FROM REPRESENTATION r " +
                           "JOIN PLAY p ON r.play_id = p.play_id " +  // Jointure avec PLAY
                           "JOIN RATE rt ON r.rate_id = rt.rate_id"; // Jointure avec RATE

            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int playId = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);  // play_id est à l'index 4
                    string playName = reader.IsDBNull(5) ? string.Empty : reader.GetString(5); // play_name est à l'index 5

                    // Créer l'objet Pieces (Pièce) associé à la représentation
                    Pieces play = new Pieces(playId, playName, "", 0, 0.0, null, null, null);

                    // Récupérer le rate_period
                    string ratePeriod = reader.IsDBNull(7) ? string.Empty : reader.GetString(7); // rate_period est à l'index 7

                    // Créer l'objet Representation et ajouter à la liste
                    Representation representation = new Representation(
                        reader.GetInt32(0),    // rep_id
                        reader.GetDateTime(1), // rep_date
                        reader.GetTimeSpan(2), // rep_time
                        reader.GetInt32(3),    // rep_max_seats
                        "",                    // rep_lieu (non utilisé ici)
                        play,                  // Pièce associée
                        ratePeriod             // Ajouter rate_period
                    );

                    representations.Add(representation);
                }
                reader.Close();
            }

            return representations;
        }
    }
}
