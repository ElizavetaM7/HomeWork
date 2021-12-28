using System;

namespace ВыделениеМетода
{
    class Program
    {
        static void Main()
        {
            double z = Math.Tan(2);
            double y = Math.Tan(3);
            double w = Math.Tan(5);
            double x = Math.Sqrt((1 + z * z) / 3) +
                       Math.Sqrt((5 + y * y) / 8) +
                       Math.Sqrt((1 + w * w) / 6);
            Console.WriteLine("x={0}", Math.Round(x,3));


        }
    }
}
