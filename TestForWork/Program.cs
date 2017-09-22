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
            /*int[,] intMyArr = { { 7, 1, 3 }, { 2, 9, 6 } };
            Console.WriteLine(intMyArr.GetUpperBound(1));
            Console.WriteLine(intMyArr.Length);
            Console.WriteLine(intMyArr.GetUpperBound(0));*/

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
            TestArray9();
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
            /*Console.Write("Input the number of elements to store in the array:");
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
            */
            List<char> myArray2 = new List<char>{ '0','1','3'};
            Console.WriteLine(myArray2.Where(m=>m!='0').Count());
            
            foreach (var i in myArray2.Where(m => m != '0'))
            {
                Console.WriteLine(i);
            }
        }
        static void TesInput()
        {
            int number=-1;
            bool inputError = false;
            do
            {
                Console.Write("Please input a number:");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    inputError = false;
                }
                catch
                {
                    Console.WriteLine("InputError,try again!");
                    inputError = true;
                }
            } while (inputError);


            Console.WriteLine($"The number inputted is {number}");
        }
       
        static void TestArray3()
        {
            Console.WriteLine("Please input the number of array");
            int elementNumber = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementNumber];
            InputArray(myArray);
            Console.WriteLine(SumOfArray(myArray));
            
        }
        static void TestArray4()
        {
            Console.WriteLine("Please input the number of array");
            int elementNumber = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementNumber];
            int[] destinationArray =new int[elementNumber]; ;
            InputArray(myArray);
            myArray.CopyTo(destinationArray, 0);
            ShowArray(myArray);
            ShowArray(destinationArray);
            Console.WriteLine(myArray==destinationArray);
        }
        static void TestArray5()
        {
            Console.WriteLine("Please input the number of array");
            int elementNumber = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementNumber];
            int[] destinationArray = new int[elementNumber]; ;
            InputArray(myArray);
            foreach (var i in (myArray.Distinct()))
            {
                Console.Write($"[{i}]");
            }
            Console.WriteLine();

        }
        static void TestArray7()
        {
            Console.WriteLine("Please input the number of array1");
            int elementNumber1 = int.Parse(Console.ReadLine());
            int[] myArray1 = new int[elementNumber1];
            InputArray(myArray1);

            Console.WriteLine("Please input the number of array2");
            int elementNumber2 = int.Parse(Console.ReadLine());
            int[] myArray2 = new int[elementNumber2];
            InputArray(myArray2);
            int[] myArray3 = new int[elementNumber1 + elementNumber2];
            myArray1.CopyTo(myArray3,0);
            myArray2.CopyTo(myArray3, myArray1.Length);
            ShowArray(myArray3);
            Array.Sort(myArray3);
            ShowArray(myArray3);
        }
        static void TestArray8()
        {
            Console.WriteLine("Please input the number of array1");
            int elementNumber1 = int.Parse(Console.ReadLine());
            int[] myArray1 = new int[elementNumber1];
            InputArray(myArray1);

            foreach (var i in (myArray1.GroupBy(m=>m)))
            {
                Console.WriteLine(i.Key +" "+ i.Count());
            }
        }

        // find maximum and minimum element in an array
        static void TestArray9()
        {
            Console.WriteLine("Please input the number of array1");
            int elementNumber1 = int.Parse(Console.ReadLine());
            int[] myArray1 = new int[elementNumber1];
            InputArray(myArray1);


                Console.WriteLine(myArray1.Max());
            Console.WriteLine(myArray1.Min());

        }
        static void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element[{i}]:");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        static void ShowArray(int[] array)
        {
            foreach (var i in array)
            {
                Console.Write($"[{i}] ");
            }
            Console.WriteLine();
        }
        static int SumOfArray(int[] array)
        {
            return array.Sum(i=> i);
        }
    }
}
