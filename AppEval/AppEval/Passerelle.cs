using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace AppEval
{
    public static class Passerelle
    {
        public static void Connexion()
        {
            var connString = "Host=localhost;Username=postgres;Password=;Database=BddAppEval";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_critere, libelle_critere FROM critere", conn))
                using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                    Console.WriteLine(reader.GetString(1));
                }
            }
        }
    }
}
