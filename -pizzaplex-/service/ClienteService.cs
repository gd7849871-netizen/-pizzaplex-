using _pizzaplex.Dominio;
using _pizzaplex_.Dominio;
using System;
using System.Collections.Generic;

namespace _pizzaplex.Dominio
{
    public static class ClienteService
    {
        public static List<Cliente> clientes { get; set; } = new List<Cliente>();
        public static void AdicionarCliente(Cliente cliente)
        {
            Cliente clientess = Cadastrar();
            clientes.Add(clientess);
        }

        public static void ListarClientes()
        {
           
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
