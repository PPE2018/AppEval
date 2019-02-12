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
        public static void AjouterEvaluation(Dictionary<string, int> lesLibelleNote, string commentaire, int bonusMalus, int idCand)
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
                    cmd3.CommandText = "INSERT INTO evaluation (id_eval, nom_prenom_rh, date_evaluation, bonusmalus, commentaire_eval, id_cand) VALUES (DEFAULT, 'test', '" + DateTime.Now.ToShortDateString() + "'," + bonusMalus + ",'" + commentaire + "'," + idCand +")";
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

        public static double GetNoteTot(int idEval)
        {
            double noteTot = 0;
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT notetot + e.bonusmalus from noterh INNER JOIN evaluation e ON e.id_eval = noterh.id_eval WHERE e.id_eval = " + idEval, conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        noteTot = reader.GetInt32(0);
                    }
                conn.Close();
            }
            return noteTot;
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

        /*public static Dictionary<string, double> AfficherTableauBordRH(int idOffre)
        {
            Dictionary<string, double> resul = new Dictionary<string, double>();
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                // connect à la bdd
                conn.Open();
                using (var cmd2 = new NpgsqlCommand("SELECT nom_prenom_RH, note FROM noteRH WHERE id_offre="+idOffre, conn))
                using (var reader = cmd2.ExecuteReader())
                    while (reader.Read())
                    {
                        resul.Add(reader.GetString(0),reader.GetDouble(1));
                    }
                conn.Close();

            }
            return resul;
        }*/

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
        public static List<Evaluation> GetEvaluations(int idCand)
        {
            List<Evaluation> lesEvaluations = new List<Evaluation>();
            Evaluation e = null;
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_eval, nom_prenom_rh, date_evaluation, bonusmalus, commentaire_eval FROM evaluation WHERE id_cand = " + idCand, conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        e = new Evaluation(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetInt32(3), reader.GetString(4));
                        lesEvaluations.Add(e);
                    }
                conn.Close();
            }
            return lesEvaluations;
        }

        public static int GetIdLastEval()
        {
            int idEval = -1;
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_eval FROM evaluation ORDER BY id_eval DESC LIMIT 1;", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        idEval = reader.GetInt32(0);
                    }
                conn.Close();
            }
            return idEval;
        }
    }
}
