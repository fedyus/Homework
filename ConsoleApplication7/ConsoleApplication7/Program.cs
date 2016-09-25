using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, k = 0, c = 0, m = 0;
            while (x != 0)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= m)
                {
                    m = x;
                    c = k;
                    k = 0;
                }
                if (x == m)
                {
                    k++;
                }
                if (c <= k)
                {
                    c = k;
                }
            }
            Console.WriteLine(m);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}