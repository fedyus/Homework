using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication38
{
    class Program
    {

        static int SumDel(int x)
        {
            int res = 0;
            for (int i = 1; i <= x / 2; i++)
                if (x % i == 0) res += i;
            return res;
        }
        static void Main(string[] args)
        {
            int n = 1;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (SumDel(SumDel(i)) == i)
                    Console.WriteLine(i + " и " + SumDel(i) + "\n");
            }
            Console.ReadLine();
        }
    }
}
