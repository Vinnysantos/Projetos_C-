using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet0;

            vet0 = new double[2];

            string[] s0 = Console.ReadLine().Split(' ');

            double[] vet1;

            vet1 = new double[2];

            string[] s1 = Console.ReadLine().Split(' ');

            double Soma = vet0[1];
            Console.WriteLine(" VALOR A PAGAR: R$ " + Soma.ToString("F2", CultureInfo.InvariantCulture));

            // Console.WriteLine("NUMBER = " + Numero);
            // Console.WriteLine("SALARY = U$ " + ValorSalario.ToString("F2", CultureInfo.InvariantCulture));
            //  Console.ReadLine();
        }
    }
}