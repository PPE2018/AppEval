using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace AppEval
{
    public static class DAOCritere
    {
        public static void AjoutCritere(Critere unCritere, Associer uneAssociation, int unIdOffre)
        {
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();
                // Insert some data
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO critere (id_critere, libelle_critere) VALUES (DEFAULT, '" + unCritere.GetLibelle() + "')";
                    cmd.ExecuteNonQuery();
                }

                int id = -1;
                using (var cmd2 = new NpgsqlCommand("SELECT id_critere FROM critere ORDER BY id_critere", conn))
                using (var reader = cmd2.ExecuteReader())
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                using (var cmd3 = new NpgsqlCommand())
                {
                    cmd3.Connection = conn;
                    cmd3.CommandText = "INSERT INTO associer (id_critere, id_offre, coefficient) VALUES (" + id + ", "+unIdOffre+"," + uneAssociation.GetCoeff() + ")";
                    cmd3.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public static void SupprimerCritere(string libelleCrit, int unIdOffre)
        {
            var connString = "Host=localhost;Port=4747;Username=openpg;Password=;Database=BddAppEval";
            
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                int idC = 0;
                int association = 0;
                using (NpgsqlCommand cmd0 = new NpgsqlCommand("SELECT id_critere FROM critere WHERE libelle_critere = '" + libelleCrit + "';", conn))
                using (NpgsqlDataReader reader = cmd0.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idC = reader.GetInt32(0);
                    }
                }


                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT (id_offre) FROM associer WHERE id_critere=" + idC + ";", conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        association = reader.GetInt32(0);
                    }
                }

                NpgsqlCommand cmd1 = new NpgsqlCommand("DELETE FROM associer WHERE id_critere = " + idC + " AND id_offre=" + unIdOffre,conn);
                cmd1.ExecuteNonQuery();

                if (association == 1)
                {
                    NpgsqlCommand cmd3 = new NpgsqlCommand("DELETE FROM noter WHERE id_critere=" + idC, conn);
                    cmd3.ExecuteNonQuery();
                    NpgsqlCommand cmd2 = new NpgsqlCommand("DELETE FROM critere WHERE id_critere = " + idC, conn);
                    cmd2.ExecuteNonQuery();

                }
                else
                {
                    NpgsqlCommand cmd4 = new NpgsqlCommand("DELETE FROM noter WHERE id_critere =(SELECT id_critere FROM evaluation E INNER JOIN candidature C ON E.id_cand = C.id_cand WHERE id_critere ="+ idC +" AND id_offre ="+ unIdOffre, conn);
                    cmd4.ExecuteNonQuery();
                }
                
                conn.Close();
            }             
        }

        public static Dictionary<string,int>ModifierCritere(string libelle,int idOffre)
        {
            Dictionary<string, int> critereCoeff = new Dictionary<string, int>();
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                // connect à la bdd
                conn.Open();
                using (var cmd2 = new NpgsqlCommand("SELECT libelle_critere, coefficient FROM critere C INNER JOIN associer A ON A.id_critere= C.id_critere WHERE C.id_critere= (SELECT id_critere FROM CRITERE WHERE libelle_critere = '"+libelle+"') AND id_offre="+idOffre, conn))
                using (var reader = cmd2.ExecuteReader())
                    while (reader.Read())
                    {
                        critereCoeff.Add(reader.GetString(0), reader.GetInt32(1));
                    }
                conn.Close();
            }
            return critereCoeff;
        }

        public static void ModifCoeff(string libelle, int coeff)
        {
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();
                // modifier le coeff
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE associer SET coefficient='" + coeff + "' WHERE id_critere=(SELECT id_critere FROM CRITERE WHERE libelle_critere = '" + libelle + "')";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }

        }

        public static List<Critere> GetLesCriteresByOffre(int unIdOffre)
        {
            List<Critere> listCritere = new List<Critere>();
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT libelle_critere FROM critere c INNER JOIN associer a ON a.id_critere = c.id_critere  WHERE id_offre= " + unIdOffre, conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Critere unCritere = new Critere(reader.GetString(0));
                        listCritere.Add(unCritere);
                    }
                conn.Close();
            }
            return listCritere;
        }

        public static Dictionary<string, int> GetCritereCoeff(int idOffre)
        {
            Dictionary<string, int> critereCoeff = new Dictionary<string, int>();
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT libelle_critere, coefficient FROM associer INNER JOIN critere ON associer.id_critere = critere.id_critere WHERE id_offre = "+idOffre, conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        critereCoeff.Add(reader.GetString(0), reader.GetInt32(1));
                    }
                conn.Close();
            }
            return critereCoeff;
        }
    }
}
