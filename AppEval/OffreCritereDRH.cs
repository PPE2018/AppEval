﻿using System;
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
        int idOffre;
        public OffreCritereDRH()
        {
            InitializeComponent();

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
            //this.OffreCritere.Rows.("Critères").Value;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Evaluation evaluation = new Evaluation(idOffre);
            evaluation.Show();
        }
    }
}

