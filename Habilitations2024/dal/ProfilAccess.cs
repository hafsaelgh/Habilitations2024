using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Habilitations2024.model;

namespace Habilitations2024.dal
{
    public class ProfilAccess : Access
    {
        public List<Profil> GetLesProfils()
        {
            List<Profil> lesProfils = new List<Profil>();

            string req = "SELECT idprofil, nom FROM profil";

            MySqlCommand command = new MySqlCommand(req, connexion);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Profil unProfil = new Profil(
                    reader.GetInt32(0),
                    reader.GetString(1)
                );

                lesProfils.Add(unProfil);
            }
            reader.Close();

            return lesProfils;
        }
    }
}