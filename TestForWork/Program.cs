using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            /*
            Console.WriteLine(Math.Exp(2));
            Console.WriteLine(Math.Pow(Math.E,2));
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.Log(Math.Exp(2)));
            Console.WriteLine(Math.Log10(100));

            string testString = "ABCDdfgh";
            Console.WriteLine(testString.Contains("A"));
            Console.WriteLine(testString.LastIndexOf('d',6));
            Console.WriteLine(testString.Remove(3,1));
            StringBuilder sb = new StringBuilder();
            Regex.Match("abcddddddd","^abc*");
            
            */
            //TestArray1();
            TestArray2();
        }
        static void TestArray1()
        {
            int[] myArray = new int[10];
            for (int i=0;i<myArray.Length;i++)
            {
                Console.Write($"Element[{i}]:");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (var i in myArray)
            {
                Console.Write($"{i} ");
            }

        }
        static void TestArray2()
        {
            Console.Write("Input the number of elements to store in the array:");
            int elementNumber = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementNumber];
            for (int i = 0; i < elementNumber; i++)
            {
                Console.WriteLine($"Element[{i}]:");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            for(int i = elementNumber - 1; i >= 0; i--)
            {
                Console.WriteLine($"{myArray[i]} ");
            }
        }
    }
}
