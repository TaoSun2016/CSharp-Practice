using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("same instance");
            }
        }
    }

    class Singleton
    {
        private static readonly Singleton _instance = new Singleton();
        private int id;
        private string name;
       

        private Singleton() {
            id = 99;
            name = "Name of Singleton";
            Console.WriteLine("singleton initated");

        }

        public static Singleton GetInstance()
        {
            return _instance;
        }
    }
}
