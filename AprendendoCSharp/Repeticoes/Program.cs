
using System;

class Programa
{
    static void Main(string[] args)
    {
        int num = 1;
        while (num <= 3) // Teste lógico no começo
        {
            Console.WriteLine(num);
            num++;
        }
        Console.WriteLine("---------");
        do // Teste lógico no final
        {
            num--;
            Console.WriteLine(num);
        } while (num > 1);
        Console.WriteLine("---------");
        for (int cont = 0; cont < 4; cont++) // O "for" inicia o contador, faz o teste lógico no início e já faz o incremento.
        {
            Console.WriteLine(cont + " ...");
        }
        Console.WriteLine("Tecle enter para finalizar ...");
    }
}

