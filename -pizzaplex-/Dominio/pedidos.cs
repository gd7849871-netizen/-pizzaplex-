

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


