using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with  Directory(Info) * ****\n");
            ShowWindowsDirectoryInfo();
            Console.ReadLine();
        }

        static void ShowWindowsDirectoryInfo()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\windows");
            Console.WriteLine(di.FullName);
            Console.WriteLine(di.Name);
            Console.WriteLine(di.Root);
            Console.WriteLine(di.Attributes);
            Console.WriteLine(di.CreationTime);
        }
    }
}
