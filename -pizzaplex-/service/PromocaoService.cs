using System;
using System.Collections.Generic;
using System.Text;
using _pizzaplex_.Dominio; 

namespace _pizzaplex_.service
{
    internal class PromocaoService
    {
        public static List<Promocao> promocoes { get; set; } = new List<Promocao>()
        {
            new Promocao() { Id = 1, Nome = "Terça em Dobro", Descricao = "Compre uma pizza e ganhe outra", Desconto = 0.0, DataInicio = DateTime.Now, DataFim = DateTime.Now, Status = "Em p" },
            new Promocao() { Id = 2, Nome = "Desconto de Inauguração", Descricao = "10% de desconto em todo o cardápio", Desconto = 10.0, DataInicio = DateTime.Now, DataFim = DateTime.Now, Status = "Pend" },
            new Promocao() { Id = 3, Nome = "Combo Família", Descricao = "2 Pizzas Grandes + 1 Refrigerante por preço especial", Desconto = 15.0, DataInicio = DateTime.Now, DataFim = DateTime.Now, Status = "Entr" },
            new Promocao() { Id = 4, Nome = "Black Friday", Descricao = "Metade do preço em qualquer pizza doce", Desconto = 50.0, DataInicio = DateTime.Now, DataFim = DateTime.Now, Status = "Stat" },
            new Promocao() { Id = 5, Nome = "Frete Grátis", Descricao = "Entrega gratuita para pedidos acima de R$ 80", Desconto = 0.0, DataInicio = DateTime.Now, DataFim = DateTime.Now, Status = "Pend" }
        };
    }
}
