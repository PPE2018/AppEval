using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Evalutation
    {
        private int idEval;
        private string nomPrenomRh;
        private DateTime dateEvaluation;
        private int bonusMalus;
        private double noteTotal;
        private string commentaireEval;

        public Evalutation(int unIdEval, string unNomPrenomRh, DateTime uneDateEval, int unBonusMalus, double uneNoteTotal, string unCommentaire)
        {
            this.idEval = unIdEval;
            this.nomPrenomRh = unNomPrenomRh;
            this.dateEvaluation = uneDateEval;
            this.bonusMalus = unBonusMalus;
            this.noteTotal = uneNoteTotal;
            this.commentaireEval = unCommentaire; 
        }
    }
}
