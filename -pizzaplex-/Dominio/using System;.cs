

using System;
using System.Collections.Generic;
using System.Text;

namespace _pizzaplex_.Dominio
{
    internal class pedidos
    {
        public int Numero { get; set; }
        public string Pizza { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }

    }
}
namespace _pizzaplex_.Dominio
{
    internal class ListaPedidos
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
    }
}