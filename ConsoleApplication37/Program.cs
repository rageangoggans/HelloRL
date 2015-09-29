using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = (Console.ReadLine());
            string result = Hello(name);
            Console.WriteLine(result);
        }

        static string Hello(string name)
        {
            string Hello = "Hello " +" "+ name;
            return Hello;
        }

    }


}
