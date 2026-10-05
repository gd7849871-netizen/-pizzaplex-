using System;

namespace _pizzaplex_.Dominio
{
    public class CadastroCliente
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string whatsapp { get; set; }
        public string endereco { get; set; }

        public void Cadastrar()
        {
            Console.WriteLine("================================");
            Console.WriteLine("       CADASTRO DE CLIENTE      ");
            Console.WriteLine("================================");

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("E-mail: ");
            email = Console.ReadLine();

            Console.Write("WhatsApp: ");
            whatsapp = Console.ReadLine();

            Console.Write("Endereço: ");
            endereco = Console.ReadLine();

            Console.WriteLine("\nCliente cadastrado com sucesso!");
        }
    }


}
