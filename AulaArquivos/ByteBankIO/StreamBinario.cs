using ByteBankIO;
using System.Text;

partial class Program
{
    static void EscritaBinaria()
    {
        using (var fs = new FileStream("contaCorrenteBinaria.txt", FileMode.Create))
        {
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456); //número da Agência
                escritor.Write(546544); //número da conta
                escritor.Write(4000.50); //Saldo
                escritor.Write("Gustavo Braga");
            }
        }
    }
    
    static void LeituraBinaria()
    {
        using (var fs = new FileStream("contaCorrenteBinaria.txt", FileMode.Open))
        {
            using (var leitor = new BinaryReader(fs))
            {
                var _agencia = leitor.ReadInt32();
                var _numeroConta = leitor.ReadInt32();
                var _saldo = leitor.ReadDouble();
                var _nomeTitular = leitor.ReadString();

                ContaCorrente contaTeste = new ContaCorrente(_agencia, _numeroConta);
                contaTeste.Titular = new Cliente();
                contaTeste.Titular.Nome = _nomeTitular;
                contaTeste.Depositar(_saldo);
                EscreverConta(contaTeste);
            }
        }
    }
}