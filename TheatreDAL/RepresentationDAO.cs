using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
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
                           "JOIN PLACE ON REPRESENTATION.rep_lieu = PLACE.place_id " + // AJOUT DE LA JOINTURE VERS PLACE
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
                        // AJOUT DE L'OBJET PLACE A LA REPRESENTATION
                        new Place(
                            (int)reader["place_id"],
                            (string)reader["place_name"],
                            (int)reader["place_distance_paris"]),
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
                        );
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
                string query = "INSERT INTO REPRESENTATION (rep_date, rep_time, rep_max_seats, play_id, rate_id, rep_lieu) " +
                               "VALUES (@rep_date, @rep_time, @rep_max_seats, @play_id, @rate_id, @rep_lieu)";

                SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@rep_date", rep.Rep_date);
                command.Parameters.AddWithValue("@rep_time", rep.Rep_time);
                command.Parameters.AddWithValue("@rep_max_seats", rep.Rep_max_seats);
                command.Parameters.AddWithValue("@play_id", rep.Piece.Play_id);
                command.Parameters.AddWithValue("@rate_id", rep.Rate.Rate_id);
                command.Parameters.AddWithValue("@rep_lieu", rep.Place.PlaceId);
                
                result = command.ExecuteNonQuery();
            }
            return result;
        }
      
        public static int ModifierRepresentation(Representation rep)
        {
            int result = 0;
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                string query = "UPDATE REPRESENTATION SET rep_date = @rep_date, rep_time = @rep_time, rep_max_seats = @rep_max_seats, play_id = @play_id, rate_id = @rate_id, rep_lieu = @rep_lieu " +
                               "WHERE rep_id = @rep_id";

                SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@rep_date", rep.Rep_date);
                command.Parameters.AddWithValue("@rep_time", rep.Rep_time);
                command.Parameters.AddWithValue("@rep_max_seats", rep.Rep_max_seats);
                command.Parameters.AddWithValue("@play_id", rep.Piece.Play_id);
                command.Parameters.AddWithValue("@rate_id", rep.Rate.Rate_id);
                command.Parameters.AddWithValue("@rep_lieu", rep.Place.PlaceId);
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

        public static List<Place> GetPlaces()
        {
            List<Place> places = new List<Place>();
            string query = "SELECT * FROM PLACE";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Place place = new Place((int)reader["place_id"], // place_id
                                    (string)reader["place_name"], // place_name
                                    (int)reader["place_distance_paris"] // place_distance_paris
                                    );
                    places.Add(place);
                }
                reader.Close();
            }
            return places;
        }

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