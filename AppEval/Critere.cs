using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Critere
    {
        private string libelle;
        private int id;

        public Critere(string unlibelle)
        {
            this.libelle = unlibelle;
        }

        public Critere(string unLibelle, int unId)
        {
            this.libelle = unLibelle;
            this.id = unId;
        }

        public string GetLibelle()
        {
            return this.libelle;
        }
    }
}
