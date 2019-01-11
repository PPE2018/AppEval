using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Associer
    {
        private int idCritere;
        private int idOffre;
        private int coefficient;

        public Associer(int unCoeff)
        {
            this.coefficient = unCoeff;
        }

        public Associer(int unCoeff, int unIdCritere, int unIdOffre)
        {
            this.coefficient = unCoeff;
            this.idCritere = unIdCritere;
            this.idOffre = unIdOffre;
        }

        public int GetCoeff()
        {
            return this.coefficient;
        }
    }
}
