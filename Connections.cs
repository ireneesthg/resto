using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System;

namespace resto.Tools
{
    public static class Connections
    {
        public static string ConnParamPostgreSQL()
        {
            string result = string.Empty;
            result = "Host=localhost;Port=5432;Username=postgres;Password=696;Database=restodb;";
            return result;
        }
    }
}
