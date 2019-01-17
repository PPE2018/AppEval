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
                    //Id de l'offre à changer !!!
                    cmd3.CommandText = "INSERT INTO associer (id_critere, id_offre, coefficient) VALUES (" + id + ", "+unIdOffre+"," + uneAssociation.GetCoeff() + ")";
                    cmd3.ExecuteNonQuery();
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
