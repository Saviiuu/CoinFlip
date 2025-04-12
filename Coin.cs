using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    public class Coin
    {
        private string ladoSorteado;

        public string LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }

        public Coin()
        {
        
        
        }

        public string Flip()
        {
            Random random = new Random();
           
            LadoSorteado = random.Next(2) == 0 ? "Cara" : "Coroa";

            return (LadoSorteado);
        }

    }
}
