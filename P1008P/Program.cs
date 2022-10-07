using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero, Horas;
            double ValorHora, ValorSalario, SALARY;

            Numero = int.Parse(Console.ReadLine());
            Horas = int.Parse(Console.ReadLine());
            ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);       

            SALARY = (ValorHora * Horas) ;

            Console.WriteLine("NUMBER = " + Numero);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", CultureInfo.InvariantCulture));
                  
        }
    }
}