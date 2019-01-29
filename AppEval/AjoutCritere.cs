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
        int idOffre;
        public AjoutCritere(int unIdOffre)
        {
            this.idOffre = unIdOffre;
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string libelle = txtNom.Text;
            string coeffText = txtCoeff.Text;
            int coeff;
            if (coeffText != "" && libelle != "")
            {
                try
                {
                    coeff = int.Parse(coeffText);
                    Critere unCritere = new Critere(libelle);
                    Associer uneAssociation = new Associer(coeff);                  
                    DAOCritere.AjoutCritere(unCritere, uneAssociation, idOffre);
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
            this.Close();

        }

        private void AjoutCritere_Load(object sender, EventArgs e)
        {

        }
    }
}
