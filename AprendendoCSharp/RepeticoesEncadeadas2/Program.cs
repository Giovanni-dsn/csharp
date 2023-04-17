using System;
using System.Reflection;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Asteriscos feito com 'for' para acompanhar o número de linhas.");
        for (int linhas = 0; linhas <= 10; linhas++) // for para Linhas
        {
            for (int colunas = 0; colunas < linhas; colunas++) // for para Colunas
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Tecle Enter para finalizar");
    }
}
