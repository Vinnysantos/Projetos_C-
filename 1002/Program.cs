﻿//A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:

//-Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

//Entrada
//A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.

//Saída
//Apresentar a mensagem "A=" seguido pelo valor da variável area, conforme exemplo abaixo, com 4 casas após o ponto decimal. Utilize variáveis de dupla precisão (double). Como todos os problemas, 
//não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

//

using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = 3.14159, R;
                       
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double A = N * Math.Pow(R, 2.0);
            Console.WriteLine("A="+A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}