using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Singleton
    {
        private static Singleton single;
        public int ID { get; set; }

        public Singleton()
        {
            ID = 88;
        }
        public static Singleton instance()
        {
            if (single == null)
            {
                single = new Singleton();
            }
            return single;

        }
    }
}
