using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public static class ConnexioOdoo
    {
        public static string ConnectOdoo()
        {
            return "Host=localhost;Port= 4747;Username=openpg;Password=openpgpwd;Database=pp2";
        }
    }
}
