using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract3_ex2_3
{
        class Program
        {
            static double f(double x)
            {
                double y;
                if ((x * x + (2 * x) + 1) < 2)
                    y = x * x;
                else if (((x * x + (2 * x) + 1) < 2) && ((x * x + (2 * x) + 1)) >= 2)
                    y = 1 / (x * x - 1);
                else y = 0;
                return y;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Enter edge a:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter edge b:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter step h:");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                for (double i = a; i <= b; i += h)

                    Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
                double y;
                Console.WriteLine();
                for (double i = a; i <= b; i += h)
                {
                    fX(i, out y);
                    Console.WriteLine("f({0:f2})={1:f4}", i, y);
                }
                Console.ReadKey();
            }
            private static void fX(double x, out double y)
            {
                y = 0.0;
                if ((x * x + (2 * x) + 1) < 2)
                    y = x * x;
                else if (((x * x + (2 * x) + 1) < 3) && ((x * x + (2 * x) + 1)) >= 2)
                    y = 1 / (x * x - 1);
                else y = 0;
            }
        }
}
