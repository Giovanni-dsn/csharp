using Delivery.cliente;
using Delivery.pedidos;
using System;

string _nome, _cpf, _rua, _bairro, _cidade, _estado, _nomeitem, _tipoitem, _refriitem;
int _idade, _nmr_casa, _quant, _pesoitem;
var escolha = 0;
char _sexo;
bool refri;
Console.WriteLine("---------- SISTEMA DE DELIVERY ----------");
Console.WriteLine("Opções: ");
Console.WriteLine("[1] Cadastrar Cliente e Pedido");
Console.WriteLine("[2] Ver Exemplo");
Console.WriteLine("[3] Sair");
while (escolha > 3 || escolha < 1)
{
    Console.Write("Digite sua escolha: ");
    escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            {
                Console.WriteLine("-------------- CADASTRO DE CLIENTE --------------");
                Console.WriteLine("------ Dados Pessoais ------");
                Console.Write("Nome: ");
                _nome = Console.ReadLine();
                Console.Write("Idade: ");
                _idade = int.Parse(Console.ReadLine());
                Console.Write("CPF: ");
                _cpf = Console.ReadLine();
                Console.Write("Sexo [M/F]: ");
                _sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("------ Endereço ------"); 
                Console.Write("Rua: ");
                _rua = Console.ReadLine();
                Console.Write("Número da casa: ");
                _nmr_casa = int.Parse(Console.ReadLine());
                Console.Write("Bairro: ");
                _bairro = Console.ReadLine();
                Console.Write("Cidade: ");
                _cidade = Console.ReadLine();
                Console.Write("Estado: ");
                _estado = Console.ReadLine();

                Cliente cliente = new Cliente();    // CADASTRO DOS DADOS DO CLIENTE - PESSOAIS E ENDEREÇO DE ENTREGA
                cliente.nome = _nome;
                cliente.idade = _idade;
                cliente.cpf = _cpf;
                cliente.sexo = _sexo;
                cliente.localização = new Endereço();
                cliente.localização.rua = _rua;
                cliente.localização.bairro = _bairro;
                cliente.localização.cidade = _cidade;
                cliente.localização.estado = _estado;
                cliente.localização.nmr_casa = _nmr_casa;

                // FIM CADASTRO DADOS DO CLIENTE

                int quantpedidos;

                Console.WriteLine("------ Pedidos ------");
                bool loop = true;
                while (loop)
                {
                    Console.Write("Quantos itens deseja adicionar ao carrinho (Máx: 3) ? ");
                    quantpedidos = int.Parse(Console.ReadLine());
                    switch (quantpedidos)
                    {
                        case 1:
                            {
                                loop = false;
                                Console.Write("Nome do pedido: ");
                                _nomeitem = Console.ReadLine();
                                Console.Write("Quantidade: ");
                                _quant = int.Parse(Console.ReadLine());
                                Console.Write("Peso: ");
                                _pesoitem = int.Parse(Console.ReadLine());
                                Console.Write("Tipo: ");
                                _tipoitem = Console.ReadLine();
                                Console.Write("Acompanha Refri [S/N] ?");
                                _refriitem = Console.ReadLine();
                                if (_refriitem == "S")
                                {
                                    refri = true;
                                }
                                else
                                {
                                    refri = false;
                                }

                                Pedido pedido = new Pedido();
                                pedido.item1 = new Item();
                                pedido.item1.nome = _nomeitem;
                                pedido.item1.quant = _quant;
                                pedido.item1.peso = _pesoitem;
                                pedido.item1.tipo = _tipoitem;
                                pedido.item1.acompanhaRefri = refri;

                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("--------- PEDIDO COMPLETO ---------");
                                Console.WriteLine("---- CLIENTE ----");
                                Console.WriteLine("Nome: " + cliente.nome);
                                Console.WriteLine("Idade: " + cliente.idade);
                                Console.WriteLine("CPF: " + cliente.cpf);
                                Console.WriteLine("Sexo: " + cliente.sexo);
                                Console.WriteLine("Rua: " + cliente.localização.rua);
                                Console.WriteLine("Bairro: " + cliente.localização.bairro);
                                Console.WriteLine("Cidade: " + cliente.localização.cidade);
                                Console.WriteLine("Estado: " + cliente.localização.estado);
                                Console.WriteLine("Número da casa: " + cliente.localização.nmr_casa);
                                Console.WriteLine("---- CARINHO ----");
                                Console.WriteLine();
                                Console.WriteLine("Pedido 1: ");
                                Console.WriteLine("Nome: " + pedido.item1.nome);
                                Console.WriteLine("Quantidade: " + pedido.item1.quant);
                                Console.WriteLine("Peso: " + pedido.item1.peso);
                                Console.WriteLine("Tipo: " + pedido.item1.tipo);
                                Console.WriteLine("Acompanha Refri: " + pedido.item1.acompanhaRefri);

                                break;
                            }
                        case 2:
                            {
                                loop = false;
                                // COMEÇO PEDIDO 1

                                Console.WriteLine("---- PEDIDO 1 ----");
                                Console.Write("Nome do pedido: ");
                                _nomeitem = Console.ReadLine();
                                Console.Write("Quantidade: ");
                                _quant = int.Parse(Console.ReadLine());
                                Console.Write("Peso: ");
                                _pesoitem = int.Parse(Console.ReadLine());
                                Console.Write("Tipo: ");
                                _tipoitem = Console.ReadLine();
                                Console.Write("Acompanha Refri [S/N] ?");
                                _refriitem = Console.ReadLine();
                                if (_refriitem == "S")
                                {
                                    refri = true;
                                }
                                else
                                {
                                    refri = false;
                                }

                                Pedido pedido = new Pedido();
                                pedido.item1 = new Item();
                                pedido.item1.nome = _nomeitem;
                                pedido.item1.quant = _quant;
                                pedido.item1.peso = _pesoitem;
                                pedido.item1.tipo = _tipoitem;
                                pedido.item1.acompanhaRefri = refri;
                                
                                Console.WriteLine();

                                //PEDIDO 2

                                Console.WriteLine("--- PEDIDO 2 ----");
                                Console.Write("Nome do pedido: ");
                                _nomeitem = Console.ReadLine();
                                Console.Write("Quantidade: ");
                                _quant = int.Parse(Console.ReadLine());
                                Console.Write("Peso: ");
                                _pesoitem = int.Parse(Console.ReadLine());
                                Console.Write("Tipo: ");
                                _tipoitem = Console.ReadLine();
                                Console.Write("Acompanha Refri [S/N] ?");
                                _refriitem = Console.ReadLine();
                                if (_refriitem == "S")
                                {
                                    refri = true;
                                }
                                else
                                {
                                    refri = false;
                                }

                                pedido.item2 = new Item();
                                pedido.item2.nome = _nomeitem;
                                pedido.item2.quant = _quant;
                                pedido.item2.peso = _pesoitem;
                                pedido.item2.tipo = _tipoitem;
                                pedido.item2.acompanhaRefri = refri;

                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("--------- PEDIDO COMPLETO ---------");
                                Console.WriteLine("---- CLIENTE ----");
                                Console.WriteLine("Nome: " + cliente.nome);
                                Console.WriteLine("Idade: " + cliente.idade);
                                Console.WriteLine("CPF: " + cliente.cpf);
                                Console.WriteLine("Sexo: " + cliente.sexo);
                                Console.WriteLine("Rua: " + cliente.localização.rua);
                                Console.WriteLine("Bairro: " + cliente.localização.bairro);
                                Console.WriteLine("Cidade: " + cliente.localização.cidade);
                                Console.WriteLine("Estado: " + cliente.localização.estado);
                                Console.WriteLine("Número da casa: " + cliente.localização.nmr_casa);
                                Console.WriteLine("---- CARINHO ----");
                                Console.WriteLine();
                                Console.WriteLine("Pedido 1: ");
                                Console.WriteLine("Nome: " + pedido.item1.nome);
                                Console.WriteLine("Quantidade: " + pedido.item1.quant);
                                Console.WriteLine("Peso: " + pedido.item1.peso);
                                Console.WriteLine("Tipo: " + pedido.item1.tipo);
                                Console.WriteLine("Acompanha Refri: " + pedido.item1.acompanhaRefri);
                                Console.WriteLine();
                                Console.WriteLine("Pedido 2: ");
                                Console.WriteLine("Nome: " + pedido.item2.nome);
                                Console.WriteLine("Quantidade: " + pedido.item2.quant);
                                Console.WriteLine("Peso: " + pedido.item2.peso);
                                Console.WriteLine("Tipo: " + pedido.item2.tipo);
                                Console.WriteLine("Acompanha Refri: " + pedido.item2.acompanhaRefri);

                                break;
                            }
                        case 3:
                            {
                                loop = false;
                                //PEDIDO 1
                                Console.WriteLine("---- Pedido 1 ----");
                                Console.Write("Nome do pedido: ");
                                _nomeitem = Console.ReadLine();
                                Console.Write("Quantidade: ");
                                _quant = int.Parse(Console.ReadLine());
                                Console.Write("Peso: ");
                                _pesoitem = int.Parse(Console.ReadLine());
                                Console.Write("Tipo: ");
                                _tipoitem = Console.ReadLine();
                                Console.Write("Acompanha Refri [S/N] ?");
                                _refriitem = Console.ReadLine();
                                if (_refriitem == "S")
                                {
                                    refri = true;
                                }
                                else
                                {
                                    refri = false;
                                }

                                Pedido pedido = new Pedido();
                                pedido.item1 = new Item();
                                pedido.item1.nome = _nomeitem;
                                pedido.item1.quant = _quant;
                                pedido.item1.peso = _pesoitem;
                                pedido.item1.tipo = _tipoitem;
                                pedido.item1.acompanhaRefri = refri;
                                Console.WriteLine();

                                // PEDIDO 2

                                Console.WriteLine("---- Pedido 2 ----");
                                Console.Write("Nome do pedido: ");
                                _nomeitem = Console.ReadLine();
                                Console.Write("Quantidade: ");
                                _quant = int.Parse(Console.ReadLine());
                                Console.Write("Peso: ");
                                _pesoitem = int.Parse(Console.ReadLine());
                                Console.Write("Tipo: ");
                                _tipoitem = Console.ReadLine();
                                Console.Write("Acompanha Refri [S/N] ?");
                                _refriitem = Console.ReadLine();
                                if (_refriitem == "S")
                                {
                                    refri = true;
                                }
                                else
                                {
                                    refri = false;
                                }

                                pedido.item2 = new Item();
                                pedido.item2.nome = _nomeitem;
                                pedido.item2.quant = _quant;
                                pedido.item2.peso = _pesoitem;
                                pedido.item2.tipo = _tipoitem;
                                pedido.item2.acompanhaRefri = refri;
                                Console.WriteLine();

                                // PEDIDO 3

                                Console.WriteLine("---- Pedido 3 ----");
                                Console.Write("Nome do pedido: ");
                                _nomeitem = Console.ReadLine();
                                Console.Write("Quantidade: ");
                                _quant = int.Parse(Console.ReadLine());
                                Console.Write("Peso: ");
                                _pesoitem = int.Parse(Console.ReadLine());
                                Console.Write("Tipo: ");
                                _tipoitem = Console.ReadLine();
                                Console.Write("Acompanha Refri [S/N] ?");
                                _refriitem = Console.ReadLine();
                                if (_refriitem == "S")
                                {
                                    refri = true;
                                }
                                else
                                {
                                    refri = false;
                                }

                                pedido.item3 = new Item();
                                pedido.item3.nome = _nomeitem;
                                pedido.item3.quant = _quant;
                                pedido.item3.peso = _pesoitem;
                                pedido.item3.tipo = _tipoitem;
                                pedido.item3.acompanhaRefri = refri;

                                Console.WriteLine();
                                Console.WriteLine("--------- PEDIDO COMPLETO ---------");
                                Console.WriteLine("---- CLIENTE ----");
                                Console.WriteLine("Nome: " + cliente.nome);
                                Console.WriteLine("Idade: " + cliente.idade);
                                Console.WriteLine("CPF: " + cliente.cpf);
                                Console.WriteLine("Sexo: " + cliente.sexo);
                                Console.WriteLine("Rua: " + cliente.localização.rua);
                                Console.WriteLine("Bairro: " + cliente.localização.bairro);
                                Console.WriteLine("Cidade: " + cliente.localização.cidade);
                                Console.WriteLine("Estado: " + cliente.localização.estado);
                                Console.WriteLine("Número da casa: " + cliente.localização.nmr_casa);
                                Console.WriteLine("---- CARINHO ----");
                                Console.WriteLine();
                                Console.WriteLine("Pedido 1: ");
                                Console.WriteLine("Nome: " + pedido.item1.nome);
                                Console.WriteLine("Quantidade: " + pedido.item1.quant);
                                Console.WriteLine("Peso: " + pedido.item1.peso);
                                Console.WriteLine("Tipo: " + pedido.item1.tipo);
                                Console.WriteLine("Acompanha Refri: " + pedido.item1.acompanhaRefri);
                                Console.WriteLine();
                                Console.WriteLine("Pedido 2: ");
                                Console.WriteLine("Nome: " + pedido.item2.nome);
                                Console.WriteLine("Quantidade: " + pedido.item2.quant);
                                Console.WriteLine("Peso: " + pedido.item2.peso);
                                Console.WriteLine("Tipo: " + pedido.item2.tipo);
                                Console.WriteLine("Acompanha Refri: " + pedido.item2.acompanhaRefri);
                                Console.WriteLine();
                                Console.WriteLine("Pedido 3: ");
                                Console.WriteLine("Nome: " + pedido.item3.nome);
                                Console.WriteLine("Quantidade: " + pedido.item3.quant);
                                Console.WriteLine("Peso: " + pedido.item3.peso);
                                Console.WriteLine("Tipo: " + pedido.item3.tipo);
                                Console.WriteLine("Acompanha Refri: " + pedido.item3.acompanhaRefri);


                                break;
                            }
                        default: {
                                Console.WriteLine("Número inválido ! Tente novamente.");
                                break;
                            }
                    }
                }
             
                break;
            }
        case 2:
            {
                Solicitação Soc = new Solicitação();
                Soc.pedido = new Pedido();
                Soc.pessoa = new Cliente();
                Soc.loja = "Seu Zé Lanches";
                Soc.pessoa.localização = new Endereço();
                Soc.pedido.item1 = new Item();
                Soc.pedido.item2 = new Item();
                Soc.pedido.item3 = new Item();

                Soc.pessoa.nome = "Fulano de Tal";
                Soc.pessoa.idade = 23;
                Soc.pessoa.cpf = "123.456.789-10";
                Soc.pessoa.sexo = 'M';

                Soc.pessoa.localização.rua = "Rua Exemplo";
                Soc.pessoa.localização.bairro = "Bairro Exemplo";
                Soc.pessoa.localização.cidade = "Cidade Exemplo";
                Soc.pessoa.localização.estado = "Estado Exemplo";
                Soc.pessoa.localização.nmr_casa = 123;

                Soc.pedido.item1.nome = "Nome Lanche 1";
                Soc.pedido.item1.quant = 1;
                Soc.pedido.item1.peso = 100;
                Soc.pedido.item1.tipo = "Comida Japonesa";
                Soc.pedido.item1.acompanhaRefri = true;

                Soc.pedido.item2.nome = "Nome Lanche 2";
                Soc.pedido.item2.quant = 2;
                Soc.pedido.item2.peso = 200;
                Soc.pedido.item2.tipo = "Comida Japonesa";
                Soc.pedido.item2.acompanhaRefri = false;

                Soc.pedido.item3.nome = "Nome Lanche 3";
                Soc.pedido.item3.quant = 3;
                Soc.pedido.item3.peso = 300;
                Soc.pedido.item3.tipo = "Comida Japonesa";
                Soc.pedido.item3.acompanhaRefri = true;

                Console.WriteLine();
                Console.WriteLine("--------- PEDIDO COMPLETO ---------");
                Console.WriteLine("---- CLIENTE ----");
                Console.WriteLine("Nome: " + Soc.pessoa.nome);
                Console.WriteLine("Idade: " + Soc.pessoa.idade);
                Console.WriteLine("CPF: " + Soc.pessoa.cpf);
                Console.WriteLine("Sexo: " + Soc.pessoa.sexo);
                Console.WriteLine("Rua: " + Soc.pessoa.localização.rua);
                Console.WriteLine("Bairro: " + Soc.pessoa.localização.bairro);
                Console.WriteLine("Cidade: " + Soc.pessoa.localização.cidade);
                Console.WriteLine("Estado: " + Soc.pessoa.localização.estado);
                Console.WriteLine("Número da casa: " + Soc.pessoa.localização.nmr_casa);
                Console.WriteLine("---- CARINHO ----");
                Console.WriteLine();
                Console.WriteLine("Pedido 1: ");
                Console.WriteLine("Nome: " + Soc.pedido.item1.nome);
                Console.WriteLine("Quantidade: " + Soc.pedido.item1.quant);
                Console.WriteLine("Peso: " + Soc.pedido.item1.peso);
                Console.WriteLine("Tipo: " + Soc.pedido.item1.tipo);
                Console.WriteLine("Acompanha Refri: " + Soc.pedido.item1.acompanhaRefri);
                Console.WriteLine();
                Console.WriteLine("Pedido 2: ");
                Console.WriteLine("Nome: " + Soc.pedido.item2.nome);
                Console.WriteLine("Quantidade: " + Soc.pedido.item2.quant);
                Console.WriteLine("Peso: " + Soc.pedido.item2.peso);
                Console.WriteLine("Tipo: " + Soc.pedido.item2.tipo);
                Console.WriteLine("Acompanha Refri: " + Soc.pedido.item2.acompanhaRefri);
                Console.WriteLine();
                Console.WriteLine("Pedido 3: ");
                Console.WriteLine("Nome: " + Soc.pedido.item3.nome);
                Console.WriteLine("Quantidade: " + Soc.pedido.item3.quant);
                Console.WriteLine("Peso: " + Soc.pedido.item3.peso);
                Console.WriteLine("Tipo: " + Soc.pedido.item3.tipo);
                Console.WriteLine("Acompanha Refri: " + Soc.pedido.item3.acompanhaRefri);
                break;
            }
        case 3:
            {
                break;
            }
        default:
            {
                Console.WriteLine("Por favor escolha uma opção válida ! ");
                break;
            }
    }
}
