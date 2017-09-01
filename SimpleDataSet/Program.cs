using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

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
            var carIDColumn = new DataColumn("CarID", typeof(int)) { Caption = "Car ID", ReadOnly = true, AllowDBNull = false, Unique = true };
            var carMakeColumn = new DataColumn("Make",typeof(string));
            var carPetNameColumn = new DataColumn("PetName", typeof(string)) { Caption="Pet Name"};
        }

        static void PrintDataSet(DataSet ds) { }
    }
}
