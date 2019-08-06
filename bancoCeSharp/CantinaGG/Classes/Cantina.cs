using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CantinaGG.Classes
{
    public class CantinaGG
    {
        /// <summary>
        /// Mana para poder comparar lanches em pontos de saldo
        /// </summary>
        double saldo = 0;
        public CantinaGG(double valor)
        {
            saldo = valor;
        }
        /// <summary>
        /// Dedus do seu saldo de manda ao utilizar esta skill
        /// </summary>
        /// <param name="valor">Valor do lanche</param>
        public bool PoderDeComprarLanches(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }

            return false;
        }
    }
}
