using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            double A;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double B;
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double VALORA = A * 0.31818181818182;
            double VALORB = B * 0.68181818181818;
            double SOMA = VALORA + VALORB;

            Console.WriteLine("MEDIA = " + SOMA.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}