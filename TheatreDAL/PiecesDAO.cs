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
            string query_pieces = "SELECT * FROM PLAY";
            using (SqlConnection connection = ConnexionBD.GetConnexionBD().GetSqlConnexion())
            {

                SqlCommand command = new SqlCommand(query_pieces, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //CONSTRUCTEUR CREATION D'UTILISATEUR
                    Pieces Pièce = new Pieces(
                         reader.GetInt32(0),  // play_id
                        reader.GetString(1), // play_name
                        reader.GetString(2), // play_description
                        reader.GetInt32(3),  // play_duration
                        reader.GetDecimal(4),  // play_price
                        reader.GetInt32(5),  // auth_id
                        reader.GetInt32(6),  // theme_id
                        reader.GetInt32(7),  // aud_id
                        reader.GetInt32(8)   // comp_id
                    );
                    Pièces.Add(Pièce);
                }
                reader.Close();
            }
            return Pièces;
        }
    }
}
