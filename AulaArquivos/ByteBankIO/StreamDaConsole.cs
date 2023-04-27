using ByteBankIO;
using System.Text;

partial class Program
{
    static void UsarStreamDeEntrada()
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        {
            var buffer = new byte[1024]; // 1kb
            var bytesLidos = fluxoDeEntrada.Read(buffer, 0, buffer.Length);
            Console.WriteLine($"Bytes lidos na console: {bytesLidos}");
        }
    }
}