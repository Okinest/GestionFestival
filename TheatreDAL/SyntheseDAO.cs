using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TheatreBO;

namespace TheatreDAL
{
    public class SyntheseDAO
    {
        public static List<Synthese> GetSynthese(DateTime? startDate = null, DateTime? endDate = null)
        {
            List<Synthese> Syntheses = new List<Synthese>();
            string query = "SELECT PLAY.play_id,PLAY.play_name,PLAY.play_description,PLAY.play_duration,PLAY.play_price,AUTHOR.auth_id,AUTHOR.auth_name,THEME.theme_id,THEME.theme_name,AUDIENCE.aud_id,AUDIENCE.aud_categ, " +
                "COUNT(REPRESENTATION.rep_id) AS representation_count, " +
                "SUM(RESERVER.res_num_seats) AS total_spectators, " +
                "CONVERT(float, AVG(RESERVER.res_num_seats)) AS average_spectators, " +
                "CONVERT(float, SUM(RESERVER.res_num_seats * (PLAY.play_price * RATE.rate_value))) AS total_revenue, " +
                "CONVERT(float, AVG(RESERVER.res_num_seats * (PLAY.play_price * RATE.rate_value))) AS average_revenue " +
                "FROM PLAY " +
                "JOIN AUTHOR ON PLAY.auth_id = AUTHOR.auth_id " +
                "JOIN THEME ON PLAY.theme_id = THEME.theme_id " +
                "JOIN AUDIENCE ON PLAY.aud_id = AUDIENCE.aud_id " +
                "JOIN REPRESENTATION ON PLAY.play_id = REPRESENTATION.play_id " +
                "JOIN RESERVER ON REPRESENTATION.rep_id = RESERVER.rep_id " +
                "JOIN RATE ON REPRESENTATION.rate_id = RATE.rate_id ";

            // Ajout de la condition de filtre de date si nécessaire
            if (startDate.HasValue && endDate.HasValue)
            {
                query += "WHERE REPRESENTATION.rep_date BETWEEN @StartDate AND @EndDate ";
            }

            query += "GROUP BY PLAY.play_id,PLAY.play_name,PLAY.play_description,PLAY.play_duration,PLAY.play_price,AUTHOR.auth_id,AUTHOR.auth_name,THEME.theme_id,THEME.theme_name,AUDIENCE.aud_id,AUDIENCE.aud_categ;";
            
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Ajouter les paramètres de dates uniquement si nécessaires
                if (startDate.HasValue && endDate.HasValue)
                {
                    command.Parameters.AddWithValue("@StartDate", startDate.Value);
                    command.Parameters.AddWithValue("@EndDate", endDate.Value);
                }

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Synthese Synthese = new Synthese(
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
                        (int)reader["representation_count"],
                        (int)reader["total_spectators"],
                        (double)reader["average_spectators"],
                        (double)reader["total_revenue"],
                        (double)reader["average_revenue"]
                        );
                    Syntheses.Add(Synthese);
                }
                reader.Close();
            }
            return Syntheses;
        }
    }
}
