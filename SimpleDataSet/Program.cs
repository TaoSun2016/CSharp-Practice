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
            var carInventoryDS = new DataSet("car inventory");

            carInventoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
            carInventoryDS.ExtendedProperties["DataSetID"] = Guid.NewGuid();
            carInventoryDS.ExtendedProperties["Company"] = "Mikko’s Hot Tub Super Store";

            FillDataSet(carsInventoryDS);
            PrintDataSet(carsInventoryDS);
            ReadLine();
        }
    }
}
