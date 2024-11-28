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
            string query = "SELECT r.rep_id, r.rep_date, r.rep_time, r.rep_lieu, r.rep_max_seats, p.play_id, rt.rate_id FROM REPRESENTATION r JOIN PLAY p ON r.play_id = p.play_id JOIN RATE rt ON r.rate_id = rt.rate_id;"; // Jointure avec RATE

            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Créer l'objet Pièce associé à la représentation
                    Pieces piece = PiecesDAO.GetPieceById((int)reader["play_id"]);
                    Rate rate = GetRateById((int)reader["rate_id"]);

                    // Créer l'objet Representation et ajouter à la liste
                    Representation representation = new Representation(
                        reader.GetInt32(0),    // rep_id
                        reader.GetDateTime(1), // rep_date
                        reader.GetTimeSpan(2), // rep_time
                        reader.GetString(3),    // rep_lieu
                        reader.GetInt32(4),                    // rep_max_seats
                        piece,                  // Pièce associée
                        rate         // Ajouter rate_period
                    );

                    representations.Add(representation);
                }

                reader.Close(); // Fermeture explicite du SqlDataReader ici
            }

            return representations;
        }


        public static Rate GetRateById(int id)
        {
            Rate rate = null;
            string query = "SELECT * FROM Rates WHERE rate_id = @rate_id";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@rate_id", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    rate = new Rate(reader.GetInt32(0), // rate_id
                                    reader.GetString(1), // rate_period
                                    reader.GetInt32(2) // rate_value
                                    );
                }
                reader.Close();
            }
            return rate;
        }
    }
}
