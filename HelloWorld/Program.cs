using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Delali Funani";
            Console.WriteLine($"Hello, please enter\n name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!!!");
            Console.ReadKey(true);
        }
    }
}
