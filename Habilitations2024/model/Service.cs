namespace Habilitations2024.model
{
    /// <summary>
    /// Classe représentant un service
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Identifiant du service
        /// </summary>
        public int Idservice { get; set; }

        /// <summary>
        /// Nom du service
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Constructeur Service
        /// </summary>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }
    }
}