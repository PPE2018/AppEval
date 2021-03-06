﻿using System;
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
    public partial class TableauBord : Form
    {
        int idOffre;
        string nomRH;
        public TableauBord(int idOffre, string unNomRH)
        {
            this.idOffre = idOffre;
            this.nomRH = unNomRH;
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection(Connexion.Connecter());
            conn.Open();

            using (NpgsqlCommand cmd2 = new NpgsqlCommand("SELECT N.nom_cand, N.prenom_cand, M.notemoyenne,N.noteTotal, N.nom_prenom_rh FROM NoteRH N INNER JOIN NoteMoy M ON M.nom_cand = N.nom_cand AND M.prenom_cand = N.prenom_cand ORDER BY  M.notemoyenne, N.nom_cand, N.prenom_cand ; ", conn))
            using (NpgsqlDataReader reader = cmd2.ExecuteReader())
            {
                //detection de la première ligne
                int first = 1;

                //tant qu'on a des lignes sql
                while (reader.Read())
                {
                    bool verif = false;
                    int comp = 0;
                    //Colonne pour chaque l'évaluateur est marquer
                    for (int i = 0; i < dataGridViewTableauBord.Columns.Count; i++)
                    {
                        // si l'évalutateur est déjà entre dans la colonne
                        if (dataGridViewTableauBord.Columns[i].HeaderText == reader.GetString(4))
                        {
                            verif = true;
                            comp = i;
                        }
                    }
                    //si l'evaluateur n'est pas déjà dans la colonne
                    if (verif == false)
                    {
                        //on ajoute l'évaluateur dans la dernière colonne
                        dataGridViewTableauBord.Columns.Add(reader.GetString(4), reader.GetString(4));
                        comp = dataGridViewTableauBord.ColumnCount - 1;
                    }

                    //Row
                    if (first != 1)
                    {
                        //si les données sont identiques on les ajoute à la ligne existante 
                        if (dataGridViewTableauBord.Rows[0].Cells[0].Value.ToString() == reader.GetString(0) + " " + reader.GetString(1))
                        {
                            //on met la note du candidat à l'évalutateur
                            dataGridViewTableauBord.Rows[0].Cells[comp].Value = reader.GetInt32(3);
                        }
                        //Sinon on créer une nouvele ligne aves le nom et prenom cand et sa moyenne
                        else
                        {
                            dataGridViewTableauBord.Rows.Add();
                            dataGridViewTableauBord.Rows[0].Cells[0].Value = reader.GetString(0) + " " + reader.GetString(1);
                            dataGridViewTableauBord.Rows[0].Cells[1].Value = reader.GetInt32(2);
                            dataGridViewTableauBord.Rows[0].Cells[comp].Value = reader.GetInt32(3);
                        }
                    }
                    //on ajoute sans ajouter de ligne
                    else
                    {
                        dataGridViewTableauBord.Rows[0].Cells[0].Value = reader.GetString(0) + " " + reader.GetString(1);
                        dataGridViewTableauBord.Rows[0].Cells[1].Value = reader.GetInt32(2);
                        dataGridViewTableauBord.Rows[0].Cells[comp].Value = reader.GetInt32(3);
                        first = -1;
                    }
                }
            ;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvaluationRH eval = new EvaluationRH(nomRH);
            eval.Show();
           
        }

        private void dataGridViewTableauBord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


    }
}
