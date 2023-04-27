using ByteBankIO;
using System.Text;

partial class Program
{
    static void CriarArquivo(string diretorio)
    {
        var caminhoNovoArquivo = diretorio;

        using(var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaString = "456,7895,4785.40,Gustavo Santos\n444,1346,65643.32,Joao Silva Santos\n456,4365,53523.12,Maria Carvalho Santana";

            var enconding = Encoding.UTF8;

            var bytes = enconding.GetBytes(contaString);

            fluxoDoArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivoComWriter(string diretorio)
    {
        var caminhoNovoArquivo = diretorio;

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("456,65465,456.12,Pedro Alves");
            }
        }
        
    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                for (int i = 0; i < 100; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush(); //Despeja o buffer direto para o FileStream
                    Console.WriteLine($"Linha {i} escrita no arquivo, tecle enter.");
                    Console.ReadKey();
                }
            }
        }
    }
}