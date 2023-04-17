using ExerciciosDeClasse.ContaBancaria;
using ExerciciosDeClasse.Pessoa;
using ExerciciosDeClasse.Retangulo;

Pessoa pessoa = new Pessoa();
pessoa.Nome = "João Silva";
pessoa.Idade = 28;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Santos";
pedro.Idade = 29;
pedro.Salario = 3553;

Console.WriteLine("A primeira pessoa tem as informações: ");
pessoa.GetPessoa();

Console.WriteLine("O primeiro funcionário tem as informações: ");
pedro.GetPessoa();

Console.WriteLine();
Retangulo retangulo = new Retangulo();
retangulo.Altura = 3.5;
retangulo.Largura = 9.4;
Console.WriteLine("A área do triangulo é: " + retangulo.GetArea() + "m²");

Console.WriteLine();
ContaCorrente conta = new ContaCorrente();
conta.Saldo = 1500;
conta.NumeroConta = 015;
conta.Depositar(300);
conta.Sacar(300);
conta.Depositar(800);
