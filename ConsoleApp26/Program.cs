using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите стороны треугольника");
            Console.Write("Введите сторону а = ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону d = ");
            var d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону c = ");
            var c = Convert.ToInt32(Console.ReadLine());
            if (check(a, d, c) != 0)
            {
                Console.WriteLine($"Периметр треугольника равен = {check(a, d, c)}");
                Console.WriteLine($"Площадь треугольника = {Math.Round(Area(a,d,c),4)}");                             
                Console.WriteLine($"Площадь внутренней акружности = {Math.Round(Area_of_inner_circle(a,d,c),4)}");
            }
            else
            {
                Console.WriteLine("были введены неккоретные данные");
            }
            Console.ReadKey();
        }

        static int Perimeter(int a, int d, int c) => a + d + c;       

        static double Area(int a, int d, int c)
        {
            var P = (a + d + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - d) * (P - c));
            return S;
        }

        static double Area_of_inner_circle(int a, int d, int c)
        {
            var P = (a + d + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - d) * (P - c)); ;
            double R = S / P;   
            double area_of_inner_circle = 3.14 * Math.Pow(R, 2);
            return area_of_inner_circle;
        }

        static int check(int a, int d, int c)
        {
            if (a > 0 & d > 0 & c > 0)
            {
                if ((d + c) > a & (a + c) > d & (a + d) > c)
                {
                    return Perimeter(a, d, c);                    
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }
    }
}
