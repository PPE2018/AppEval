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
    public partial class EvaluationRH : Form
    {
        int idOffre;
        int idCand;
        string nomRH;
        public EvaluationRH(string unNomRH)
        {
            this.nomRH = unNomRH;
            InitializeComponent();
            
            foreach (Offre o in DAOOffre.GetLesOffres())
            {
                listeOffres.Items.Add(o.GetIdOffre() + "-" + o.GetLibelle());
            }
            listeOffres.SelectedIndex = 0;
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
                MessageBox.Show("Vous devez saisir un bonus / malus !");
            }

            //Recuperation idCand à partir de la listBox des candidature
            string value = listeCandidats.SelectedItem.ToString();
            string id = "";
            bool stop = false;
            foreach (Char c in value)
            {
                if (c != '-' && !stop)
                {
                    id += c;
                }
                else
                {
                    stop = true;
                }
            }
            this.idCand = int.Parse(id);

            if (!erreur)
            {
                DAOEvaluation.AjouterEvaluation(libelleNote, commentaire, bonusMalus, idCand, nomRH);
                libNote.Text = DAOEvaluation.GetNoteTot(DAOEvaluation.GetIdLastEval()).ToString();
            }
        }

        private void listeOffres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = listeOffres.SelectedItem.ToString();
            string id = "";
            bool stop = false;
            foreach (Char c in value)
            {
                if (c != '-' && !stop)
                {
                    id += c;
                }
                else
                {
                    stop = true;
                }
            }
            this.idOffre = int.Parse(id);
            tableauEvaluation.Rows.Clear();
            foreach (KeyValuePair<string, int> kvp in DAOCritere.GetCritereCoeff(idOffre))
            {
                tableauEvaluation.Rows.Add(kvp.Key, kvp.Value);
            }
            listeCandidats.Items.Clear();
            foreach(Candidature candidature in DAOEvaluation.GetCandidature(idOffre))
            {
                listeCandidats.Items.Add(candidature.GetIdCand().ToString() + "-" + candidature.GetNom() + candidature.GetPrenom());
            }
            listeCandidats.SelectedIndex = 0;
        }

        private void tableauEvaluation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PDF.EditerBrochure(DAOEvaluation.GetCandidatureById(idCand).GetNom(), DAOEvaluation.GetCandidatureById(idCand).GetPrenom(), DAOEvaluation.GetEvaluations(idCand));
        }

        private void bttnReunion_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableauBord c = new TableauBord(idOffre, nomRH);
            c.Show();
        }

        private void EvaluationRH_Load(object sender, EventArgs e)
        {

        }
    }
}
