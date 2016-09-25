using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d, e, f, l;
            l = int.Parse(Console.ReadLine());
            a = l / 100000;
            b = (l / 10000) % 10;
            c = (l / 1000) % 10;
            d = (l / 100) % 10;
            e = (l / 10) % 10;
            f = l % 10;
            a += e + c;
            d += b + f;
            if (a == d)
            {
                Console.WriteLine("Билет является счастливым по-питерски");
            }
            else
            {
                Console.WriteLine("Билет не является счастливым по-питерски");
            }
            Console.ReadLine();

        }
    }
}
