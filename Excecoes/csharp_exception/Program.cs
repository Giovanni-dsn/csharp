using csharp_exception.Titular;
using csharp_exception.Contas;
using ByteBank;
LeitorDeArquivo leitor = new LeitorDeArquivo("documento.txt");

try
{
    leitor.LerProximaLinha();
}
catch (IOException ex)
{
    Console.WriteLine("[ERRO] Leitura Interrompida.");
}
finally
{
    leitor.Dispose();
}
/*
try
{
    ContaCorrente conta1 = new ContaCorrente(123, "1234-X");
    Console.WriteLine(conta1.GetSaldo());
    conta1.Sacar(150);
    Console.WriteLine(conta1.GetSaldo());
}
catch(ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.Message);
    
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
}
*/
