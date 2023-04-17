
using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("4 - Condicionais em C# ");
        int idade = 16;
        int quant = 3;
        if (idade >= 18)
        {
            Console.WriteLine("Fulano tem 18 anos ou mais e passou na condição de maior");
        }
        else if (quant > 2)
        {
            Console.WriteLine("Fulano é menor mas está acompanhado, portanto passou na condição");
        }
        else
        {
            Console.WriteLine("Fulano é menor e não está acompanhado, portanto não passou na condição");
        }
        Console.WriteLine("Tecle enter para finalizar ...");
        Console.ReadLine();
    }
}
