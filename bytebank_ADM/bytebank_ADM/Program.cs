using bytebank_ADM.Funcionários;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;
#region
//Funcionario pedro =  new Funcionario("123.456.789-10", 2000);
//pedro.Nome = "Pedro Tavares Silva";
//Console.WriteLine("O cpf de Pedro é: " + pedro.Cpf);
//Console.WriteLine("O salário atual de Pedro é: R$" + pedro.Salario);
//Console.WriteLine("O salário de Pedro após a bonificação é de: R$" + (pedro.Salario + pedro.Bonificar()));
//Console.WriteLine();


//Diretor paulo = new Diretor("109.876.543-21");
//paulo.Nome = "Paulo Tavares Silva";
//Console.WriteLine("O cpf de Paulo é: " + paulo.Cpf);
//Console.WriteLine("O salário atual de Paulo é: R$" + paulo.Salario);
//Console.WriteLine("O salário atual de Paulo pós-bonificação é de: R$" + (paulo.Salario + paulo.Bonificar()));


//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(paulo);
//Console.WriteLine("O total de bonificações é R$: " + gerenciador.TotalBonificacoes);
//Console.WriteLine("O total de funcionários cadastrados é " + Funcionario.Total);

//pedro.Aumento();
//paulo.Aumento();
//Console.WriteLine("O novo salário do Pedro é " + pedro.Salario);
//Console.WriteLine("O novo salário do Paulo é " + paulo.Salario);
#endregion

Auxiliar joao = new Auxiliar("123.456.789-10");
joao.Nome = "João Santos Silva";

Designer ana = new Designer("109.876.543-21");
ana.Nome = "Ana Barbosa de Carvalho";

Diretor alfredo = new Diretor("654.231.854-54");
alfredo.Nome = "Alfredo Oliveira de Santana";

GerenteDeContas maria = new GerenteDeContas("854.657.231-81");
maria.Nome = "Maria Clara Alves dos Santos";

CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    gerenciador.Registrar(joao);
    gerenciador.Registrar(ana);
    gerenciador.Registrar(alfredo);
    gerenciador.Registrar(maria);
    Console.WriteLine("O total de bonificação é: R$" + gerenciador.TotalBonificacoes);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor antony = new Diretor("1345");
    antony.Nome = "Antony Carvalho Santos";
    antony.Senha = "123";

    GerenteDeContas juliana = new GerenteDeContas("54321");
    juliana.Nome = "Juliana Anjos de Azevedo";
    juliana.Senha = "321";

    sistema.Logar(juliana, "123");
    sistema.Logar(antony, "123");


}