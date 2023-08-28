using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D1
{
    internal class Prodotto
    {
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public int Quantità { get; set; }

        public decimal CalcolaTotale()
        {
            return Prezzo * Quantità;
        }
    }
}
