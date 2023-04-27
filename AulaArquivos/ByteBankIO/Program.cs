using ByteBankIO;
using System.ComponentModel.Design;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        //CriarArquivo("contasExportadas.csv");
        //CriarArquivoComWriter("contasExportadas2.csv");
        //LerComStreamReaderEadicionarContaCorrente("contasExportadas.csv");
        //TestaEscrita();
        //EscritaBinaria();
        //LeituraBinaria();
        UsarStreamDeEntrada();
        Console.WriteLine("Aplicação finalizada");
        Console.ReadLine();
    }
}