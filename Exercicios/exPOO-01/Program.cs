
using exPOO_01;

Produto GarrafaTermica = new Produto();
GarrafaTermica.nome = "Garrafa Térmica PRO Max 1L";
GarrafaTermica.fabricante = "Max Produtos";
GarrafaTermica.codbarra = 0100002040502255032;
GarrafaTermica.quantidade = 53;
GarrafaTermica.valunitario = 13.50;
GarrafaTermica.valcompra = 45.99;

double totalGasto = GarrafaTermica.valunitario * GarrafaTermica.quantidade;
double totalVenda = GarrafaTermica.valcompra * GarrafaTermica.quantidade;
double lucro = totalVenda - totalGasto;

Console.WriteLine("----- PRODUTO 01 -----");
Console.WriteLine("Nome: " + GarrafaTermica.nome);
Console.WriteLine("Fabricante: " + GarrafaTermica.fabricante);
Console.WriteLine("Código de Barra: " + GarrafaTermica.codbarra);
Console.WriteLine("Quantidade: " + GarrafaTermica.quantidade);
Console.WriteLine("Valor Unitário: " + GarrafaTermica.valunitario);
Console.WriteLine("Valor de Compra: " + GarrafaTermica.valcompra);
Console.WriteLine("O total gasto no estoque foi de R$" + totalGasto);
Console.WriteLine("O total de venda em 100% do estoque é de R$" + totalVenda);
Console.WriteLine("O lucro arrecadado é estimado em R$" + lucro);
