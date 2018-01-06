using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace DesignPattern
{
    class DbProvider
    {
        string providerString;
        string connectString;
        DbProviderFactory factory;

        public DbProvider()
        {
            providerString = ConfigurationManager.AppSettings["provider"];
            connectString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
            factory = DbProviderFactories.GetFactory(providerString);
        }

        public void GetData()
        {
            string sql = null;
            sql = "select * from client";
            using (DbConnection conn = factory.CreateConnection())
            {
                Console.WriteLine("Connection type is "+conn.GetType().Name);
                conn.ConnectionString = connectString;
                conn.Open();

                DbCommand command = conn.CreateCommand();
                command.CommandText = sql;
                Console.WriteLine("Command type is " + command.GetType().Name);
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    Console.WriteLine("Datareader type is " + dataReader.GetType().Name);
                    while (dataReader.Read())
                    {
                        Console.WriteLine(dataReader[0] + "  " + dataReader[1]);
                    }
                }

            }
        }
    }
}
