using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            double R;

            Console.WriteLine();
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Volume1 = (4.0 / 3.0) * 3.14159;
            double Volume2 = Volume1 * (Math.Pow(R, 3.0));
            Console.WriteLine("VOLUME = " + Volume2.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}