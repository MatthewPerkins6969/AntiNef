using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiRobert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\System32\drivers\etc\hosts";
            if (File.ReadAllText(path).Contains("127.0.0.1 intent.store"))
            {
                Console.WriteLine("you have already used anti robert!");
                Console.ReadLine();
            }
            File.AppendAllText(path, Environment.NewLine + "127.0.0.1 intent.store");
            Console.WriteLine("you have been saved from Robert Anthony Lopresti!");
            Console.ReadLine();

        }
    }
}
