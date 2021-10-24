using System;

namespace _2.Вычисление_заданных_величин_Прямоугольник
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToInt32(Console.ReadLine());

            double S = a * b;
            Console.WriteLine("S={0} ", Convert.ToString(S));

            double P = 2*(a+b);
            Console.WriteLine("P={0} ", Convert.ToString(P));

            double d = Math.Sqrt(a*a+b*b);
            Console.WriteLine("d={0} ", Convert.ToString(d));

            Console.ReadKey();
        }
    }
}
