using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace resto
{
    class Database
    {
            private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=696;Database=Resto";

            public static NpgsqlConnection GetConnection()
            {
                return new NpgsqlConnection(connectionString);
            }
        
    }

}
