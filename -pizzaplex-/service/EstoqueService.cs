using _pizzaplex_.Dominio;

namespace _pizzaplex_.service
{
    public static class EstoqueService
    {
        public static List<Estoque> Estoques { get; set; } = new List<Estoque>()
            {
                new Estoque() { Id = 1, Nome = "Pizza Calabresa", Preco = 40.00m, QuantidadeEmEstoque = 10 },
                new Estoque() { Id = 2, Nome = "Pizza Frango", Preco = 42.00m, QuantidadeEmEstoque = 5 },
                new Estoque() { Id = 3, Nome = "Hambúrguer", Preco = 25.00m, QuantidadeEmEstoque = 15 },
                new Estoque() { Id = 4, Nome = "Batata Frita", Preco = 18.00m, QuantidadeEmEstoque = 20 },
                new Estoque() { Id = 5, Nome = "Refrigerante", Preco = 8.00m, QuantidadeEmEstoque = 30 }
            };

        public static void Remover(int id)
        {
            Estoque produto = Estoques.Find(item => item.Id == id);

            if (produto != null)
            {
                Estoques.Remove(produto);
                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o produto.");
            }
        }

        public static void Editar(int id, string novoNome, decimal novoPreco, int novaQuantidade)
        {
            Estoque produto = Estoques.Find(item => item.Id == id);

            if (produto != null)
            {
                produto.Nome = novoNome;
                produto.Preco = novoPreco;
                produto.QuantidadeEmEstoque = novaQuantidade;

                Listar();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o produto.");
            }
        }

        public static void Adicionar(string nome, decimal preco, int quantidade)
        {
            Estoque produto = new Estoque();

            produto.Id = Estoques.Count > 0
                ? Estoques.Max(item => item.Id) + 1
                : 1;

            produto.Nome = nome;
            produto.Preco = preco;
            produto.QuantidadeEmEstoque = quantidade;

            Estoques.Add(produto);
        }

        public static void Listar()
        {
            foreach (Estoque item in Estoques)
            {
                Console.WriteLine("ID: " + item.Id);
                Console.WriteLine("Nome: " + item.Nome);
                Console.WriteLine("Preço: R$ " + item.Preco);
                Console.WriteLine("Quantidade em estoque: " + item.QuantidadeEmEstoque);
                Console.WriteLine("---------------------");
            }
        }

        public static void BuscarPorId(int id)
        {
            Estoque produto = Estoques.Find(item => item.Id == id);

            if (produto != null)
            {
                Console.WriteLine("ID: " + produto.Id);
                Console.WriteLine("Nome: " + produto.Nome);
                Console.WriteLine("Preço: R$ " + produto.Preco);
                Console.WriteLine("Quantidade em estoque: " + produto.QuantidadeEmEstoque);
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o produto.");
            }
        }
    }
}


