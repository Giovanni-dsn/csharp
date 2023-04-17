Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//void TestaArray()
//{
//    double media = 0;
//    double somatorio = 0;
//    double[] notas = new double[5];
//    Console.WriteLine($"O tamanho do Array é {notas.Length}");
//    for (int i = 0; i < notas.Length; i++)
//    {
//        Console.Write($"{i + 1}° Nota = ");
//        notas[i] = double.Parse(Console.ReadLine());
//        somatorio += notas[i];
//        media = somatorio / notas.Length;
//    }
//    Console.WriteLine($"A média entre todas as notas foi de {media}");
//}

//TestaArray();

//Array amostra = Array.CreateInstance(typeof(double), 5);
//amostra.SetValue(1.1, 0);
//amostra.SetValue(5.7, 1);
//amostra.SetValue(0.3, 2);
//amostra.SetValue(9.9, 3);
//amostra.SetValue(3.4, 4);

//double[] numOrdenados = (double[])amostra.Clone();

//Array.Sort(numOrdenados);

//var tamanho = numOrdenados.Length;
//var meio = tamanho / 2;
//double mediana = (tamanho % 2 == 0) ? numOrdenados[meio] : (numOrdenados[meio] + numOrdenados[meio - 1]) / 2;

//foreach (var n in numOrdenados)
//{
//    Console.Write(n + ", ");
//}

//Console.WriteLine("A mediana dos valores é: " + mediana);

Array amostra = Array.CreateInstance(typeof(double), 4);
amostra.SetValue(3.4, 0);
amostra.SetValue(7.8, 1);
amostra.SetValue(5, 2);
amostra.SetValue(8.3, 3);

int[] num = {};

CalcularMedia(amostra);
void CalcularMedia(Array array)
{
    double somatorio = 0;
    if (array == null || array.Length == 0)
    {
        Console.WriteLine("Array vazio ou nulo para operação !");
    }
    else
    {
        foreach (double item in array)
        {
            somatorio += item;
        }
        double media = somatorio / array.Length;
        Console.WriteLine($"A média dos valores do array é: {media}");
    }
}