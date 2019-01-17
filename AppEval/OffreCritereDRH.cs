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
    public partial class OffreCritereDRH : Form
    {
        public OffreCritereDRH()
        {
            InitializeComponent();

            foreach (Offre o in DAOOffre.GetLesOffres())
            {
                listBoxOffre.Items.Add(o.GetIdOffre() + "-" + o.GetLibelle() + "-" + o.GetLieu());
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjoutCritere c = new AjoutCritere(2);
            c.Show();

        }

        private void bttnSupprimer_Click(object sender, EventArgs e)
        {
            int index = this.OffreCritere.CurrentRow.Index;
            this.OffreCritere.Rows.RemoveAt(index);
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            //this.OffreCritere.Rows.("Critères").Value;
        }

        private void listBoxOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            OffreCritere.Rows.Clear();
            foreach (Critere c in DAOCritere.GetLesCriteresByOffre(listBoxOffre.SelectedIndex + 1))
            {
                OffreCritere.Rows.Add(c.GetLibelle());
            }
        }
    }
}

