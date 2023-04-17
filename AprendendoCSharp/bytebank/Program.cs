using bytebank.conta;
using bytebank.titular;

//ContaCorrente contaAndre = new ContaCorrente();
//contaAndre.titular = "André Silva";
//contaAndre.nmr_agencia = 15;
//contaAndre.conta = "1010-X";
//contaAndre.saldo = 100;

//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.titular = "Maria Silva";
//contaMaria.nmr_agencia = 17;
//contaMaria.conta = "1020-X";
//contaMaria.saldo = 150;

//Console.WriteLine("O saldo da conta de " + contaAndre.titular + " é R$" + contaAndre.saldo);
//Console.WriteLine("O saldo da conta de " + contaMaria.titular + " é R$" + contaMaria.saldo);

//contaAndre.Depositar(100);

//Console.WriteLine("O novo saldo na conta de " + contaAndre.titular + " pós-depósito é R$" + contaAndre.saldo);
//bool operacao = contaAndre.Saque(201);
//if (operacao)
//{
//    Console.WriteLine("O novo saldo na conta de " + contaAndre.titular + " pós-saque é R$" + contaAndre.saldo);
//}
//else
//{
//    Console.WriteLine("O saldo na conta de " + contaAndre.titular + " ainda é R$" + contaAndre.saldo);
//}
//double valTransferencia = 225;
//operacao = contaAndre.Transferir(valTransferencia, contaMaria);
//if (operacao)
//{
//    Console.WriteLine("Foi feita uma transferência de " + contaAndre.titular + " para " + contaMaria.titular + " no valor de R$" + valTransferencia);
//    Console.WriteLine("O novo saldo na conta de " + contaAndre.titular + " pós-transferência é R$" + contaAndre.saldo);
//    Console.WriteLine("O novo saldo na conta de " + contaMaria.titular + " pós-transferência é R$" + contaMaria.saldo);
//}
//else
//{
//    Console.WriteLine("Transferência de " + contaAndre.titular + " para " + contaMaria.titular + " no valor de R$" + valTransferencia + " CANCELADA!");
//    Console.WriteLine("O saldo na conta de " + contaAndre.titular + " ainda é R$" + contaAndre.saldo);
//    Console.WriteLine("O saldo na conta de " + contaMaria.titular + " ainda é R$" + contaMaria.saldo);
//}

Cliente fulano = new Cliente();
fulano.nome = "André Silva";
fulano.cpf = "123.456.789-10";

Cliente fulano2 = new Cliente();

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = fulano;
contaAndre.nmr_agencia = 15;
contaAndre.conta = "1010-X";
contaAndre.saldo = 100;

Console.WriteLine("Nome: " + contaAndre.titular.nome);
Console.WriteLine("CPF de " + contaAndre.titular.nome + ": " + contaAndre.titular.cpf);
Console.WriteLine("Agência: " + contaAndre.nmr_agencia);
Console.WriteLine("Conta: " + contaAndre.conta);
Console.WriteLine("Saldo: R$" + contaAndre.saldo);
Console.WriteLine("O total de clientes cadastrados atualmente é: " + Cliente.TotalClientes);

