using System.Collections.Generic;
using Habilitations2024.dal;
using Habilitations2024.model;

namespace Habilitations2024.controller
{
    public class FrmHabilitationsController
    {
        private DeveloppeurAccess developpeurAccess;
        private ProfilAccess profilAccess;

        public FrmHabilitationsController()
        {
            developpeurAccess = new DeveloppeurAccess();
            profilAccess = new ProfilAccess();
        }

        public List<Developpeur> GetLesDeveloppeurs()
        {
            return developpeurAccess.GetLesDeveloppeurs();
        }

        public List<Profil> GetLesProfils()
        {
            return profilAccess.GetLesProfils();
        }
        public void AjoutPersonnel ( string nom, string prenom, string tel, string mail, int idservice)
        {
            developpeurAccess.AjoutPersonnel(
                nom, prenom, tel, mail, idservice);
        }
    }
}