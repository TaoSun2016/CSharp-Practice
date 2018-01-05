using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Singleton
    {
        private static readonly Singleton _instance = new Singleton();
        private int id;
        private string name;


        private Singleton()
        {
            id = 99;
            name = "Name of Singleton";
            Console.WriteLine("singleton initated");

        }

        public static Singleton GetInstance()
        {
            return _instance;
        }

        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
    }
}
