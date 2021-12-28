using System;

namespace ВыделениеМетода
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine(Math.Round(value: x= Metod, digits: 3));
            Console.ReadKey();
        }
        static double Metod
        {
            get
            {
                double x;
                double z = Math.Tan(2);
                double y = Math.Tan(3);
                double w = Math.Tan(5);
                return x = Math.Sqrt((1 + z * z) / 3) +
                               Math.Sqrt((5 + y * y) / 8) +
                               Math.Sqrt((1 + w * w) / 6);
            }
        }
    }
}
