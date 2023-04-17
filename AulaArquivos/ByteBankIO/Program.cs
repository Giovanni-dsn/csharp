using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var arquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open);
        var buffer = new byte[1024]; //1KB
        fluxoDoArquivo.Read(buffer, 0, buffer.Length);
        Console.ReadLine();
    }
}