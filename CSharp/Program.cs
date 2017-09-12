using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TestCar();
            //(new ReflectTest()).test();
            //ExternalAssemblyReflector.test();
            //SharedAsmReflector.test();
            //StringTest();
            //MathTest();
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
            
        }
        static void func1(ref int[] arr)
        {
            for (int i=0;i<arr.Length;i+=2)
            {
                arr[i] += 10;
            }
            Console.WriteLine(string.Join(",",arr));
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
            Console.WriteLine(string.Join("迎", new char[] { '韩', '龙', '我' ,'c','d'}));
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
                Console.WriteLine("["+s+"]");
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
            Console.WriteLine(Math.Log(10,100));
            Console.WriteLine(Math.Log10(100));
            Console.WriteLine(Math.Max(1,3));
            Console.WriteLine(Math.Min(1, 3));
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(Math.Round(8.3333,2));
            Console.WriteLine(Math.Sign(-23));
            Console.WriteLine(Math.Sqrt(3));
            Console.WriteLine(Math.Truncate(9.33));
        
        }
    }
}
