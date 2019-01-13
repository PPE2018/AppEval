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
            foreach(Critere c in Passerelle.GetLesCriteres())
            {
                OffreCritere.Rows.Add(c.GetLibelle());
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjoutCritere c = new AjoutCritere();
            c.Show();
            
        }

        private void bttnSupprimer_Click(object sender, EventArgs e)
        {
            int index = this.OffreCritere.CurrentRow.Index;
            this.OffreCritere.Rows.RemoveAt(index);
        }

    }
}
