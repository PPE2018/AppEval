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
            return "Host=localhost;Username=postgres;Password=postgres;Database=BddAppEval";
        }
    }
}
