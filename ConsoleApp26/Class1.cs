using System;

namespace ConsoleApp26
{
    public class Class1 
    {
        public int Perimeter(int a, int d, int c) => a + d + c;

        public double Area(int a, int d, int c)
        {
            var P = (a + d + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - d) * (P - c));
            return S;
        }

        public double Area_of_inner_circle(int a, int d, int c)
        {
            var P = (a + d + c) / 2;
            double S = Math.Sqrt(P * (P - a) * (P - d) * (P - c)); ;
            double R = S / P;
            double area_of_inner_circle = 3.14 * Math.Pow(R, 2);
            return area_of_inner_circle;
        }

        public int Check(int a, int d, int c)
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
