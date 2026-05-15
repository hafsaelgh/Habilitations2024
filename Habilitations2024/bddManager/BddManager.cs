using MySql.Data.MySqlClient;

namespace Habilitations2024.bddManager
{
    public class BddManager
    {
        private static string connexionString =
            "Server=localhost;Database=mediatek86;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connexion = new MySqlConnection(connexionString);
            connexion.Open();
            return connexion;
        }
    }
}