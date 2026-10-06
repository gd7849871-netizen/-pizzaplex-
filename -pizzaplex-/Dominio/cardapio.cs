using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _pizzaplex_
{
    public class Cardapio
    {
        public string Calabresa { get; set; }
        public string Frango { get; set; }
        public string Portuguesa { get; set; }
        public string Palmito { get; set; }

        public void Cadastrar()
        {
            Console.WriteLine("================================");
            Console.WriteLine("            CARDAPIO            ");
            Console.WriteLine("================================");

            Console.Write("Calabresa: ");
            Calabresa = Console.ReadLine();

            Console.Write("Frango: ");
            Frango = Console.ReadLine();

            Console.Write("Portuguesa: ");
            Portuguesa = Console.ReadLine();

            Console.Write("Palmito: ");
            Palmito = Console.ReadLine();
        }
    }
}