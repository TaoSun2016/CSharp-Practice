using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ObjectContextApp
{
    class SportsCar
    {
        public SportsCar()
        {
            // Get context information and print out context ID.
            Context ctx = Thread.CurrentContext;
            Console.WriteLine("{0} object in context{1}",this.ToString(), ctx.ContextID);
            foreach (IContextProperty itfCtxProp in ctx.ContextProperties)
                Console.WriteLine("-> Ctx Prop: {0}", itfCtxProp.Name);
        }
    }
}
