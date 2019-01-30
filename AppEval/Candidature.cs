using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Candidature
    {
        private int idCand;
        private string nom;
        private string prenom;

        public Candidature(int unIdCand, string unNom, string unPrenom)
        {
            this.idCand = unIdCand;
            this.nom = unNom;
            this.prenom = unPrenom;
        }

        public int GetIdCand()
        {
            return this.idCand;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public string GetPrenom()
        {
            return this.prenom;
        }
    }
}
