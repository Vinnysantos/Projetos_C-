using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("NUMBER = ");
            int Numero;
            Numero = int.Parse(Console.ReadLine());

            Console.Write("Hours work = ");
            int Horas;
            Horas = int.Parse(Console.ReadLine());

            Console.Write("Value Hour = ");
            double ValorHora;
            ValorHora = double.Parse(Console.ReadLine());
            
            double ValorSalario = ValorHora * Horas;    

            Console.WriteLine("NUMBER = " + Numero);
            Console.WriteLine("SALARY = U$ " + ValorSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}