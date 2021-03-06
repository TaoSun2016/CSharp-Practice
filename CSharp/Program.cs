﻿using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CSharp
{
    public class Program
    {
        static string testStr;
        static DateTime testDate;
        static int? testInt;
        static void Main(string[] args)
        {

            int i = 7, j = 8;
            STRUC s1 = new STRUC { id=1,name="aa"};
            STRUC s2 = new STRUC { id =21, name = "bb" };
            TestSwap1<int>(i,j);
            Console.WriteLine(i + "  " + j);
            TestSwap1<STRUC>(s1, s2);
            Console.WriteLine(s1.name + "  " + s2.name);




            //TestDic();
            //TestCar();
            //(new ReflectTest()).test();
            //ExternalAssemblyReflector.test();
            //SharedAsmReflector.test();
            //StringTest();
            // MathTest();
            /*
            Singleton s1 = Singleton.instance();
            Singleton s2 = Singleton.instance();
            if (s1 == s2)
            {
                Console.WriteLine("Singleton OK!");
            }
            Console.WriteLine(s1.ID);
            Console.WriteLine(s2.ID);
            s1.ID = 99;
            Console.WriteLine(s1.ID);
            Console.WriteLine(s2.ID);
            */
            /*
            int [] tstArray = new int [] {1,2,3,4,5 };
            func1(ref tstArray);

            int x = 4, b = 2;
            b /= 8;
            Console.WriteLine(b);
            x -= (b);
            Console.WriteLine(x + " " + b);
            Console.ReadLine();
            */
            //Console.WriteLine("Hello world!");
            /*
            HondaCar honda = new HondaCar() { RegisterNumber="88888",Seats=5,Wheels=5,Windows=4};
            BMWCar bmw = new BMWCar() { RegisterNumber = "55555", Seats = 5, Wheels = 5, Windows = 4 };
            Console.WriteLine("HONDA");
            Console.WriteLine("Honda's register number is :{0}.",honda.GetRegisterNumber());
            Console.WriteLine("Honda's seat number is :{0}.", honda.GetSeatsNumber());
            Console.WriteLine("Honda's wheel number is :{0}.", honda.GetWheelsNumber());
            Console.WriteLine("Honda's window number is :{0}.", honda.GetWindowsNumber());

            Console.WriteLine("BMW");
            Console.WriteLine("BMW's register number is :{0}.", bmw.GetRegisterNumber());
            Console.WriteLine("BMW's seat number is :{0}.", bmw.GetSeatsNumber());
            Console.WriteLine("BMW's wheel number is :{0}.", bmw.GetWheelsNumber());
            Console.WriteLine("BMW's window number is :{0}.", bmw.GetWindowsNumber());
            */
            /*
            int num1, num2,result;
            string operand;
            string inputString;
            try
            {
                Console.Write("Please input a number:");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Please input a operand:");
                operand = Console.ReadLine().Trim();
                Console.Write("Please input another number:");
                num2 = int.Parse(Console.ReadLine());

                switch (operand)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        result = -1;
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return;
            }
            finally
            {
            }
            Console.WriteLine("Result is :{0}.",result);
            */
            //LINQ
            /*
            List<string> testList = new List<string> { "a", "aa", "aaa", "b", "bb", "bbb", "c", "cc", "ccc", "abc", "abcdefg" };

            var totalA = testList.Where(x => x == "a" || x == "c");
            var containB = testList.Contains("b");
            var containF = testList.Contains("f");
            var groupByString = testList.GroupBy(a=>a);
            var firstElement = testList.First();
            var lastElement = testList.Last();
            var firstDefault = testList.Where(a => a == "x").FirstOrDefault();
            Console.WriteLine("totalA");
            foreach (var i in totalA)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("containB=" + containB);

            Console.WriteLine("containF=" + containF);

            Console.WriteLine("groupByString" );
            foreach (var i in groupByString)
            {
                Console.WriteLine("Key="+i.Key);
                foreach (var j in i)
                {
                    Console.WriteLine(j);
                }
            }

            Console.WriteLine("firstElement=" + firstElement);

            Console.WriteLine("firstElement=" + lastElement);

            Console.WriteLine("firstDefault=[" + firstDefault+"]");
            */
            /*
            string inputParameter =  Console.ReadLine();
            string[] arrayParameter = inputParameter.Split(new[] { ' ' });
            Console.WriteLine(GetSum(int.Parse(arrayParameter[0]),int.Parse(arrayParameter[1])));
            */
            /*
            Console.WriteLine("","");
            Console.WriteLine((testStr == null)?"testStr is null":testStr);
            Console.WriteLine((testDate == null)?"testDate is null":testDate.ToString());
            Console.WriteLine(testInt == null?"testInt is null":testInt.ToString());
            */
            //TestLinq2Object();
            //TestLinqIn();
            //TestDate();
            //TestNumberOutput();
            //BasicMember();

            //TestEnum();
            //TestSwitch();
        }
        static void TestLinq2DataSet()
        {
            //string connectString = ConfigurationManager.ConnectionStrings("");
        }
        static void TestLinq2Object()
        {
            string[] tools = { "Tablesaw", "Bandsaw", "Planer", "Jointer", "Drill", "Sander" };
            var list = from t in tools select t;

            StringBuilder sb = new StringBuilder();

            foreach (string s in list)
            {
                sb.Append(s + Environment.NewLine);
            }

            Console.WriteLine(sb.ToString(), "Tools");
            Console.ReadLine();

        }



        static void func1(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i += 2)
            {
                arr[i] += 10;
            }
            Console.WriteLine(string.Join(",", arr));
        }
        static void TestCar()
        {
            Console.WriteLine("***** C# CarLibrary  Client App * ****");
            // Make a sports car.
            SportsCar viper = new SportsCar("Viper", 240, 40);
            viper.TurboBoost();
            // Make a minivan.
            MiniVan mv = new MiniVan();
            mv.TurboBoost();
            Console.WriteLine("Done. Press any key to terminate");
            Console.ReadLine();
        }
        static void StringTest()
        {
            Console.WriteLine(string.Join("aa", new string[] { "bb", "cc", "dd" }));
            Console.WriteLine(string.Join("迎", new char[] { '韩', '龙', '我', 'c', 'd' }));
            Console.WriteLine("==========================================");
            string str = "I Have a Dream";
            string[] divisionstr = str.Split(' ');
            foreach (string s in divisionstr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("==========================================");

            divisionstr = str.Split(new char[] { ' ' }, 2);
            foreach (string s in divisionstr)
            {
                Console.WriteLine("[" + s + "]");
            }
            Console.WriteLine("==========================================");
            str = " 梅西| 卡 卡|小龙 ";
            //divisionstr = str.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            divisionstr = str.Split(new char[] { '|', ' ' });
            foreach (string s in divisionstr)
            {
                Console.WriteLine("[" + s + "]");
            }
            Console.WriteLine("==========================================");

            str = "梅西|卡卡|小龙";
            divisionstr = str.Split(new char[] { '|' }, 2, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in divisionstr)
            {
                Console.WriteLine("[" + s + "]");
            }
            Console.WriteLine("==========================================");


            str = "地s球很美好，我们s很喜欢";
            int res = str.IndexOfAny(new char[] { 'f', 'm' });
            Console.WriteLine(res);
            Console.WriteLine("==========================================");

            str = "地球很美好，我们很喜欢";
            res = str.IndexOfAny(new char[] { '球', '我', '喜' }, 2, 5);
            Console.WriteLine(res);

            Console.WriteLine("==========================================");

            string dest = "Hello world";
            string source = "Goodbye China";
            char[] destArray = dest.ToCharArray();//将dest变成字符数组
            source.CopyTo(8, destArray, 6, 5);//从source的第8个字符起复制5个字符并从destArray的第6个位置开始放
            dest = new string(destArray);//这时dest为"Hello China"
            Console.WriteLine(dest);
            Console.WriteLine("111".Contains("11"));



        }
        static void MathTest()
        {
            Console.WriteLine(Math.Abs(-13.33));
            Console.WriteLine(Math.Ceiling(1.33));
            Console.WriteLine(Math.Floor(1.33));
            Console.WriteLine(Math.Exp(2));
            Console.WriteLine(Math.Log(10, 100));
            Console.WriteLine(Math.Log10(100));
            Console.WriteLine(Math.Max(1, 3));
            Console.WriteLine(Math.Min(1, 3));
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Round(8.3333, 2));
            Console.WriteLine(Math.Sign(-23));
            Console.WriteLine(Math.Sqrt(3));
            Console.WriteLine(Math.Truncate(9.33));

        }

        public static int GetSum(int num1, int num2)
        {
            int sum = 0;
            for (int i = num1 + 1; i <= num2; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static bool IsPrime(int num)
        {
            if (num == 1 || num == 2 || num == 3)
            {
                Console.WriteLine("{0} is prime number", num);

                return true;
            }
            for (int i = 2; i < (Math.Sqrt(num) + 1); i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0} is not prime number", num);

                    return false;
                }
            }
            Console.WriteLine("{0} is prime number", num);
            return true;
        }
        public static long GetSumOfEven1(int[] inputArray)
        {
            return inputArray.Where(a => a % 2 == 0).Sum(a => (long)a);
        }

        public static long GetSumOfEven2(int[] inputArray)
        {
            return (from i in inputArray
                    where i % 2 == 0
                    select (long)i).Sum();
        }

        public static void TestLinqSort()
        {
            Console.WriteLine("hello");
            List<STRUC> list = new List<STRUC>();

            list.Add(new STRUC { id = 1, name = "A" });
            list.Add(new STRUC { id = 3, name = "B" });
            list.Add(new STRUC { id = 2, name = "B" });


            foreach (var i in list)
            {
                Console.WriteLine(i.id + "  " + i.name);
            }
            //var l1 = list.AsQueryable().OrderBy(m => m.id);
            //foreach (var i in l1)
            //{
            //    Console.WriteLine(i.id + "  " + i.name);
            //}
            var l2 = list.AsQueryable().OrderByDescending(m => m.name);
            foreach (var i in l2)
            {
                Console.WriteLine(i.id + "  " + i.name);
            }
        }
        public static void TestLinqIn()
        {
            Console.WriteLine("hello");
            List<STRUC> list = new List<STRUC>();

            list.Add(new STRUC { id = 1, name = "A" });
            list.Add(new STRUC { id = 3, name = "B" });
            list.Add(new STRUC { id = 2, name = "B" });
            list.Add(new STRUC { id = 4, name = "c" });


            foreach (var i in list)
            {
                Console.WriteLine(i.id + "  " + i.name);
            }
            //var l1 = list.AsQueryable().OrderBy(m => m.id);
            //foreach (var i in l1)
            //{
            //    Console.WriteLine(i.id + "  " + i.name);
            //}
            string aa = "A";
            Console.WriteLine("====================");
            var l2 = list.Where(x => x.name == aa);
            foreach (var i in l2)
            {
                Console.WriteLine(i.id + "  " + i.name);
            }
        }
        static void TestDate()
        {
            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToString());
            Console.WriteLine(String.Format("{0: MMMM d yyyy}", d));
        }

        static void TestNumberOutput() {
            Console.WriteLine("{0:c3}", 99.998);  //$99.998
            Console.WriteLine("{0:d7}", 99);
            Console.WriteLine("{0:e}", 99.998);
            Console.WriteLine("{0:f2}", 99.998);
            Console.WriteLine("{0:g}", 99.998);
            Console.WriteLine("{0:n3}", 1199.998);
            Console.WriteLine("{0:x}", 99);
        }

        static void BasicMember()
        {
            Console.WriteLine(char.IsDigit('1'));
            Console.WriteLine(char.IsNumber('1'));

        }

        static void TestEnum()
        {
            var array = Enum.GetValues(typeof(EnumTest));
            foreach (var i in array) {
                Console.WriteLine(i);
            }
        }

        static void TestSwitch()
        {
            char d = 'A';
            switch (d)
            {
                case 'A':
                    Console.WriteLine("8.0");
                    break;
                case 'B':
                    Console.WriteLine("8.4");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            
        }

        static void TestDic()
        {
            Dictionary<int, string> dic = new Dictionary<int, string> { { 1, "11" }, { 2, "22" } };
            Console.WriteLine(dic[1]);
            dic.Add(3,"333");
            Dictionary<int, string> dic1 = new Dictionary<int, string> {[1]="AA",[2]="BB" };
            Console.WriteLine(dic1[1]);

        }
        static void TestSwap1<T>(T a, T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void TestSwap2<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

    }

    public class STRUC
    {
        public int id { get; set; }
        public  string name { get; set; }
    }
    enum EnumTest
    {
        V1,
        V2,
        V3
            
    }
}
