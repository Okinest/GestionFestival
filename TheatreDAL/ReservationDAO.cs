using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;

namespace TheatreDAL
{
    public class ReservationDAO
    {
        public static List<Reservation> GetReservations()
        {
            List<Reservation> reservations = new List<Reservation>();
            string query = "SELECT * FROM RESERVER " +
                           "JOIN CUSTOMER ON RESERVER.cus_id = CUSTOMER.cus_id " +
                           "JOIN REPRESENTATION ON RESERVER.rep_id = REPRESENTATION.rep_id " +
                           "JOIN PLAY ON REPRESENTATION.play_id = PLAY.play_id " +
                           "JOIN RATE ON REPRESENTATION.rate_id = RATE.rate_id " +
                           "JOIN THEME ON PLAY.theme_id = THEME.theme_id " +
                           "JOIN AUTHOR ON PLAY.auth_id = AUTHOR.auth_id " +
                           "JOIN AUDIENCE ON PLAY.aud_id = AUDIENCE.aud_id;";

            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Reservation reservation = new Reservation(
                        new Customer(
                            (int)reader["cus_id"],
                            (string)reader["cus_lastname"],
                            (string)reader["cus_firstname"],
                            (string)reader["cus_email"],
                            (string)reader["cus_phone_number"]),
                        new Representation(
                            (int)reader["rep_id"],
                            (DateTime)reader["rep_date"],
                            (TimeSpan)reader["rep_time"],
                            (string)reader["rep_lieu"],
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
                                (int)reader["rate_value"])),
                        (int)reader["res_num_seats"]);
                    reservations.Add(reservation);
                }
                reader.Close();
            }

            return reservations;
        }
      
        public static int AjoutReservation(Reservation rep)
        {
            int result = 0;
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                // INSERTION DANS CUSTOMER
                string query_customer = "INSERT INTO CUSTOMER (cus_firstname, cus_lastname, cus_email, cus_phone_number) " +
                                         "VALUES (@cus_firstname, @cus_lastname, @cus_email, @cus_phone_number); " +
                                         "SELECT SCOPE_IDENTITY();";  // Récupérer l'ID généré pour le client

                SqlCommand command_customer = new SqlCommand(query_customer, connection);
                command_customer.Parameters.AddWithValue("@cus_firstname", rep.Customer.Cus_firstname);
                command_customer.Parameters.AddWithValue("@cus_lastname", rep.Customer.Cus_lastname);
                command_customer.Parameters.AddWithValue("@cus_email", rep.Customer.Cus_email);
                command_customer.Parameters.AddWithValue("@cus_phone_number", rep.Customer.Cus_phone_number);

                var cusId = command_customer.ExecuteScalar(); //RECUPERE LE ID DU CUSTOMER

                if (cusId != null)
                {
                    rep.Customer.Cus_id = Convert.ToInt32(cusId); //CONVERTI LE ID EN INT

                    // INSERTION DANS RESERVER
                    string query_reserver = "INSERT INTO RESERVER (cus_id, rep_id, res_num_seats) " +
                                            "VALUES (@cus_id, @rep_id, @res_num_seats)";

                    SqlCommand command_reserver = new SqlCommand(query_reserver, connection);
                    command_reserver.Parameters.AddWithValue("@cus_id", rep.Customer.Cus_id);
                    command_reserver.Parameters.AddWithValue("@rep_id", rep.Representation.Rep_id);
                    command_reserver.Parameters.AddWithValue("@res_num_seats", rep.Res_num_seats);

                    result = command_reserver.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception("Erreur lors de la création du client. ID non généré.");
                }
            }
            return result;
        }


        public static int ModifierReservation(Reservation res)
        {
            int result = 0;
  
            try
            {
                using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
                {
                    // Mise à jour de CUSTOMER
                    string query_customer = "UPDATE CUSTOMER SET cus_firstname = @cus_firstname, cus_lastname = @cus_lastname, cus_email = @cus_email, cus_phone_number = @cus_phone_number WHERE cus_id = @cus_id";
                    SqlCommand command_customer = new SqlCommand(query_customer, connection);
                    command_customer.Parameters.AddWithValue("@cus_id", res.Customer.Cus_id);
                    command_customer.Parameters.AddWithValue("@cus_firstname", res.Customer.Cus_firstname);
                    command_customer.Parameters.AddWithValue("@cus_lastname", res.Customer.Cus_lastname);
                    command_customer.Parameters.AddWithValue("@cus_email", res.Customer.Cus_email);
                    command_customer.Parameters.AddWithValue("@cus_phone_number", res.Customer.Cus_phone_number);
                    command_customer.ExecuteNonQuery();

                    // Mise à jour de RESERVER
                    string query_reserver = "UPDATE RESERVER SET cus_id = @cus_id, rep_id = @rep_id, res_num_seats = @res_num_seats WHERE cus_id = @cus_id AND rep_id = @rep_id";
                    SqlCommand command_reserver = new SqlCommand(query_reserver, connection);
                    command_reserver.Parameters.AddWithValue("@cus_id", res.Customer.Cus_id);
                    command_reserver.Parameters.AddWithValue("@rep_id", res.Representation.Rep_id);
                    command_reserver.Parameters.AddWithValue("@res_num_seats", res.Res_num_seats);
                    result = command_reserver.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur est survenue lors de la mise à jour de la réservation : " + ex.Message);
                Console.WriteLine("Détails de l'exception : " + ex.StackTrace);
            }

            return result;
        }


        //REQUETE QUI RENVOIE LE NOMBRE DE PLACE MAXIMUM
        public static int GetMaxPlacesForRepresentation(int repId)
        {
            int maxPlaces = 0;

            try
            {
                using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
                {
                    string query = "SELECT rep_max_seats FROM REPRESENTATION WHERE rep_id = @rep_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@rep_id", repId);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        maxPlaces = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération du nombre maximum de places : " + ex.Message);
            }

            return maxPlaces;
        }

        //RECUPERER LES PRIX EN FONCTION DE LA PIECE
        public static double GetPriceForSelectedPiece(int pieceId)
        {
            double price = 0.0;
            string query = "SELECT play_price FROM PLAY WHERE play_id = @play_id";

            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@play_id", pieceId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    price = (double)reader["play_price"];
                }

                reader.Close();
            }

            return price;
        }

        //RECUPERER L'HEURE
        public static double GetPiecePriceByTime(int playId, string timeOfDay)
        {
            double price = 0;
            string query = @"SELECT PLAY.play_price, RATE.rate_id, RATE.rate_value 
             FROM PLAY 
             JOIN REPRESENTATION ON PLAY.play_id = REPRESENTATION.play_id
             JOIN RATE ON REPRESENTATION.rate_id = RATE.rate_id 
             WHERE PLAY.play_id = @playId";

            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@playId", playId);
                cmd.Parameters.AddWithValue("@timeOfDay", timeOfDay);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    double basePrice = Convert.ToDouble(reader["play_price"]);
                    int rateValue = Convert.ToInt32(reader["rate_value"]);
                    int rateId = Convert.ToInt32(reader["rate_id"]);

      
                    switch (rateId)
                    {
                        case 1: // SEMAINE AM : augmentation de 5%
                            price = basePrice + (basePrice * rateValue / 100.0);
                            break;

                        case 2: // SEMAINE PM : augmentation de 10%
                            price = basePrice + (basePrice * rateValue / 100.0);
                            break;

                        case 3: // WEEK-END AM : réduction de 5%
                            price = basePrice - (basePrice * 0.05);
                            break;

                        case 4: // WEEK-END PM : augmentation de 15%
                            price = basePrice + (basePrice * rateValue / 100.0);
                            break;

                        default:
                            price = basePrice;
                            break;
                    }
                }

                reader.Close();
            }

            return price;
        }
      
        public static bool SupprimerReservation(int cusId, int repId)
        {
            string queryDelete = "DELETE FROM RESERVER WHERE cus_id = @cusId AND rep_id = @repId";

            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand cmdDelete = new SqlCommand(queryDelete, connection);
                cmdDelete.Parameters.AddWithValue("@cusId", cusId);
                cmdDelete.Parameters.AddWithValue("@repId", repId);

                int rowsAffected = cmdDelete.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
      
    }
}
