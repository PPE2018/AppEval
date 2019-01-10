using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace AppEval
{
    public partial class AjoutCritere : Form
    {
        public AjoutCritere()
        {
            InitializeComponent();
            Passerelle.Connexion();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            int coeff = int.Parse(txtCoeff.Text);
            Passerelle.AjoutCritere(nom, coeff);
        }
    }
}
