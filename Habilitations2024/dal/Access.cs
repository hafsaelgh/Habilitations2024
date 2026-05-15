using MySql.Data.MySqlClient;
using Habilitations2024.bddManager;

namespace Habilitations2024.dal
{
    public class Access
    {
        protected static MySqlConnection connexion=
             BddManager.GetConnection();
    }
}