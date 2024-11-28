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
        public static int ModifierPiece(Pieces piece)
        {
            int nbr;
            string query = "UPDATE PLAY SET play_name = @play_name, play_description = @play_description, play_duration = @play_duration, " +
                           "play_price = @play_price, auth_id = @auth_id, theme_id = @theme_id, aud_id = @aud_id WHERE play_id = @play_id";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@play_name", piece.Play_name);
                command.Parameters.AddWithValue("@play_description", piece.Play_description);
                command.Parameters.AddWithValue("@play_duration", piece.Play_duration);
                command.Parameters.AddWithValue("@play_price", piece.Play_price);
                command.Parameters.AddWithValue("@auth_id", piece.Auth.Auth_id);
                command.Parameters.AddWithValue("@theme_id", piece.Theme.Theme_id);
                command.Parameters.AddWithValue("@aud_id", piece.Aud.Aud_id);
                command.Parameters.AddWithValue("@play_id", piece.Play_id);

                nbr = command.ExecuteNonQuery();
            }
            return nbr;
        }

        public List<Pieces> GetPieceInfos()
        {

            List<Pieces> Pièces = new List<Pieces>();
            string query_pieces = "SELECT PLAY.play_id, PLAY.play_name, PLAY.play_description, PLAY.play_duration, PLAY.play_price, AUTHOR.auth_id, AUTHOR.auth_name,THEME.theme_id, THEME.theme_name," +
                "AUDIENCE.aud_id, AUDIENCE.aud_categ FROM PLAY JOIN AUTHOR ON PLAY.auth_id = AUTHOR.auth_id JOIN THEME ON PLAY.theme_id = THEME.theme_id" +
                " JOIN AUDIENCE ON PLAY.aud_id = AUDIENCE.aud_id";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query_pieces, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //CONSTRUCTEUR CREATION D'UTILISATEUR
                    Pieces Pièce = new Pieces(
                        reader.GetInt32(0), // play_id
                        reader.GetString(1), // play_name
                        reader.GetString(2), // play_description
                        reader.GetInt32(3), // play_duration
                        reader.GetDouble(4), // play_price
                        new Author(reader.GetInt32(5), reader.GetString(6)),  // auth_name
                        new Theme(reader.GetInt32(7), reader.GetString(8)),  // theme_name
                        new Audience(reader.GetInt32(9), reader.GetString(10))  // aud_name
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
            string queryAddPieces = "INSERT INTO PLAY (play_name, play_description, play_duration, play_price, auth_id, theme_id, aud_id) VALUES (@play_name, @play_description, @play_duration, @play_price, @auth_id, @theme_id, @aud_id)";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(queryAddPieces, connection);

                command.Parameters.AddWithValue("@play_name", unePiece.Play_name);
                command.Parameters.AddWithValue("@play_description", unePiece.Play_description);
                command.Parameters.AddWithValue("@play_duration", unePiece.Play_duration);
                command.Parameters.AddWithValue("@play_price", unePiece.Play_price);
                command.Parameters.AddWithValue("@auth_id", unePiece.Auth.Auth_id);
                command.Parameters.AddWithValue("@theme_id", unePiece.Theme.Theme_id);
                command.Parameters.AddWithValue("@aud_id", unePiece.Auth.Auth_id);


                nbr = command.ExecuteNonQuery();
            }
            return nbr;

        }
        public static int SupprimerPieces(int id)
        {
            int nbr;
            string queryDeletePiece = "DELETE FROM PLAY WHERE play_id = @play_id";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(queryDeletePiece, connection);
                command.Parameters.AddWithValue("@play_id", id);
                nbr = command.ExecuteNonQuery();
            }
            return nbr;
        }

        public static List<Author> GetAuthors()
        {
            List<Author> authors = new List<Author>();
            string query = "SELECT * FROM AUTHOR";  // Requête pour récupérer les auteurs
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Author author = new Author(
                        reader.GetInt32(0),  // Auth_id
                        reader.GetString(1)  // Auth_name
                    );
                    authors.Add(author);
                }
                reader.Close();
            }
            return authors;
        }

        // Méthode pour récupérer les thèmes
        public static List<Theme> GetThemes()
        {
            List<Theme> themes = new List<Theme>();
            string query = "SELECT * FROM THEME";  // Requête pour récupérer les thèmes
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Theme theme = new Theme(
                        reader.GetInt32(0),  // Theme_id
                        reader.GetString(1)  // Theme_name
                    );
                    themes.Add(theme);
                }
                reader.Close();
            }
            return themes;
        }

        public static Pieces GetPieceById(int id)
        {
            Pieces piece = null;
            string query = "SELECT PLAY.play_id, PLAY.play_name, PLAY.play_description, PLAY.play_duration, PLAY.play_price, AUTHOR.auth_id, AUTHOR.auth_name,THEME.theme_id, THEME.theme_name," +
                "AUDIENCE.aud_id, AUDIENCE.aud_categ FROM PLAY JOIN AUTHOR ON PLAY.auth_id = AUTHOR.auth_id JOIN THEME ON PLAY.theme_id = THEME.theme_id" +
                " JOIN AUDIENCE ON PLAY.aud_id = AUDIENCE.aud_id" + "WHERE play_id = @play_id";

            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@play_id", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Pieces Pièce = new Pieces(
                        reader.GetInt32(0), // play_id
                        reader.GetString(1), // play_name
                        reader.GetString(2), // play_description
                        reader.GetInt32(3), // play_duration
                        reader.GetDouble(4), // play_price
                        new Author(reader.GetInt32(5), reader.GetString(6)),  // auth_name
                        new Theme(reader.GetInt32(7), reader.GetString(8)),  // theme_name
                        new Audience(reader.GetInt32(9), reader.GetString(10))  // aud_name
                    );
                }
                reader.Close();
            }
            return piece;
        }

        // Méthode pour récupérer les audiences
        public static List<Audience> GetAudiences()
        {
            List<Audience> audiences = new List<Audience>();
            string query = "SELECT * FROM AUDIENCE";  // Requête pour récupérer les audiences
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Audience audience = new Audience(
                        reader.GetInt32(0),  // Aud_id
                        reader.GetString(1)  // Aud_categ
                    );
                    audiences.Add(audience);
                }
                reader.Close();
            }
            return audiences;
        }
    }
}
