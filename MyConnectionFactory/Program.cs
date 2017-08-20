using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Configuration;

namespace MyConnectionFactory
{
    class Program
    {
        enum DataProvider
        { SqlServer, OleDb, Odbc, None }
        static void Main(string[] args)
        {
            WriteLine("**** Very Simple Connection Factory* ****\n");
            // Read the provider key.
            string dataProviderString= ConfigurationManager.AppSettings["provider"];
            // Transform string to enum.
            DataProvider dataProvider = DataProvider.None;
            if (Enum.IsDefined(typeof(DataProvider), dataProviderString))
            {
                dataProvider = (DataProvider)
                Enum.Parse(typeof(DataProvider),
                dataProviderString);
            }
            else
            {
                WriteLine("Sorry, no provider exists!");
                ReadLine();
                return;
            }
            // Get a specific connection.
            IDbConnection myConnection = GetConnection(dataProvider);
            WriteLine($"Your connection is a { myConnection.GetType().Name}");
            // Open, use and close connection...
            ReadLine();
        }
        // This method returns a specific connection object
        // based on the value of a DataProvider enum.
        static IDbConnection GetConnection(DataProvider dataProvider)
        {
            IDbConnection connection = null;
            switch (dataProvider)
            {
                case DataProvider.SqlServer:
                    connection = new SqlConnection();
                    break;
                case DataProvider.OleDb:
                    connection = new OleDbConnection();
                    break;
                case DataProvider.Odbc:
                    connection = new OdbcConnection();
                    break;
            }
            return connection;
        }
    }
}
