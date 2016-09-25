using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double procent;
            int N = int.Parse(Console.ReadLine());
            for (int i = 2; i <= N; i++)
                if (isSimple(i))
                {
                    count++;
                }
            procent = (count / (double)N) * 100;
            Console.WriteLine(count);
            Console.ReadLine();
        }
        public static bool isSimple(int N)
        {
            for (int i = 2; i < (N / 2); i++)
                if (N % i == 0)
                    return false;
            return true;
        }
    }
}
