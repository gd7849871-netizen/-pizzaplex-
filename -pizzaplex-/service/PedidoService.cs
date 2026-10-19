
using _pizzaplex_.Dominio;
using System;
using System.Collections.Generic;

namespace _pizzaplex_.service
{
    internal class PedidoService
    {
        public static List<pedidos> pedidos { get; set; }
            = new List<pedidos>()
            {
                new pedidos() { Numero = 1, Pizza = "Calabresa", Quantidade = 2, Total = 60.00, Data = DateTime.Now, Status = "Em preparo" },
                new pedidos() { Numero = 2, Pizza = "Mussarela", Quantidade = 1, Total = 30.00, Data = DateTime.Now, Status = "Pendente" },
                new pedidos() { Numero = 3, Pizza = "Portuguesa", Quantidade = 1, Total = 35.00, Data = DateTime.Now, Status = "Entregue" },
                new pedidos() { Numero = 4, Pizza = "Frango com catupiry", Quantidade = 2, Total = 70.00, Data = DateTime.Now, Status = "Em preparo" },
                new pedidos() { Numero = 5, Pizza = "Marguerita", Quantidade = 1, Total = 32.00, Data = DateTime.Now, Status = "Pendente" }
            };

        // Adicionar pedido
        public static void Adicionar(
            string pizza,
            int quantidade,
            double total,
            DateTime data,
            string status)
        {
            pedidos pedido = new pedidos();

            pedido.Numero = pedidos.Count > 0
                ? pedidos[pedidos.Count - 1].Numero + 1
                : 1;

            pedido.Pizza = pizza;
            pedido.Quantidade = quantidade;
            pedido.Total = total;
            pedido.Data = data;
            pedido.Status = status;

            pedidos.Add(pedido);
        }

        // Remover pedido
        public static void Remover(int numero)
        {
            pedidos pedido = pedidos.Find(
                p => p.Numero == numero
            );

            if (pedido != null)
            {
                pedidos.Remove(pedido);

                Console.WriteLine("Pedido removido com sucesso!");

                Listar();
            }
            else
            {
                Console.WriteLine(
                    "O sistema não conseguiu encontrar o pedido."
                );
            }
        }

        // Listar pedidos usando foreach
        public static void Listar()
        {
            foreach (pedidos pedido in pedidos)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Número: " + pedido.Numero);
                Console.WriteLine("Pizza: " + pedido.Pizza);
                Console.WriteLine("Quantidade: " + pedido.Quantidade);
                Console.WriteLine("Total: R$ " + pedido.Total.ToString("F2"));
                Console.WriteLine("Data: " + pedido.Data);
                Console.WriteLine("Status: " + pedido.Status);
            }

            Console.WriteLine("--------------------------");
        }
    }
}
