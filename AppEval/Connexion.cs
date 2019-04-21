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
            /*return "Host=localhost;Port=5432;Username=postgres;Password=;Database=BddAppEval";*/
            return "Host=localhost;Port=4747;Username=openpg;Password=;Database=BddAppEval";
        }

        public static string ConnectOdoo()
        {
            /*return "Host=localhost;Port=4545;Username=openpg;Password=openpgpwd;Database=ekara2";*/
            return "Host=localhost;Port=4747;Username=openpg;Password=openpgpwd;Database=ppe2";
        }
    }
}
