using _pizzaplex_.dominio;
using System;
using System.Collections.Generic;

namespace _pizzaplex_.Dominio
{
    public static class TabelaClientes
    {
        public static List<Cliente> clientes { get; set; } =  new List<Cliente>();
        public static void AdicionarCliente(Cliente cliente)
        {
            Cliente clientess = Cadastrar();
            clientes.Add(clientess);
        }

        public static void ListarClientes()
        {
            Console.WriteLine();
        }
        public static Cliente Cadastrar()
        {

            Console.WriteLine("------------cadastro cliente-------------");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("WhatsApp: ");
            string whatsapp = Console.ReadLine();

            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();

           return new Cliente()
           {
               nome = nome,
               email = email,
               whatsapp = whatsapp,
               endereco = endereco
           };
        }

    }
}
