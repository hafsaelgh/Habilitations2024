namespace Habilitations2024.model
{
    public class Profil
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Profil(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
    }
}