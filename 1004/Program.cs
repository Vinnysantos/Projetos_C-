using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int A;
            A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int B;
            B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int SOMA = A * B;


            Console.WriteLine("PROD = " + SOMA);
        }
    }
}