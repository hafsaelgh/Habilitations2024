namespace Habilitations2024.model
{
    /// <summary>
    /// Classe représentant un motif d'absence
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Identifiant du motif
        /// </summary>
        public int Idmotif { get; set; }

        /// <summary>
        /// Libellé du motif
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Constructeur Motif
        /// </summary>
        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }
    }
}