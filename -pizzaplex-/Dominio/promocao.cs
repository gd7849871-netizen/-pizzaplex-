using System;
using System.Collections.Generic;

namespace _pizzaplex_.Dominio
{
    internal class promocoes
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double ValorDesconto { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Status { get; set; }
    }
}