using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i < 10000; i++)
                if (Num(i))
                    Console.WriteLine(i);

            Console.ReadKey();

        }

        public static bool Num(int num)
        {
            return ((int)Math.Pow((num / 1000 + num % 1000 / 100 + num % 100 / 10 + num % 10), 4) == num)
                ? true : false;
        }
    }
}
