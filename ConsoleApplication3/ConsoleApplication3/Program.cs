using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a != 0)
            {
                if (a == 1)
                {
                    Console.Write("x^2");
                }
                if (a == -1)
                {
                    Console.Write("-x^2");
                }
                if ((a != 1) && (a != -1))
                {
                    Console.Write("{0}x^2", a);
                }

            }
            if (b != 0)
            {
                if (b == 1)
                {
                    Console.Write("+x");
                }
                else
                {
                    if (b == -1)
                    {
                        Console.Write("-x");
                    }
                    else
                    {
                        if (b > 0)
                        {
                            Console.Write("+{0}x", b);
                        }
                        else
                        {
                            Console.Write("{0}x", b);
                        }
                    }
                }
            }
            if (c != 0)
            {
                if (c > 0)
                {
                    Console.Write("+{0}", c);
                }
                else
                {
                    Console.Write(c);
                }
            }
            Console.ReadLine();
        }
    }
}
