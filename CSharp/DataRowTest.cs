using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CSharp
{
    class DataRowTest
    {
        public static void Main()
        {
            DataTable table = new DataTable("TestTBL");
            table.Columns.Add( new DataColumn("col1", typeof(int)));
            table.Columns.Add(new DataColumn("col2", typeof(string)));

            DataRow row = table.NewRow();
            row["col1"] = 1;
            row["col2"] = "aaaa";
            Console.WriteLine(row.RowState);

            table.Rows.Add(row);
            Console.WriteLine(row.RowState);

            row.AcceptChanges();
            Console.WriteLine(row.RowState);
            row["col1"] = 8;
            row["col2"] = "888";

            Console.WriteLine(row.RowState);

            foreach (DataRow r in table.Rows)
            {
                Console.WriteLine(r["col1"]);
                Console.WriteLine(r["col2"]);
            }


        }
    }
}
