using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AppEval
{
    public static class DAOEvaluation
    {
        public static void AjouterEvaluation(Dictionary<string, int> lesLibelleNote, string commentaire, int bonusMalus, int idOffre)
        {
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();

                List<int> lesId = new List<int>();
                List<int> lesNotes = new List<int>();
                foreach(KeyValuePair<string, int> uneNote in lesLibelleNote)
                {
                    string libelle = uneNote.Key;
                    using (var cmd2 = new NpgsqlCommand("SELECT id_critere FROM critere WHERE libelle_critere LIKE '"+libelle+"'", conn))
                    using (var reader = cmd2.ExecuteReader())
                        while (reader.Read())
                        {
                            lesId.Add(reader.GetInt32(0));
                        }
                    lesNotes.Add(uneNote.Value);
                }
                using (var cmd3 = new NpgsqlCommand())
                {
                    cmd3.Connection = conn;
                    //RH à confirmer, id_cand à changer !!!!!!!!!!
                    cmd3.CommandText = "INSERT INTO evaluation (id_eval, nom_prenom_rh, date_evaluation, bonusmalus, commentaire_eval, id_cand) VALUES (DEFAULT, 'test', '"+DateTime.Now.ToShortDateString()+"',"+bonusMalus+",'"+commentaire+"',1)";
                    cmd3.ExecuteNonQuery();
                }

                int id = -1;
                using (var cmd2 = new NpgsqlCommand("SELECT id_eval FROM evaluation ORDER BY id_eval", conn))
                using (var reader = cmd2.ExecuteReader())
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }

                Dictionary<int, int> lesIdNote = new Dictionary<int, int>();
                for (int i = 0; i < lesId.Count; i++)
                {
                    lesIdNote[lesId[i]] = lesNotes[i];
                }
                foreach (KeyValuePair<int, int> uneNote in lesIdNote)
                {
                    using (var cmd3 = new NpgsqlCommand())
                    {
                        cmd3.Connection = conn;
                        //Id de l'offre à changer !!!
                        cmd3.CommandText = "INSERT INTO noter (id_eval, id_critere, note) VALUES ("+id+", "+uneNote.Key+"," + uneNote.Value + ")";
                        cmd3.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }

        public static Dictionary<string, double> AfficherTableauBord(int idCand)
        {
            Dictionary<string, double> resul = new Dictionary<string, double>();

            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                // connect à la bdd
                conn.Open();
                using (var cmd2 = new NpgsqlCommand("SELECT nom_prenom_RH, notetotal FROM EVALUATION E INNER JOIN CANDIDATURE C ON Cid_cand= E.id_cand WHERE E.id_cand='" + idCand, conn))
                using (var reader = cmd2.ExecuteReader())
                    while (reader.Read())
                    {
                        resul.Add(reader.GetString(0), reader.GetInt32(1));
                    }
                conn.Close();
            }
            return resul;

        }
    }
}
