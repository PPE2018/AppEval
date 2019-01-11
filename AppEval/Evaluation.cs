using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEval
{
    public partial class Evaluation : Form
    {
        public Evaluation()
        {
            InitializeComponent();
            foreach (Critere c in Passerelle.GetLesCriteres())
            {
                tableauEvaluation.Rows.Add(c.GetLibelle());
            }
            int n = 0;
            foreach (Associer a in Passerelle.GetLesAssociations())
            {
                //tableauEvaluation.Rows[n] = (a.GetCoeff());
                n++;
            }
        }
    }
}
