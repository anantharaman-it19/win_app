using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace App1
{

    public class DatabaseConnection
    {
        private static SqlConnection _connection = null;
        private static readonly object _lock = new object();

        public static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                lock (_lock)
                {
                    if (_connection == null)
                    {
                        string connectionString = "Data Source=ANANTH-18788\\SQLEXPRESS;Initial Catalog=\"Company DB\";Integrated Security=True";
                        _connection = new SqlConnection(connectionString);
                        _connection.Open();
                    }
                }
            }
            return _connection;
        }
    }
}
