using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, c = 0, i = 0;
            long x;
            x = long.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                if (x % 10 == k)
                {
                    i++;
                }
                else
                {
                    if (c <= i)
                    {
                        c = i;
                    }
                    i = 0;
                }
                x /= 10;
            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
