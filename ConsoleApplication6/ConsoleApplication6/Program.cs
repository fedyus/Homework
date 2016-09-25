using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, i = 0;
            long s = 1, x, y = 0;
            x = long.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                y += (x % k) * (Convert.ToInt32(Math.Pow(10, i)));
                x /= k;
                i++;
            }
            while (y != 0)
            {
                s *= y % 10;
                y /= 10;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
