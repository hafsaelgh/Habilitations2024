using System;

namespace Habilitations2024.model
{
    /// <summary>
    /// Classe représentant une absence
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Identifiant du personnel
        /// </summary>
        public int Idpersonnel { get; set; }

        /// <summary>
        /// Date de début
        /// </summary>
        public DateTime DateDebut { get; set; }

        /// <summary>
        /// Date de fin
        /// </summary>
        public DateTime DateFin { get; set; }

        /// <summary>
        /// Identifiant du motif
        /// </summary>
        public int Idmotif { get; set; }

        /// <summary>
        /// Constructeur Absence
        /// </summary>
        public Absence(int idpersonnel,
            DateTime dateDebut,
            DateTime dateFin,
            int idmotif)
        {
            this.Idpersonnel = idpersonnel;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
            this.Idmotif = idmotif;
        }
    }
}