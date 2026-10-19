
using _pizzaplex_.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _pizzaplex.Dominio
{
    public static class ClienteService
    {
        public static List<Cliente> clientes { get; set; } =
            new List<Cliente>()
            {
                new Cliente()
                {
                    Id = 1,
                    Nome = "Paulo",
                    Email = "paulo@gmail.com",
                    Whatsapp = "11999999999",
                    Endereco = "Rua A, 123"
                },
                new Cliente()
                {
                    Id = 2,
                    Nome = "Ana",
                    Email = "ana@gmail.com",
                    Whatsapp = "11988888888",
                    Endereco = "Rua B, 456"
                },
                new Cliente()
                {
                    Id = 3,
                    Nome = "Raimundo",
                    Email = "raimundo@gmail.com",
                    Whatsapp = "11977777777",
                    Endereco = "Rua C, 789"
                },
                new Cliente()
                {
                    Id = 4,
                    Nome = "Fulano2",
                    Email = "fulano2@gmail.com",
                    Whatsapp = "11966666666",
                    Endereco = "Rua D, 012"
                },
                new Cliente()
                {
                    Id = 5,
                    Nome = "Fulano3",
                    Email = "fulano3@gmail.com",
                    Whatsapp = "11955555555",
                    Endereco = "Rua E, 345"
                }
            };

        // CADASTRAR CLIENTE
        public static Cliente Cadastrar()
        {
            Console.WriteLine("\n=== CADASTRO DE CLIENTE ===");

            Console.Write("Nome: ");
            string nome = Console.ReadLine() ?? "";

            Console.Write("E-mail: ");
            string email = Console.ReadLine() ?? "";

            Console.Write("WhatsApp: ");
            string whatsapp = Console.ReadLine() ?? "";

            Console.Write("Endereço: ");
            string endereco = Console.ReadLine() ?? "";

            return new Cliente()
            {
                Nome = nome.Trim(),
                Email = email.Trim(),
                Whatsapp = whatsapp.Trim(),
                Endereco = endereco.Trim()
            };
        }

        // ADICIONAR CLIENTE
        public static void AdicionarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                Console.WriteLine("Cliente inválido!");
                return;
            }

            if (string.IsNullOrWhiteSpace(cliente.Nome) ||
                string.IsNullOrWhiteSpace(cliente.Email) ||
                string.IsNullOrWhiteSpace(cliente.Whatsapp) ||
                string.IsNullOrWhiteSpace(cliente.Endereco))
            {
                Console.WriteLine("Preencha todos os campos!");
                return;
            }

            cliente.Nome = cliente.Nome.Trim();
            cliente.Email = cliente.Email.Trim();
            cliente.Whatsapp = cliente.Whatsapp.Trim();
            cliente.Endereco = cliente.Endereco.Trim();

            bool duplicado = clientes.Exists(c =>
                string.Equals(
                    c.Email,
                    cliente.Email,
                    StringComparison.OrdinalIgnoreCase
                ) ||
                string.Equals(
                    c.Whatsapp,
                    cliente.Whatsapp,
                    StringComparison.Ordinal
                )
            );

            if (duplicado)
            {
                Console.WriteLine(
                    "Já existe um cliente com esse e-mail ou WhatsApp!"
                );
                return;
            }

            int maiorId = clientes.Count > 0
                ? clientes.Max(c => c.Id)
                : 0;

            cliente.Id = maiorId + 1;

            clientes.Add(cliente);

            Console.WriteLine("Cliente cadastrado com sucesso!");
        }

        // LISTAR CLIENTES
        public static void ListarClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                return;
            }

            Console.WriteLine("\n=== LISTA DE CLIENTES ===");

            foreach (Cliente item in clientes)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"E-mail: {item.Email}");
                Console.WriteLine($"WhatsApp: {item.Whatsapp}");
                Console.WriteLine($"Endereço: {item.Endereco}");
            }

            Console.WriteLine("------------------------------");
        }

        // REMOVER CLIENTE
        public static void Remover(int id)
        {
            Cliente cliente = clientes.Find(c => c.Id == id);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado!");
                return;
            }

            clientes.Remove(cliente);

            Console.WriteLine(
                $"Cliente {cliente.Nome} removido com sucesso!"
            );
        }

        // EDITAR CLIENTE
        public static void Editar(
            int id,
            string novoNome,
            string novoEmail,
            string novoEndereco,
            string novoWhatsapp)
        {
            Cliente cliente = clientes.Find(c => c.Id == id);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado!");
                return;
            }

            if (string.IsNullOrWhiteSpace(novoNome) ||
                string.IsNullOrWhiteSpace(novoEmail) ||
                string.IsNullOrWhiteSpace(novoEndereco) ||
                string.IsNullOrWhiteSpace(novoWhatsapp))
            {
                Console.WriteLine("Preencha todos os campos!");
                return;
            }

            novoNome = novoNome.Trim();
            novoEmail = novoEmail.Trim();
            novoEndereco = novoEndereco.Trim();
            novoWhatsapp = novoWhatsapp.Trim();

            bool duplicado = clientes.Exists(c =>
                c.Id != id &&
                (
                    string.Equals(
                        c.Email,
                        novoEmail,
                        StringComparison.OrdinalIgnoreCase
                    ) ||
                    string.Equals(
                        c.Whatsapp,
                        novoWhatsapp,
                        StringComparison.Ordinal
                    )
                )
            );

            if (duplicado)
            {
                Console.WriteLine(
                    "Outro cliente já utiliza esse e-mail ou WhatsApp!"
                );
                return;
            }

            cliente.Nome = novoNome;
            cliente.Email = novoEmail;
            cliente.Endereco = novoEndereco;
            cliente.Whatsapp = novoWhatsapp;

            Console.WriteLine("Cliente atualizado com sucesso!");
        }
    }
}
