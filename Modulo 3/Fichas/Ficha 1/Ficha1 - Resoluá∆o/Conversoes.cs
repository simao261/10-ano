using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1
{
    /// <summary>
    /// Implementa operações de conversão.
    /// </summary>
    internal class Conversoes
    {
        /// <summary>
        /// Conversão de temperaturas.
        /// </summary>
        /// <param name="conversao">A conversão a efetuar.</param>
        /// <param name="temperatura">A temperatua a converter.</param>
        /// <returns>Retorna o resultado da conversão da temperatura.</returns>
        public static double ConversaoTemperatura(int conversao, double temperatura)
        {
            if (conversao == 1)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == 2)
            {
                return ((temperatura - 32) / 1.8000);
            }

            return -1;
        }
    }
}
