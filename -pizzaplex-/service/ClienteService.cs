using _pizzaplex.Dominio;
using _pizzaplex_.Dominio;
using System;
using System.Collections.Generic;

namespace _pizzaplex.Dominio
{
    public static class ClienteService
    {
        public static List<Cliente> clientes { get; set; } = new List<Cliente>()
        {
            new Cliente(){ Id=1,Nome="Paulo",Email="paulo@gmail.com",Whatsapp="11999999999",Endereco="Rua A, 123" },
            new Cliente(){ Id=2,Nome="Ana",Email="paulo@gmail.com",Whatsapp="11999999999",Endereco="Rua B, 456" },
            new Cliente(){ Id=3,Nome="Raimundo",Email="paulo@gmail.com",Whatsapp="11999999999",Endereco="Rua C, 789" },
            new Cliente(){ Id=4,Nome="Fulano2",Email="paulo@gmail.com",Whatsapp="11999999999",Endereco="Rua D, 012" },
            new Cliente(){ Id=5,Nome="Fulano3",Email="paulo@gmail.com",Whatsapp="11999999999",Endereco="Rua E, 345"},
        };
        public static void AdicionarCliente(Cliente cliente)
        {
            Cliente clientess = Cadastrar();
            clientes.Add(clientess);

        }

        public static void ListarClientes()
        {

            foreach (Cliente item in clientes)
            {
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"E-mail: {item.Email}");
                Console.WriteLine($"WhatsApp: {item.Whatsapp}");
                Console.WriteLine($"Endereço: {item.Endereco}");
            }


        }

        public static void Remover(int id)
        {
            Cliente item = clientes.Find(Cliente => Cliente.Id == id);
            if (item != null)
            {
                clientes.Remove(item);
                ListarClientes();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            };
        }

        public static void Editar(int id, string novoNome, string novoEmail, string novoEndereco,string novoWhatsaap)      
        {
            Cliente item = clientes.Find(Cliente => Cliente.Id == id);
            if (item != null)
            {
                item.Nome = novoNome;
                item.Email = novoEmail;
                item.Endereco = novoEndereco;
                item.Whatsapp = novoWhatsaap;

                ListarClientes();
            }
            else
            {
                Console.WriteLine("Sistema não conseguiu encontrar o usuario");
            }
        }
        

        public static Cliente Cadastrar()
        {

            Console.WriteLine("cadastro cliente");

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
                Nome = nome,
                Email = email,
                Whatsapp = whatsapp,
                Endereco = endereco
            };

            
        }

    }
}
