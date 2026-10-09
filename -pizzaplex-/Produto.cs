
using System;
using System.Collections.Generic;
using _pizzaplex_;

Estoque pizza1 = new Estoque();

pizza1.Id = 1;
pizza1.Nome = "Pizza Calabresa";
pizza1.Preco = 40.00m;
pizza1.QuantidadeEmEstoque = 10;

Estoque pizza2 = new Estoque();

pizza2.Id = 2;
pizza2.Nome = "Pizza Frango";
pizza2.Preco = 42.00m;
pizza2.QuantidadeEmEstoque = 5;

List<Estoque> estoque = new List<Estoque>();

estoque.Add(pizza1);
estoque.Add(pizza2);

foreach (Estoque pizza in estoque)
{
    Console.WriteLine("ID: " + pizza.Id);
    Console.WriteLine("Nome: " + pizza.Nome);
    Console.WriteLine("Preço: R$ " + pizza.Preco);
    Console.WriteLine(
        "Quantidade: " + pizza.QuantidadeEmEstoque);

    Console.WriteLine("---------------------");
}