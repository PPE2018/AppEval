using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Offre
    {
        private int IdOffre;
        private string libelle;
        private string description;
        private string lieu;
        private string typpeContrat;
        private double salaire;
        private DateTime dateLimite;
        private string video;
        private bool supprimer;
        private DateTime dateLimiteOffre;

        public Offre(int unIdOffres, string unLibelle, string unLieu)
        {
            this.IdOffre = unIdOffres;
            this.libelle = unLibelle;
            this.lieu = unLieu;
        }
        public Offre( DateTime uneDateLimite)
        {
            this.dateLimiteOffre = uneDateLimite;
        }
        public int GetIdOffre()
        {
            return this.IdOffre;
        }

        public string GetLibelle()
        {
            return this.libelle;
        }

        public string GetLieu()
        {
            return this.lieu;
        }

    }
}
