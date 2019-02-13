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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
            Connexion.ConnectOdoo();
            foreach(string nom in DAOConnectOdoo.GetNomRH())
            {
                listeRH.Items.Add(nom);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DAOConnectOdoo.estDRH(listeRH.SelectedItem.ToString()))
            {
                OffreCritereDRH offreCritereDRH = new OffreCritereDRH(listeRH.SelectedItem.ToString());
                offreCritereDRH.Show();
            }
            else
            {
                EvaluationRH evaluationRH = new EvaluationRH(listeRH.SelectedItem.ToString());
                evaluationRH.Show();
            }
            this.Hide();
        }
    }
}
