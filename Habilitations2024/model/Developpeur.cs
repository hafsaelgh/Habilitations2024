namespace Habilitations2024.model
{
    public class Developpeur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pwd { get; set; }
        public int IdProfil { get; set; }

        public Developpeur(
            int id,
            string nom,
            string prenom,
            string pwd,
            int idProfil)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Pwd = pwd;
            IdProfil = idProfil;
        }
    }
}