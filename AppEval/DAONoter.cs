using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AppEval
{
    public static class DAONoter
    {
        public static Dictionary<string, double> AfficherTableauBord(int idCand)
        {
            Dictionary<string, double> resul = new Dictionary<string, double>();
            using (var conn = new NpgsqlConnection(Connexion.Connecter()))
            {
                // connect à la bdd
                conn.Open();
                using (var cmd2 = new NpgsqlCommand("SELECT nom_prenom_RH, notetotal FROM EVALUATION E INNER JOIN CANDIDATURE C ON C.id_cand = E.id_cand WHERE E.id_cand =" + 1 + "ORDER BY notetotal desc", conn))
                using (var reader = cmd2.ExecuteReader())
                    while (reader.Read())
                    {
                        resul.Add(reader.GetString(0), reader.GetDouble(1));
                    }
                conn.Close();

            }

            return resul;
        }
    }
}
