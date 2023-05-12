using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BabyFoot
{
    public class Connexion
    {
        public NpgsqlConnection GetConn()
        {
            string connectionString = "Server=localhost;Port=5432;Database=babyfoot;User Id=postgres;Password=366325";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            return connection;
        }
    }
}
