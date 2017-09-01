using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace SimpleDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***** Fun with DataSets *****\n");
            // Create the DataSet object and add a few  properties.
            var carsInventoryDS = new DataSet("car inventory");

            carsInventoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
            carsInventoryDS.ExtendedProperties["DataSetID"] = Guid.NewGuid();
            carsInventoryDS.ExtendedProperties["Company"] = "Mikko’s Hot Tub Super Store";

            FillDataSet(carsInventoryDS);
            PrintDataSet(carsInventoryDS);
            ReadLine();
        }

        static void FillDataSet(DataSet ds) {
            var carIDColumn = new DataColumn("CarID", typeof(int))
            { Caption = "Car ID", ReadOnly = true, AllowDBNull = false, Unique = true ,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };
            var carMakeColumn = new DataColumn("Make",typeof(string));
            var carColorColumn = new DataColumn("Color",typeof(string));
            var carPetNameColumn = new DataColumn("PetName", typeof(string)) {Caption="Pet Name"};

            var inventoryTable = new DataTable("Inventory");
            inventoryTable.Columns.AddRange(new[]
            {carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn});
            inventoryTable.PrimaryKey = new[] {inventoryTable.Columns[0] };
            ds.Tables.Add(inventoryTable);
        }

        static void PrintDataSet(DataSet ds)
        {// Print out the DataSet name and any extended properties.
            WriteLine($"DataSet is named:{ds.DataSetName}");
            foreach (DictionaryEntry de in ds.ExtendedProperties)
            {
                WriteLine($"Key = {de.Key}, Value = {de.Value}");
            }
            WriteLine();

            // Print out each table using rows and columns. 
            foreach (DataTable dt in ds.Tables)
            {
                WriteLine($"=> {dt.TableName} Table:");

                // Print out the column names.
                for (var curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Write($"{dt.Columns[curCol].ColumnName}\t");
                }
                WriteLine("\n----------------------------------");

                // Print the DataTable.
                for (var curRow = 0; curRow < dt.Rows.Count; curRow++)
                {
                    for (var curCol = 0; curCol < dt.Columns.Count; curCol++)
                    {
                        Write($"{dt.Rows[curRow][curCol]}\t");
                    }
                    WriteLine();
                }
            }
        }
            private static void ManipulateDataRowState()
        {
            // Create a temp DataTable for testing.
            var temp = new DataTable("Temp");
            temp.Columns.Add(new DataColumn("TempColumn", typeof(int)));

            // RowState = Detached.
            var row = temp.NewRow();
            WriteLine($"After calling NewRow():{row.RowState}");

            // RowState = Added.
            temp.Rows.Add(row);
            WriteLine($"After calling Rows.Add():{row.RowState}");

            // RowState = Added.
            row["TempColumn"] = 10;
            WriteLine($"After first assignment:{row.RowState}");

            // RowState = Unchanged.
            temp.AcceptChanges();
            WriteLine($"After calling AcceptChanges:{row.RowState}");

            // RowState = Modified.
            row["TempColumn"] = 11;
            WriteLine($"After first assignment:{row.RowState}");

            // RowState = Deleted.
               temp.Rows[0].Delete();
            WriteLine($"After calling Delete:{row.RowState}");
        }
    }
}
