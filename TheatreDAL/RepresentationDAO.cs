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


        // Récupérer la liste des représentations avec rate_period
        /*public static List<Representation> GetRepresentationsWithReservation()
        {
            List<Representation> representations = new List<Representation>();
            string query = "SELECT * FROM REPRESENTATION " +
                           "JOIN PLAY ON REPRESENTATION.play_id = PLAY.play_id " +
                           "JOIN RATE ON REPRESENTATION.rate_id = RATE.rate_id " +
                           "JOIN THEME ON PLAY.theme_id = THEME.theme_id " +
                           "JOIN AUTHOR ON PLAY.auth_id = AUTHOR.auth_id " +
                           "JOIN AUDIENCE ON PLAY.aud_id = AUDIENCE.aud_id" +
                           "JOIN RESERVER ON REPRESENTATION.rep_id = RESERVER.rep_id;"; // AJOUT DE LA JOINTURE VERS RESERVER

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
                                                                                           (int)reader["rate_value"]),
                                                                                  new Reserver((int)reader["cus_id"], //AJOUT DE L'OBJET RESERVER A LA REPRESENTATION
                                                                                            (int)reader["rep_id"],
                                                                                            (int)reader["res_num_seats"])



                                                                        );
                    representations.Add(representation);
                }

                reader.Close();
            }

            return representations;
        }*/



        //METHODE QUI VA PERMETTRE DE VOIR SI REP_ID EST PRESENT DANS LA TABLE RESERVE
        /*public static bool EstReserver(int repId)
        {
            string queryCheckReservation = "SELECT COUNT(*) FROM RESERVER WHERE rep_id = @rep_id";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(queryCheckReservation, connection);
                command.Parameters.AddWithValue("@rep_id", repId);

                int reservationCount = (int)command.ExecuteScalar(); // Retourne le nombre de réservations
                return reservationCount > 0; // Retourne true si des réservations existent
            }
        }*/


        public static int SupprimerRepresentation(int id)
        {
            /*if (EstReserver(id))
            {
                return 1; //1 = Est reserver DONC PAS DE SUPPRESSION, 0 = n'est pas réserver DONC SUPPRESSION
            }*/

            int nbr;
            string queryDeleteRepresentation = "DELETE FROM REPRESENTATION WHERE rep_id = @rep_id";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                // Désactiver temporairement la contrainte de clé étrangère
                string disableForeignKeyConstraint = "ALTER TABLE RESERVER NOCHECK CONSTRAINT FK__RESERVER__rep_id__52593CB8";
                SqlCommand disableCommand = new SqlCommand(disableForeignKeyConstraint, connection);
                disableCommand.ExecuteNonQuery();

                queryDeleteRepresentation = "DELETE FROM REPRESENTATION WHERE rep_id = @rep_id";
                SqlCommand deleteRepresentationCommand = new SqlCommand(queryDeleteRepresentation, connection);
                deleteRepresentationCommand.Parameters.AddWithValue("@rep_id", id);
                nbr = deleteRepresentationCommand.ExecuteNonQuery();

                // Réactiver la contrainte de clé étrangère
                string enableForeignKeyConstraint = "ALTER TABLE RESERVER CHECK CONSTRAINT FK__RESERVER__rep_id__52593CB8";
                SqlCommand enableCommand = new SqlCommand(enableForeignKeyConstraint, connection);
                enableCommand.ExecuteNonQuery();
            }
            return nbr;
        }

    }
}
