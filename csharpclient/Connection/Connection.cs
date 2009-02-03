using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DE2_UE_Fahrradkurier
{
    class Connection
    {
        protected static object _lock = new object();
        protected static string _connectionString = "Password=sa;Persist Security Info=True;User ID=sa;Initial Catalog=de2_uebung_fahrradkurier;Data Source=wg-server";
        protected static SqlConnection _connection;

        public static SqlConnection Get()
        {
            lock (_lock)
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(_connectionString);
                }

                return _connection;
            }
        }
    }
}
