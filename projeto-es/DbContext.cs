using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_es
{
    public static class DbContext
    {
        public static string GetMySQLConnectionString()
        {
            return "Server=localhost;Database=esprojeto;Uid=root;Pwd=;";
        }
    }
}
