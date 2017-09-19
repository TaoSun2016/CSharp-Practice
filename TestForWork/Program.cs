using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestForWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intMyArr = { { 7, 1, 3 }, { 2, 9, 6 } };
            Console.WriteLine(intMyArr.GetUpperBound(1));
            Console.WriteLine(intMyArr.Length);
            Console.WriteLine(intMyArr.GetUpperBound(0));

            string s1, s2;
            s1 = "Hi";
            s2 = "Hi";


            s2 = "fk";
            Console.WriteLine(s1+"  "+s2);

        }
    }
}
