using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FillDataSetUsingSqlDataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectString = "Data Source = DESKTOP-PRHUBC6;Integrated Security = SSPI;Initial Catalog = AutoLot";
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Inventory",connectString);

            DataSet dataSet = new DataSet("AutoLot");

            dataAdapter.Fill(dataSet);

            PrintDataSet(dataSet);
        }
        public static void PrintDataSet(DataSet ds)
        {
            Console.WriteLine($"DataSet is named:{ ds.DataSetName} ");
            foreach (DictionaryEntry de in ds.ExtendedProperties)
            {
                Console.WriteLine($"Key = {de.Key}, Value = { de.Value}");
            }
            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine($"=> {dt.TableName} Table:");
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Write(dt.Columns[curCol].ColumnName + "\t");
                }
                WriteLine("\n----------------------------------");
                for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
                {
                    for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                    {
                        Write(dt.Rows[curRow][curCol].ToString().Trim() + "\t");
                    }
                    WriteLine();
                }
            }
        }
    }
}
