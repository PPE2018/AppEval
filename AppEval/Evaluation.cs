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
        int id_offre;
        public Evaluation(int unId_offre)
        {
            InitializeComponent();
            foreach(KeyValuePair<string, int> kvp in Passerelle.GetCritereCoeff())
            {
                tableauEvaluation.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> libelleNote = new Dictionary<string, int>();
            List<string> lesLibelles = new List<string>();
            List<int> lesNotes = new List<int>();
            for(int i=0; i < tableauEvaluation.RowCount; i++)
            {
                for (int n = 0; n < tableauEvaluation.ColumnCount; n++)
                {
                    if(n == 0)
                    {
                        lesLibelles.Add(tableauEvaluation[n, i].Value.ToString());
                    }
                     
                    if (n == 2)
                    {
                        string temp = tableauEvaluation[n, i].Value.ToString();
                        lesNotes.Add(int.Parse(temp));
                    }
                }
            }
            
           for (int i = 0; i < lesLibelles.Count; i++)
           {
                libelleNote[lesLibelles[i]] = lesNotes[i];
           }
            string commentaire = txtCommentaire.Text;
            string temp2 = txtBonusMalus.Text;
            int bonusMalus = int.Parse(temp2);
            DAOEvaluation.AjouterEvaluation(libelleNote, commentaire, bonusMalus);
        }
    }
}
