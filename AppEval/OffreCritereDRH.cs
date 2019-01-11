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


        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjoutCritere c = new AjoutCritere();
            c.Show();
            
        }
    }
}
