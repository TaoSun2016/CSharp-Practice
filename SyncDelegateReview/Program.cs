using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncDelegateReview
{
    public delegate int BinaryOp(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Synch Delegate Review * ****");
            // Print out the ID of the executing thread.
            Console.WriteLine("Main() invoked on thread {0}.",Thread.CurrentThread.ManagedThreadId);
            // Invoke Add() in a synchronous manner.
            BinaryOp b = new BinaryOp(Add);
            IAsyncResult asresult = b.BeginInvoke(10, 10, null, null);
            // Could also write b.Invoke(10, 10);
            //int answer = b(10, 10);
            // These lines will not execute until
            // the Add() method has completed.
            /*while (!asresult.IsCompleted)
            {
                Console.WriteLine("Doing more work in  Main()!");
                Thread.Sleep(1000);
            }*/
            while (!asresult.AsyncWaitHandle.WaitOne(1000,true))
            {
                Console.WriteLine("Doing more work in Main()!");
            }
            int answer = b.EndInvoke(asresult);
            Console.WriteLine("10 + 10 is {0}.", answer);
            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            // Print out the ID of the executing thread.
            Console.WriteLine("Add() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
            // Pause to simulate a lengthy operation.
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
