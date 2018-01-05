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
            //Singleton
            //Singleton singleton1 = Singleton.GetInstance();
            //Singleton singleton2 = Singleton.GetInstance();

            //if (singleton1 == singleton2)
            //{
            //    Console.WriteLine("same instance");
            //}
            //Console.WriteLine(singleton1.GetId());
            //Console.WriteLine(singleton2.GetId());
            //Console.WriteLine("------------------------------------------");

            //Abstract Factory 1
            // Abstract factory #1
            AbstractFactory1 factory1 = new ConcreteFactory11();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            AbstractFactory1 factory2 = new ConcreteFactory12();
            Client client2 = new Client(factory2);
            client2.Run();


            Console.WriteLine("------------------------------------------");
        }
    } 
}
