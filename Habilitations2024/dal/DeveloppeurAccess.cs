using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Habilitations2024.model;

namespace Habilitations2024.dal
{
    public class DeveloppeurAccess : Access
    {
        public List<Developpeur> GetLesDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs =
                new List<Developpeur>();
            string req =
           "SELECT idpersonnel, nom, prenom, mail, idservice FROM personnel";

            MySqlCommand command =
                new MySqlCommand(req, connexion);
            MySqlDataReader reader =
                command.ExecuteReader();

            while (reader.Read())
            {
                Developpeur unDeveloppeur =
                    new Developpeur(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetInt32(4)
                    );

                lesDeveloppeurs.Add(unDeveloppeur);
            }
            reader.Close();

            return lesDeveloppeurs;
        }
        public void AjoutPersonnel (string nom, string prenom, string tel, 
            string mail, int idservice)
        {
            string req =
                "INSERT INTO personnel" + "(nom, prenom, tel, mail, idservice)" + "VALUES (@nom, @prenom, @tel, @mail, @idservice)";

            MySqlCommand command =
                new MySqlCommand(req, connexion);

            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@idservice", idservice);
            command.ExecuteNonQuery();
        }

        
    }
}