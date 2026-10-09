

using System;

namespace _pizzaplex_
{
    public class Cardapio
    {
        public string Calabresa { get; set; } = "Calabresa";
        public decimal ValorCalabresa { get; set; } = 35.00m;

        public string Frango { get; set; } = "Frango";
        public decimal ValorFrango { get; set; } = 38.00m;

        public string Portuguesa { get; set; } = "Portuguesa";
        public decimal ValorPortuguesa { get; set; } = 40.00m;

        public string Palmito { get; set; } = "Palmito";
        public decimal ValorPalmito { get; set; } = 37.00m;

        public void Cadastrar()
        {
            Console.WriteLine("================================");
            Console.WriteLine("           CARDÁPIO             ");
            Console.WriteLine("================================");

            Console.WriteLine($"{Calabresa}: R$ {ValorCalabresa:F2}");
            Console.WriteLine($"{Frango}: R$ {ValorFrango:F2}");
            Console.WriteLine($"{Portuguesa}: R$ {ValorPortuguesa:F2}");
            Console.WriteLine($"{Palmito}: R$ {ValorPalmito:F2}");

            Console.WriteLine("================================");
        }
    }
}

