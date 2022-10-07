using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int Horas, VelocidadeM, KML;
            double ConsumeM;

            KML = 12;
            Horas = int.Parse(Console.ReadLine());
            VelocidadeM = int.Parse(Console.ReadLine());
            
            ConsumeM = VelocidadeM * Horas;
            double TOTAL  = ConsumeM / KML ;

            Console.WriteLine(TOTAL.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}