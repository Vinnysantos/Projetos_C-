using System;
using System.Globalization;

namespace curso { 
    class Program {
        static void Main(string[] args) {
            int N, X, soma;

            N = int.Parse(Console.ReadLine());

            soma = 0;
            for (int i=1; i<=N; i++) { 
                X = int.Parse(Console.ReadLine());
                soma += X;
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}