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
        int idOffre;
        public Evaluation(int unIdOffre)
        {
            this.idOffre = unIdOffre;
            InitializeComponent();
            foreach(KeyValuePair<string, int> kvp in DAOCritere.GetCritereCoeff(idOffre))
            {
                tableauEvaluation.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> libelleNote = new Dictionary<string, int>();
            List<string> lesLibelles = new List<string>();
            List<int> lesNotes = new List<int>();
            List<int> lesCoeff = new List<int>();
            bool erreur = false;
            for (int i=0; i < tableauEvaluation.RowCount; i++)
            {
                for (int n = 0; n < tableauEvaluation.ColumnCount; n++)
                {
                    if(n == 0)
                    {
                        lesLibelles.Add(tableauEvaluation[n, i].Value.ToString());
                    }

                    if(n == 1)
                    {
                        string temp = tableauEvaluation[n, i].Value.ToString();
                        lesCoeff.Add(int.Parse(temp));
                    }
                     
                    if (n == 2)
                    {
                        try
                        {
                            erreur = false;
                            string temp = tableauEvaluation[n, i].Value.ToString();
                            int uneNote = int.Parse(temp);
                            lesNotes.Add(uneNote);
                        }
                        catch
                        {
                            erreur = true;
                            MessageBox.Show("Vous devez saisir des notes pour chaque critère au format numérique !");
                        }
                    }
                }
            }
            for (int i = 0; i < lesLibelles.Count; i++)
            {
                libelleNote[lesLibelles[i]] = lesNotes[i];
            }
            string commentaire = txtCommentaire.Text;
            string temp2 = txtBonusMalus.Text;
            int bonusMalus = 0;
            try
            {
                erreur = false;
                bonusMalus = int.Parse(temp2);
            }
            catch
            {
                erreur = true;
                MessageBox.Show("Vous devez saisir un bonus/ malus !");
            }
            double tot = 0;
            double div = 0;
            for(int i = 0; i < lesCoeff.Count; i++)
            {
                tot += lesNotes[i] * lesCoeff[i];
                div += lesCoeff[i];
            }
            tot += bonusMalus;
            double note = tot / div;
            note = Math.Round(note, 2);
            libNote.Text = note.ToString();
            if (!erreur)
            {
                DAOEvaluation.AjouterEvaluation(libelleNote, commentaire, bonusMalus);
            }
            
            
        }
    }
}
