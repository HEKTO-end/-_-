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
            Class1 pipio = new Class1();
            if (pipio.Check(a, d, c) != 0)
            {
                Console.WriteLine($"Периметр треугольника равен = {pipio.Check(a, d, c)}");
                Console.WriteLine($"Площадь треугольника = {Math.Round(pipio.Area(a,d,c),4)}");                             
                Console.WriteLine($"Площадь внутренней окружности = {Math.Round(pipio.Area_of_inner_circle(a,d,c),4)}");
            }
            else
            {
                Console.WriteLine("были введены некорретные данные");
            }
            Console.ReadKey();
        }      
    }
}
