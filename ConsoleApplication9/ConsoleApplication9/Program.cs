using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            long x1, x2 = 0;
            x1 = long.Parse(Console.ReadLine());
            if (x1 % 5 != 0)
            {
                Console.WriteLine("Число не кратно 5 ");
            }
            else
            {
                x2 = (x1 / 10) * (x1 / 10 + 1) * 100 + 25;
            }
            Console.WriteLine(x2);
            Console.ReadLine();
        }
    }
}
