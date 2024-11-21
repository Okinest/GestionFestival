using System;
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
            string query_pieces = "SELECT PLAY.play_name, PLAY.play_description, PLAY.play_duration, PLAY.play_price, AUTHOR.auth_id, AUTHOR.auth_name,THEME.theme_id, THEME.theme_name," +
                "AUDIENCE.aud_id, AUDIENCE.aud_categ FROM PLAY JOIN AUTHOR ON PLAY.auth_id = AUTHOR.auth_id JOIN THEME ON PLAY.theme_id = THEME.theme_id" +
                " JOIN AUDIENCE ON PLAY.aud_id = AUDIENCE.aud_id";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query_pieces, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // FORMATAGE DATE
                    int rawDuration = reader.GetInt32(2); // play_duration
                    TimeSpan duration = TimeSpan.FromMinutes(rawDuration);
                    string formattedDuration = duration.ToString(@"hh\:mm");
                    //AJOUT D'EURO
                    string formattedPrice = reader.GetDouble(3) + "€";
                    //CONSTRUCTEUR CREATION D'UTILISATEUR
                    Pieces Pièce = new Pieces(
                        reader.GetString(0), // play_name
                        reader.GetString(1), // play_description
                        formattedDuration,  // play_duration + heures
                        formattedPrice,  // play_price + €
                        new Author(reader.GetInt32(4),reader.GetString(5)),  // auth_name
                        new Theme(reader.GetInt32(6), reader.GetString(7)),  // theme_name
                        new Audience(reader.GetInt32(8), reader.GetString(9))  // aud_name
                    );
                    Pièces.Add(Pièce);
                }
                reader.Close();
            }
            return Pièces;
        }
        public static int AjoutPieces(Pieces unePiece)
        {
            int nbr;
            string queryAddPieces = "INSERT INTO PLAY SET PLAY.play_name, PLAY.play_description, PLAY.play_duration, PLAY.play_price, AUTHOR.auth_name, THEME.theme_name, AUDIENCE.aud_categ VALUES(@play_name, @play_description," +
                "@play_duration, @play_price, @auth_name, @theme_name, @aud_categ";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(queryAddPieces, connection);
                SqlDataReader reader = command.ExecuteReader();

                command.Parameters.AddWithValue("@play_name", unePiece.Play_name);
                command.Parameters.AddWithValue("@play_description", unePiece.Play_description);
                command.Parameters.AddWithValue("@play_duration", unePiece.Play_duration);
                command.Parameters.AddWithValue("@play_price", unePiece.Play_price);
                command.Parameters.AddWithValue("@auth_name", unePiece.Auth.Auth_id);
                command.Parameters.AddWithValue("@theme_name", unePiece.Theme.Theme_id);
                command.Parameters.AddWithValue("@aud_categ", unePiece.Aud.Aud_id);

                nbr = command.ExecuteNonQuery();
                reader.Close();
            }
            return nbr;

        }

       
    }
}
