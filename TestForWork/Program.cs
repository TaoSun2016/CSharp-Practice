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

;
            //int[][][] a = new int[3][][];
            //for (int i = 0; i < a.Length; i++)
            //    a[i] = new int[i + 7];
            //int[,] a = new int[3, 4];
            Console.WriteLine(Math.Exp(2));
            Console.WriteLine(Math.Pow(Math.E,2));
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.Log(Math.Exp(2)));
            Console.WriteLine(Math.Log10(100));
           

        }
    }
}
