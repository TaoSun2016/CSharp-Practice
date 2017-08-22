using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Singleton
    {
        private static readonly Singleton single = new Singleton();
        public int ID { get; set; }

        private Singleton()
        {
            ID = 88;
        }
        public static Singleton instance()
        {
            return single;
        }
    }
}
