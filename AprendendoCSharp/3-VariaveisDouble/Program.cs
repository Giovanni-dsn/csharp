using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("3 - Tipos Primitivos");
        Console.WriteLine("Aperte Enter para continuar");
        double sal = 300.13;
        // O tipo int recebe valores ate 32 bits
        int salinteiro = (int)sal;
        // O tipo long recebe valores até 64 bits
        long numlong = 200000000000000000;
        // O tipo short recebe valores até 16 bits
        short numshort = 20000;
        // O tipo float recebe valores com "," e "." no entanto tem que ser posto o "f" no final do valor.
        float numfloat = 1.62f;
        //O tipo char armazena valor do tipo string, mas apenas 1 caractere
        char letra = 'A';
        //O tipo string armazena caracteres/texto
        string frase = "Primeira frase";
        Console.WriteLine("Aperte Enter para fechar . . . ");
    }
}