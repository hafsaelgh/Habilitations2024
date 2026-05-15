namespace Habilitations2024.model
{
    /// <summary>
    /// Classe représentant un responsable
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Nom du responsable
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du responsable
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Mail du responsable
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Constructeur Responsable
        /// </summary>
        public Responsable(string nom,
            string prenom,
            string mail)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Mail = mail;
        }
    }
}