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
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string coeffText = txtCoeff.Text;
            int coeff;
            if (coeffText != "" && nom != "")
            {
                try
                {
                    coeff = int.Parse(coeffText);
                    Passerelle.AjoutCritere(nom, coeff);
                    Valider.Visible = true;
                    Valider.Text = "Envoyé !";
                }
                catch
                {
                    MessageBox.Show("Le coefficient doit être un numérique !");
                }
               
                
            }
            else
            {
                MessageBox.Show("Vous devez completer tout les champs !");
            }
            
        }
    }
}
