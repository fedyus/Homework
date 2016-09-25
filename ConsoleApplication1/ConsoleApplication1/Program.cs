using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            x = x + y;
            if (x % 2 == 0)
            {
                Console.WriteLine("BLACK");
            }
            else
            {
                Console.WriteLine("WHITE");
            }
            Console.ReadLine();
        }
    }
}
