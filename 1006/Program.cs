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

            double C;
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double VALORA = A * 0.20;
            double VALORB = B * 0.30;
            double VALORC = C * 0.50;
            double SOMA = VALORA + VALORB + VALORC;


            Console.WriteLine("MEDIA = " + SOMA.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}