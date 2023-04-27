using ByteBankIO;
using System.ComponentModel.Design;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente(string diretorio)
    {
        var arquivo = diretorio;
        var totalBytesLidos = -1;
        using (var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open))
        {
            var buffer = new byte[1024]; //1KB
            while (totalBytesLidos != 0)
            {
                totalBytesLidos = fluxoDoArquivo.Read(buffer, 0, buffer.Length);
                EscreverBuffer(buffer, totalBytesLidos);
                Console.WriteLine("Número de bytes lidos: " + totalBytesLidos);
            }
            fluxoDoArquivo.Close();
            Console.ReadLine();
        }
    }

    static void EscreverBuffer(byte[] buffer, int _bytesLidos)
    {
        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, _bytesLidos);
        Console.Write(texto);
        //foreach (var meuByte in buffer)
        //{
        //    Console.Write(meuByte);
        //    Console.Write(" ");
        //}
    }

    static void LerComStreamReaderEadicionarContaCorrente(string diretorio)
    {
        var enderecoDoArquivo = diretorio;

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine();

            //var texto = leitor.ReadToEnd();
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();

                var conta = ConverterStringParaContaCorrente(linha);
                EscreverConta(conta);
            }
            //Console.WriteLine(texto);
        }
        Console.ReadLine();
    }

    static void EscreverConta(ContaCorrente conta1)
    {
        Console.WriteLine("Nome: " + conta1.Titular.Nome);
        Console.WriteLine("Saldo: R$" + conta1.Saldo);
        Console.WriteLine("Agência: " + conta1.Agencia);
        Console.WriteLine("Número da conta: " + conta1.Numero);
        Console.WriteLine("--------------------------");
    }

    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        // 375 4644 2483.13 Jonatan
        var arrayConta = linha.Split(",");
        var agencia = int.Parse(arrayConta[0]);
        var numeroConta = int.Parse(arrayConta[1]);
        var _saldo = double.Parse(arrayConta[2].Replace(".", ","));
        Cliente titular = new Cliente();
        titular.Nome = arrayConta[3];
        var resultado = new ContaCorrente(agencia, numeroConta);
        resultado.Depositar(_saldo);
        resultado.Titular = titular;

        return resultado;
    }
}
