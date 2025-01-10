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
                           "JOIN LIEU ON REPRESENTATION.place_id = LIEU.id " +
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
                    Representation representation = new Representation(
                        (int)reader["rep_id"],
                        (DateTime)reader["rep_date"],
                        (TimeSpan)reader["rep_time"],
                        new Place( //AJOUT DE L'OBJET PLACE
                            (int)reader["id"],
                            (string)reader["name"],
                            (int)reader["range"]
                            ),
                        (int)reader["rep_max_seats"],
                        new Pieces(
                            (int)reader["play_id"],
                            (string)reader["play_name"],
                            (string)reader["play_description"],
                            (int)reader["play_duration"],
                            (double)reader["play_price"],
                            new Author(
                                (int)reader["auth_id"],
                                (string)reader["auth_name"]),
                            new Theme(
                                (int)reader["theme_id"],
                                (string)reader["theme_name"]),
                            new Audience(
                                (int)reader["aud_id"],
                                (string)reader["aud_categ"])
                            ),
                        new Rate(
                            (int)reader["rate_id"],
                            (string)reader["rate_period"],
                            (int)reader["rate_value"])
                        ); ;
                    representations.Add(representation);
                }

                reader.Close(); // Fermeture explicite du SqlDataReader ici
            }

            return representations;
        }

        public static int AjoutRepresentation(Representation rep)
        {
            int result = 0;
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                string query = "INSERT INTO REPRESENTATION (rep_date, rep_time, rep_max_seats, play_id, rate_id, place_id) " + //AJOUT AVEC LIEU
                               "VALUES (@rep_date, @rep_time, @rep_max_seats, @play_id, @rate_id, @place_id)";

                SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@rep_date", rep.Rep_date);
                command.Parameters.AddWithValue("@rep_time", rep.Rep_time);
                command.Parameters.AddWithValue("@rep_max_seats", rep.Rep_max_seats);
                command.Parameters.AddWithValue("@play_id", rep.Piece.Play_id);
                command.Parameters.AddWithValue("@rate_id", rep.Rate.Rate_id);
                command.Parameters.AddWithValue("@place_id", rep.Place.Id);
                
                result = command.ExecuteNonQuery();
            }
            return result;
        }
      
        public static int ModifierRepresentation(Representation rep)
        {
            int result = 0;
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                string query = "UPDATE REPRESENTATION SET rep_date = @rep_date, rep_time = @rep_time, rep_max_seats = @rep_max_seats, play_id = @play_id, rate_id = @rate_id, place_id = @place_id " +
                               "WHERE rep_id = @rep_id";

                SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@rep_date", rep.Rep_date);
                command.Parameters.AddWithValue("@rep_time", rep.Rep_time);
                command.Parameters.AddWithValue("@rep_max_seats", rep.Rep_max_seats);
                command.Parameters.AddWithValue("@play_id", rep.Piece.Play_id);
                command.Parameters.AddWithValue("@rate_id", rep.Rate.Rate_id);
                command.Parameters.AddWithValue("@place_id", rep.Place.Id);
                command.Parameters.AddWithValue("@rep_id", rep.Rep_id);
                
                result = command.ExecuteNonQuery();
            }
            return result;
        }

        public static List<Rate> GetRates()
        {
            List<Rate> rates = new List<Rate>();
            string query = "SELECT * FROM RATE";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Rate rate = new Rate(reader.GetInt32(0), // rate_id
                                    reader.GetString(1), // rate_period
                                    reader.GetInt32(2) // rate_value
                                    );
                    rates.Add(rate);
                }
                reader.Close();
            }
            return rates;
        }

        //METHODE POUR AFFICHER LES LIEUX
        public static List<Place> GetPlaces()
        {
            List<Place> places = new List<Place>();
            string query = "SELECT * FROM LIEU";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Place place = new Place(reader.GetInt32(0),
                        reader.GetString(1), // ADRESSE DU LIEU
                        reader.GetInt32(2) // DISTANCE
                        );
                    places.Add(place);
                }
                reader.Close();
            }
            return places;
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
