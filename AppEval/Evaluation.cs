using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public class Evaluation
    {
        private int idEval;
        private string nomPrenomRh;
        private DateTime dateEvaluation;
        private int bonusMalus;
        private double noteTotal;
        private string commentaireEval;

        public Evaluation(int unIdEval, string unNomPrenomRh, DateTime uneDateEval, int unBonusMalus, double uneNoteTotal, string unCommentaire)
        {
            this.idEval = unIdEval;
            this.nomPrenomRh = unNomPrenomRh;
            this.dateEvaluation = uneDateEval;
            this.bonusMalus = unBonusMalus;
            this.noteTotal = uneNoteTotal;
            this.commentaireEval = unCommentaire; 
        }

        public string GetNomPrenomRH()
        {
            return this.nomPrenomRh;
        }

        public double NoteTotal()
        {
            return this.noteTotal;
        }

        public string GetCommentaire()
        {
            return this.commentaireEval;
        }
    }
}
