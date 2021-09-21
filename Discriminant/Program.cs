using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c:");
            double c = double.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - 4 * (a * c);
            double x1 = -b + Math.Sqrt(discriminant) / 2 * a;
            double x2 = -b - Math.Sqrt(discriminant) / 2 * a;

            if (discriminant < 0)
            {
                Console.WriteLine("Нет корней");
            }
            else
            {
                if(discriminant == 0)
                {
                    Console.WriteLine(x1);
                }

                else
                {
                    Console.WriteLine($"{x1} / {x2}");
                }
            }


            Console.ReadKey();

        }
    }
}
