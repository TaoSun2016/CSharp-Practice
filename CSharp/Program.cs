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
            StringTest();
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

        }

    }
}
