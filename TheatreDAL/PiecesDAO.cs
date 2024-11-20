﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatreBO;
using System.Data.SqlClient;

namespace TheatreDAL
{
    public class PiecesDAO
    {
        private static PiecesDAO unePieceDAO;

        // Accesseur en lecture, renvoi une instance
        public static PiecesDAO GetPièceDAO()
        {
            if (unePieceDAO == null)
            {
                unePieceDAO = new PiecesDAO();
            }
            return unePieceDAO;
        }
        public List<Pieces> GetPieceInfos()
        {

            List<Pieces> Pièces = new List<Pieces>();
            string query_pieces = "SELECT PLAY.play_id, PLAY.play_name, PLAY.play_description, PLAY.play_duration, PLAY.play_price, AUTHOR.auth_name, THEME.theme_name," +
                "AUDIENCE.aud_categ, COMPANIES.comp_name FROM PLAY JOIN AUTHOR ON PLAY.auth_id = AUTHOR.auth_id JOIN THEME ON PLAY.theme_id = THEME.theme_id" +
                " JOIN AUDIENCE ON PLAY.aud_id = AUDIENCE.aud_id JOIN COMPANIES ON PLAY.comp_id = COMPANIES.comp_id;";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query_pieces, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // FORMATAGE DATE
                    int rawDuration = reader.GetInt32(3); // play_duration
                    TimeSpan duration = TimeSpan.FromMinutes(rawDuration);
                    string formattedDuration = duration.ToString(@"hh\:mm");
                    //AJOUT D'EURO
                    string formattedPrice = reader.GetDouble(4) + "€";
                    //CONSTRUCTEUR CREATION D'UTILISATEUR
                    Pieces Pièce = new Pieces(
                         reader.GetInt32(0),  // play_id
                        reader.GetString(1), // play_name
                        reader.GetString(2), // play_description
                        formattedDuration,  // play_duration + heures
                        formattedPrice,  // play_price + €
                        reader.GetString(5),  // auth_name
                        reader.GetString(6),  // theme_name
                        reader.GetString(7),  // aud_name
                        reader.GetString(8)   // comp_name
                    );
                    Pièces.Add(Pièce);
                }
                reader.Close();
            }
            return Pièces;
        }
    }
}
