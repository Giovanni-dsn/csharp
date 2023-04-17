
using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("---------Investimento 5 anos----------");
        double fator = 1.005;
        double investimento = 3000;
        double inicial = investimento;
        for (int anos = 1; anos < 6; anos++) // O "for" inicia o contador, faz o teste lógico no início e já faz o incremento.
        {
            fator += 0.001;
            for (int mes = 12;mes <= 12;mes++)
            {
                investimento *= fator;
            }
        }
        Console.WriteLine("O investimento ao longo de 5 anos foi de R$" + inicial + " para R$" + investimento);
        Console.WriteLine("Tecle enter para finalizar ...");
    }
}

