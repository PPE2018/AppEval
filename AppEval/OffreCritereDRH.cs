﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEval.ServiceReference1;
using System.Xml;
namespace AppEval
{
    public partial class OffreCritereDRH : Form
    {
        int idOffre;
        string nomRH;
        public OffreCritereDRH(string unNomRH)
        {
            this.nomRH = unNomRH;
            InitializeComponent();

            sioservicePortClient webServive = new sioservicePortClient();
            string web = webServive.exportOffreList("1");
            XmlDocument doc1 = new XmlDocument();
            doc1.LoadXml(web);

            XmlNodeList id = doc1.GetElementsByTagName("id");
            XmlNodeList libelle = doc1.GetElementsByTagName("libelle");
            XmlNodeList description = doc1.GetElementsByTagName("description");
            XmlNodeList lieu = doc1.GetElementsByTagName("lieu");
            XmlNodeList type_contrat = doc1.GetElementsByTagName("type_contrat");
            XmlNodeList salaire = doc1.GetElementsByTagName("salaire");
            XmlNodeList date_limite = doc1.GetElementsByTagName("date_limite");
            XmlNodeList video = doc1.GetElementsByTagName("video");
            XmlNodeList supprimer = doc1.GetElementsByTagName("supprimer");






            //Pour afficher les offres au commencement de l'appli

            foreach (Offre o in DAOOffre.GetLesOffres())
            {
                listBoxOffre.Items.Add(o.GetIdOffre() + "-" + o.GetLibelle() + "-" + o.GetLieu());
            }
            listBoxOffre.SetSelected(0, true);
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            AjoutCritere c = new AjoutCritere(idOffre);
            c.Show();

        }

        private void bttnSupprimer_Click(object sender, EventArgs e)
        {
            int index = this.OffreCritere.CurrentRow.Index;

            DAOCritere.SupprimerCritere(OffreCritere.CurrentRow.Cells["Critères"].Value.ToString(),listBoxOffre.SelectedIndex+1);
            
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            groupBoxModifierCritere.Visible = true;
            foreach(KeyValuePair<string,int> c in DAOCritere.ModifierCritere(OffreCritere.CurrentRow.Cells["Critères"].Value.ToString(), idOffre))
            {
                textBoxNom.Text = c.Key;
                textBoxCoeff.Text = c.Value.ToString();
            }
        }

        private void listBoxOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            OffreCritere.Rows.Clear();
            string value = listBoxOffre.SelectedItem.ToString();
            string id ="";
            bool stop = false;
            foreach(Char c in value)
            {
                if(c != '-' && !stop) 
                {
                    id += c;
                }
                else
                {
                    stop = true;
                }
            }
            this.idOffre = int.Parse(id);
            foreach (Critere c in DAOCritere.GetLesCriteresByOffre(idOffre))
            {
                OffreCritere.Rows.Add(c.GetLibelle());
            }
        }

        private void OffreCritere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAjouterDate_Click(object sender, EventArgs e)
        {
            
            groupBoxDate.Visible= true;
            dateTimePickeDateLimite.Value= DAOOffre.GetDateLimite(idOffre);
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            //Dès que le bouton est cliqué la groupe box ne s'affiche pas 
            groupBoxDate.Visible = false;

            //permet de modifier la date limite de l'offre
            DAOOffre.ModifierDateLimite(idOffre, dateTimePickeDateLimite.Value);

        }

        private void buttonModifierCritere_Click(object sender, EventArgs e)
        {
            string coeffText = textBoxCoeff.Text;
            int coeff;
            if (coeffText != "")
            {
                try
                {
                    coeff = int.Parse(coeffText);
                    DAOCritere.ModifCoeff(textBoxNom.Text, int.Parse(textBoxCoeff.Text));
                    groupBoxModifierCritere.Visible = false;


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

        private void button1_Click(object sender, EventArgs e)
        {
            EvaluationRH evaluation = new EvaluationRH(this.nomRH);
            evaluation.Show();
        }

        private void OffreCritereDRH_Load(object sender, EventArgs e)
        {

        }
    }
}

