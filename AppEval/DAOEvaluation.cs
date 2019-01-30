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
        public static void AjouterEvaluation(Dictionary<string, int> lesLibelleNote, string commentaire, int bonusMalus, int idCand, double noteTotal)
        {
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();

                List<int> lesId = new List<int>();
                List<int> lesNotes = new List<int>();
                foreach (KeyValuePair<string, int> uneNote in lesLibelleNote)
                {
                    string libelle = uneNote.Key;
                    using (var cmd2 = new NpgsqlCommand("SELECT id_critere FROM critere WHERE libelle_critere LIKE '" + libelle + "'", conn))
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
                    //RH à confirmer !!!!!!!!!!
                    cmd3.CommandText = "INSERT INTO evaluation (id_eval, nom_prenom_rh, date_evaluation, bonusmalus, commentaire_eval, id_cand, notetotal) VALUES (DEFAULT, 'test', '" + DateTime.Now.ToShortDateString() + "'," + bonusMalus + ",'" + commentaire + "'," + idCand +"," + noteTotal +")";
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
                        cmd3.CommandText = "INSERT INTO noter (id_eval, id_critere, note) VALUES (" + id + ", " + uneNote.Key + "," + uneNote.Value + ")";
                        cmd3.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }

        public static List<Candidature> GetCandidature(int idOffre)
        {
            List<Candidature> lesCandidatures = new List<Candidature>();
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_cand, nom_cand, prenom_cand FROM candidature WHERE id_offre = "+ idOffre, conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Candidature c = new Candidature(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        lesCandidatures.Add(c);
                    }
                conn.Close();
            }
            return lesCandidatures;
        }

        public static Candidature GetCandidatureById(int idCand)
        {
            List<Candidature> lesCandidatures = new List<Candidature>();
            Candidature c = null;
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_cand, nom_cand, prenom_cand FROM candidature WHERE id_cand = " + idCand, conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        c = new Candidature(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    }
                conn.Close();
            }
            return c;
        }
        //TODO
        //public static List<Evaluation> GetEvaluation(int idCand)
        //{

        //}
    }
}
