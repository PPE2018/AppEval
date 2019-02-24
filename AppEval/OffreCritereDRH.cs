using System;
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
using Npgsql;
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

            //permet de ne pas supprimer à chaque fois les offres dans la bdd
            string id = "-1";
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT id_offre FROM OFFRE_EMPLOIS ORDER BY id_offre", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0).ToString();
                    }

                conn.Close();

            }

            //Ouverture du web sercive  et créattion du document xml
            sioservicePortClient webServive = new sioservicePortClient();
            string web = webServive.exportOffreList(id);
            XmlDocument doc1 = new XmlDocument();
            doc1.LoadXml(web);

            XmlNodeList id_offre = doc1.GetElementsByTagName("id_offre");
            XmlNodeList libelle = doc1.GetElementsByTagName("libelle");
            XmlNodeList description = doc1.GetElementsByTagName("description");
            XmlNodeList lieu = doc1.GetElementsByTagName("lieu");
            XmlNodeList type_contrat = doc1.GetElementsByTagName("type_contrat");
            XmlNodeList salaire = doc1.GetElementsByTagName("salaire");
            XmlNodeList date_limite = doc1.GetElementsByTagName("date_limite");
            XmlNodeList video = doc1.GetElementsByTagName("video");
            XmlNodeList supprimer = doc1.GetElementsByTagName("supprimer");

            //permet d'insérer les données qui se trouvent dans le xml dans la bdd posgres
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();

                for (int i = 0; i < id_offre.Count; i++)
                {
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        //innerXML permet d'enlever les balises
                        cmd.CommandText = "INSERT INTO OFFRE_EMPLOIS (id_offre, libelle, description, lieu, type_contrat, salaire, date_limite, video, supprimer, date_limite_offre ) VALUES ("+ id_offre[i].InnerXml+",'"+libelle[i].InnerXml+"', '"+description[i].InnerXml+"','"+lieu[i].InnerXml+"','"+type_contrat[i].InnerXml+"','"+salaire[i].InnerXml+"', '"+date_limite[i].InnerXml+"', '"+video[i].InnerXml+"','"+supprimer[i].InnerXml+"', NOW())";
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();

            }
            string web2 = webServive.exportCandidatureList(id);

            XmlDocument doc2 = new XmlDocument();
            doc2.LoadXml(web2);

            XmlNodeList id_candidature = doc2.GetElementsByTagName("id_candidature");
            XmlNodeList nom_candidature = doc2.GetElementsByTagName("nom_candidature");
            XmlNodeList prenom_candidature = doc2.GetElementsByTagName("prenom_candidature");
            XmlNodeList date_candidature = doc2.GetElementsByTagName("date_candidature");
            XmlNodeList id_offre_candidature = doc2.GetElementsByTagName("id_offre_candidature");

            //permet d'insérer les données xml dans la bdd posgres
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();

                for (int i = 0; i < id_candidature.Count; i++)
                {
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO CANDIDATURE (id_cand, nom_cand, prenom_cand, date_cand , statut_cand, id_offre ) VALUES (" + id_candidature[i].InnerXml + ",'" + nom_candidature[i].InnerXml + "', '" + prenom_candidature[i].InnerXml + "','" + date_candidature[i].InnerXml + "','Attente','"+ id_offre_candidature[i].InnerXml+"')";
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();

            }

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
            //on récupère l'index de l'offre
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
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvaluationRH evaluation = new EvaluationRH(this.nomRH);
            evaluation.Show();
        }

        private void buttonModifierCritere_Click_1(object sender, EventArgs e)
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
    }
}

