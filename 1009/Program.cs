using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome = Console.ReadLine();

            double Salario, Vendas, TOTAL, Comissao;

            Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Comissao = (Vendas / 100) * 15;
            TOTAL = Salario + Comissao;
                        
            Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
