using System;

namespace praktik_1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Решение квадратного уравнения ax*2+bx+c=0");
            Console.WriteLine("Введите a");
            string aString = Console.ReadLine();
            int a = Convert.ToInt32(aString);
            Console.WriteLine("Введите b");
            string bString = Console.ReadLine();
            int b = Convert.ToInt32(bString);
            Console.WriteLine("Введите c");
            string cString = Console.ReadLine();
            int c = Convert.ToInt32(cString);
            int d = b * b - 4 * c * a;
            Console.WriteLine($"Дискриминант равен: {d}");
            if (d < 0)
            {
                Console.WriteLine("Так как дискриминант меньше 0, то уравнение не имеет действительных решений.");
            }
            else if (d > 0)
            {
                //var z = Math.Sqrt(d);
                double y = (-b + Math.Sqrt(d)) / (2 * a);
                double l = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Так как дискриминант больше 0, то уравнение имеет два решения.");
                Console.WriteLine($"x1={y}");
                Console.WriteLine($"x2={l}");
            }
            else
            {
                double x = -b / 2 * a;
                Console.WriteLine("Так как дискриминант равен 0, то уравнение имеет одно решение.");
                Console.WriteLine($"x1={x}");
            }
            Console.WriteLine("Нажмите Enter для завершения");
            Console.WriteLine("Rimpac forever");
            Console.ReadLine();

        }

    }
}
