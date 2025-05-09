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
                "AUDIENCE.aud_id, AUDIENCE.aud_categ, COMPANIES.comp_id, COMPANIES.comp_name, COMPANIES.comp_region, DIRECTORS.dir_id, DIRECTORS.dir_name FROM PLAY JOIN AUTHOR ON PLAY.auth_id = AUTHOR.auth_id JOIN THEME ON PLAY.theme_id = THEME.theme_id" +
                " JOIN AUDIENCE ON PLAY.aud_id = AUDIENCE.aud_id"+ " JOIN COMPANIES ON PLAY.comp_id = COMPANIES.comp_id" + " JOIN DIRECTORS ON COMPANIES.comp_artistic_director = DIRECTORS.dir_id";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query_pieces, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //CONSTRUCTEUR CREATION D'UTILISATEUR
                    Pieces Pièce = new Pieces(
                        (int)reader["play_id"], // play_id
                        (string)reader["play_name"], // play_name
                        (string)reader["play_description"], // play_description
                        (int)reader["play_duration"], // play_duration
                        (double)reader["play_price"], // play_price
                        new Author((int)reader["auth_id"], (string)reader["auth_name"]),  // auth_name
                        new Theme((int)reader["theme_id"], (string)reader["theme_name"]),  // theme_name
                        new Audience((int)reader["aud_id"], (string)reader["aud_categ"]),  // aud_name
                        new Company((int)reader["comp_id"], (string)reader["comp_name"], (string)reader["comp_region"],
                            new Director((int)reader["dir_id"], (string)reader["dir_name"])
                            )
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
            string queryAddPieces = "INSERT INTO PLAY (play_name, play_description, play_duration, play_price, auth_id, theme_id, aud_id, comp_id) VALUES (@play_name, @play_description, @play_duration, @play_price, @auth_id, @theme_id, @aud_id, @comp_id)";
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
                command.Parameters.AddWithValue("@comp_id", unePiece.Comp.Comp_id);


                nbr = command.ExecuteNonQuery();
            }
            return nbr;

        }
        public static int SupprimerPieces(int id)
        {
            int nbr;
            string queryCheckRep = "SELECT COUNT(*) FROM REPRESENTATION WHERE play_id = @play_id";
            string queryDeletePiece = "DELETE FROM PLAY WHERE play_id = @play_id";

            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                // Vérifier s'il y a des réservations liées à la pièce
                SqlCommand checkRepCommand = new SqlCommand(queryCheckRep, connection);
                checkRepCommand.Parameters.AddWithValue("@play_id", id);
                int reservationCount = (int)checkRepCommand.ExecuteScalar();

                if (reservationCount > 0)
                {
                    // Ne pas supprimer la pièce si des réservations sont liées
                    nbr = 0;
                }
                else
                {
                    // Supprimer la pièce si aucune réservation n'est liée
                    SqlCommand deletePieceCommand = new SqlCommand(queryDeletePiece, connection);
                    deletePieceCommand.Parameters.AddWithValue("@play_id", id);
                    nbr = deletePieceCommand.ExecuteNonQuery();
                }
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

        // Méthode pour récupérer les directeur
        public static List<Director> GetDirectors()
        {
            List<Director> directors = new List<Director>();
            string query = "SELECT * FROM DIRECTORS";  // Requête pour récupérer les directeurs
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Director director = new Director(
                        reader.GetInt32(0),  // Dir_id
                        reader.GetString(1)  // Dir_name
                    );
                    directors.Add(director);
                }
                reader.Close();
            }
            return directors;
        }

        public static Company getCompanyByDirector(Director director)
        {
            Company company = null;
            string query = "SELECT * FROM COMPANIES " +
                           "WHERE comp_artistic_director = @dir_id";

            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@dir_id", director.Dir_id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    company = new Company(
                        (int)reader["comp_id"],  // comp_id
                        (string)reader["comp_name"],  // comp_name
                        (string)reader["comp_region"],  // comp_region
                        director
                    );
                }
                reader.Close();
            }
            return company;
        }
    }
}
