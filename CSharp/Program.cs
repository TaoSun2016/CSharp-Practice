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
            MathTest();
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

        }
    }
}
