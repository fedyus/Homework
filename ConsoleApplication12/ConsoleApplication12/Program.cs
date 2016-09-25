using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0, f = 0, c = 0, i = 0;
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                f += (n % 2) * (Convert.ToInt32(Math.Pow(10, i)));
                n /= 2;
                i++;
            }
            while (f != 0)
            {
                if (f % 10 == 0)
                {
                    k++;
                }
                else
                {
                    if (c <= k)
                    {
                        c = k;
                    }
                    k = 0;
                }
                f /= 10;
            }

            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
