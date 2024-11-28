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
            string query = "SELECT * FROM REPRESENTATION " +
                           "JOIN PLAY ON REPRESENTATION.play_id = PLAY.play_id " +
                           "JOIN RATE ON REPRESENTATION.rate_id = RATE.rate_id " +
                           "JOIN THEME ON PLAY.theme_id = THEME.theme_id " +
                           "JOIN AUTHOR ON PLAY.auth_id = AUTHOR.auth_id " +
                           "JOIN AUDIENCE ON PLAY.aud_id = AUDIENCE.aud_id;";

            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Créer l'objet Representation et ajouter à la liste
                    Representation representation = new Representation((int)reader["rep_id"], 
                                                                       (DateTime)reader["rep_date"], 
                                                                       (TimeSpan)reader["rep_time"], 
                                                                       (string)reader["rep_lieu"],  
                                                                       (int)reader["rep_max_seats"],
                                                                       new Pieces((int)reader["play_id"],
                                                                                  (string)reader["play_name"],
                                                                                  (string)reader["play_description"],
                                                                                  (int)reader["play_duration"],
                                                                                  (double)reader["play_price"],
                                                                                  new Author((int)reader["auth_id"],
                                                                                             (string)reader["auth_name"]),
                                                                                  new Theme((int)reader["theme_id"],
                                                                                            (string)reader["theme_name"]),
                                                                                  new Audience((int)reader["aud_id"],
                                                                                               (string)reader["aud_categ"])
                                                                                  ),
                                                                                  new Rate((int)reader["rate_id"],
                                                                                           (string)reader["rate_period"],
                                                                                           (int)reader["rate_value"])

                                                                        );
                    representations.Add(representation);
                }

                reader.Close(); // Fermeture explicite du SqlDataReader ici
            }

            return representations;
        }


        public static Rate GetRateById(int id , SqlConnection connection)
        {
            Rate rate = null;
            string query = "SELECT * FROM Rates WHERE rate_id = @rate_id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@rate_id", id);
            SqlDataReader reader2 = command.ExecuteReader();
            if (reader2.Read())
            {
                rate = new Rate(reader2.GetInt32(0), // rate_id
                                reader2.GetString(1), // rate_period
                                reader2.GetInt32(2) // rate_value
                                );
            }
            reader2.Close();
            return rate;
        }
    }
}
