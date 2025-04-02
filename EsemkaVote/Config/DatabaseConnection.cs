using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemkaVote.Config
{
    internal class DatabaseConnection
    {
        private string _connection_string;

        public DatabaseConnection()
        {
            _connection_string = ConfigurationManager.ConnectionStrings["AccessConnection"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connection_string);
        }
    }
}
