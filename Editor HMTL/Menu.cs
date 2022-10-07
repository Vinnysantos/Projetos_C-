﻿using System;

namespace EditorHTML
{

    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            //DrawScreen();
            MargemCima();
            MargemLaterais();
            WriteOptions();
            var option = char.Parse(Console.ReadLine());
                                    
            Margembaixo();

 
        }

        public static void DrawScreen()
        {
            
           // Console.Write("+");
            //for (int i = 0; i <= 30; i++) ;
            
           //     Console.Write("-");
            

            //Console.Write("+");
           // Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++) ;

            Console.Write("-");


            Console.Write("+");
            Console.Write("\n");

        }

        public static void MargemCima()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            

            Console.Write("+");
            Console.Write("\n");
        }

        public static void MargemLaterais()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void Margembaixo()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)

            Console.Write("-");


            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");

        }

        public static void NovoArquivo()
        {

        }

        public static void Abrir()
        {

        }

        public static void Sair()
        {
            
        }

    }
}





