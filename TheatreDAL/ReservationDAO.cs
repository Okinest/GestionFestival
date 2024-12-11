﻿using System;
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

        public static int AjoutRepresentation(Reservation rep)
        {
            int result = 0;
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                // INSERTION DANS CUSTOMER
                string query_customer = "INSERT INTO CUSTOMER (cus_id, cus_firstname, cus_lastname, cus_email, cus_phone_number)" +
                                         "VALUES (@cus_id, @cus_firstname, @cus_lastname, @cus_email, @cus_phone_number)";

                SqlCommand command_customer = new SqlCommand(query_customer, connection);
                command_customer.Parameters.AddWithValue("@cus_id", rep.Customer.Cus_id);
                command_customer.Parameters.AddWithValue("@cus_firstname", rep.Customer.Cus_firstname);
                command_customer.Parameters.AddWithValue("@cus_lastname", rep.Customer.Cus_lastname);
                command_customer.Parameters.AddWithValue("@cus_email", rep.Customer.Cus_email);
                command_customer.Parameters.AddWithValue("@cus_phone_number", rep.Customer.Cus_phone_number);

                command_customer.ExecuteNonQuery();

                // INSERTION DANS RESERVER
                string query_reserver = "INSERT INTO RESERVER (cus_id, rep_id, res_num_seats)" +
                                        "VALUES (@cus_id, @rep_id, @res_num_seats)";

                SqlCommand command_reserver = new SqlCommand(query_reserver, connection);
                command_reserver.Parameters.AddWithValue("@cus_id", rep.Customer.Cus_id);
                command_reserver.Parameters.AddWithValue("@rep_id", rep.Representation.Rep_id);
                command_reserver.Parameters.AddWithValue("@res_num_seats", rep.Res_num_seats);

                result = command_reserver.ExecuteNonQuery();
            }
            return result;
        }

        public static int ModifierReservation(Reservation rep)
        {
            int result = 0;
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                string query = "UPDATE RESERVER SET cus_id = @cus_id, rep_id = @rep_id, res_num_seats = @res_num_seats";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@cus_id", rep.Customer);
                command.Parameters.AddWithValue("@rep_id", rep.Representation);
                command.Parameters.AddWithValue("@res_num_seats", rep.Res_num_seats);

                result = command.ExecuteNonQuery();
            }


            return result;
        }

    }
}
