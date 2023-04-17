using System;

class Programa
{
    static void Main(string[] args)
    {
        for (int numero = 1;  numero <= 10 ; numero++)
        {
            if (numero % 3 == 0)
            {
                Console.WriteLine(numero + "... ");
            }
        }
        Console.WriteLine("--------- Cálculo de Fatoriais de 1 a 10 ------");
        for (int num = 1; num <= 10 ; num++)
        {
            int fatorial = 1;
            for (int c = num; c >= 1; c--)
            {
                fatorial *= c;
            }
            Console.WriteLine("O fatorial de " + num + " é " + fatorial);
        }
    }
}