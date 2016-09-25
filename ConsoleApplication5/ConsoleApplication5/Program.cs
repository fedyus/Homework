using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            int x2, k, x1, y2, m, y1;
            x1 = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            x2 = Convert.ToInt32(Convert.ToString(x1), k);
            y2 = Convert.ToInt32(Convert.ToString(y1), m);
            Console.WriteLine(x2);
            Console.WriteLine(y2);
            Console.ReadLine();
        }
    }
}
