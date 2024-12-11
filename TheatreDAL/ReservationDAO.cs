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

            using(SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
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
    }
}
