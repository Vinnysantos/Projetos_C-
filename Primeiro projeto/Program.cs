using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            string nome;

            Console.Write("Digite seu nome completo: ");
            nome = Console.ReadLine();

            int quartos;
            Console.Write("quantos quartos tem na sua casa? : ");
            quartos = int.Parse(Console.ReadLine());

            double n2;

            Console.Write("Quantos custa um PS5?  ");
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com seu ultimo nome, idade e altura: ");

            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            int idade = int.Parse(vet[1], CultureInfo.InvariantCulture);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}