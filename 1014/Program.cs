using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double X;
            X = double.Parse(Console.ReadLine());

            double Y;
            Y = double.Parse(Console.ReadLine());

            double ConsumoMedio = X / Y;

            Console.WriteLine(ConsumoMedio.ToString("F3") + " km/l") ; 
        }
    }
}