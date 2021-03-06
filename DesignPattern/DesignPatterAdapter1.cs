﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class DesignPatterAdapter1
    {
        public static void Main()
        {
            Target target = new Adapter();
            target.Request();
        }
    }


    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }


    class Adapter:Target
    {
        private Adaptee _adaptee = new Adaptee();
        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called specificrequest!");
        }
    }
}
