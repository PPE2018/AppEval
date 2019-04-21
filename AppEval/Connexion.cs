using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public static class Connexion
    {
        public static string Connecter()
        {
            return "Host=localhost;Port=4747;Username=openpg;Password=;Database=BddAppEval";
        }

        public static string ConnectOdoo()
        {
            return "Host=localhost;Port=4747;Username=openpg;Password=;Database=ppe2";
        }
    }
}
