using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _pizzaplex_
{
   public class cardapio
       
    {
        public string calabresa { get; set}
        public string  frango{ get; set }
        public string portuguesa { get; set}
        public string  palmito{ get; set}
    }
    public void Cadastrar()
        {
            Console.WriteLine("================================");
            Console.WriteLine("            CARDAPIO            ");
            Console.WriteLine("================================");

            Console.Write("calabresa: ");
            calabresa = Console.ReadLine();

            Console.Write("frango: ");
            frango = Console.ReadLine();

            Console.Write("portuguesa: ");
            portuguesa = Console.ReadLine();

            Console.Write("palmito: ");
           palmito = Console.ReadLine();

    
        }
    }

