namespace Habilitations2024.model
{
    /// <summary>
    /// Classe représentant un personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Identifiant du personnel
        /// </summary>
        public int Idpersonnel { get; set; }

        /// <summary>
        /// Nom du personnel
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du personnel
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Téléphone du personnel
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Mail du personnel
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Identifiant du service
        /// </summary>
        public int Idservice { get; set; }

        /// <summary>
        /// Constructeur Personnel
        /// </summary>
        public Personnel(int idpersonnel, string nom, string prenom,
            string tel, string mail, int idservice)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Idservice = idservice;
        }
    }
}