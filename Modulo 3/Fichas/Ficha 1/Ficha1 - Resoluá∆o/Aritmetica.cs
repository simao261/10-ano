using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1
{
    /// <summary>
    /// Implementa operações aritméticas.
    /// </summary>
    internal static class Aritmetica
    {
        /// <summary>
        /// Operação soma.
        /// </summary>
        /// <returns>Retorna a soma de dois números.</returns>
        internal static int Soma(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Operação subtração.
        /// </summary>
        /// <returns>Retorna a subtração de dois números.</returns>
        public static int Subtracao(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Operação multiplicação.
        /// </summary>
        /// <returns>Retorna a multiplicação de dois números.</returns>
        public static int Multiplicacao(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// Operação divisão.
        /// </summary>
        /// <returns>Retorna a divisão de dois números.</returns>
        public static double Divisao(int x, int y)
        {
            return (y == 0) ? -1 : (double)x / (double)y;
        }

        /// <summary>
        /// Operação resto.
        /// </summary>
        /// <returns>Retorna o resto da divisão de dois números.</returns>
        public static int Resto(int x, int y)
        {
            return (y == 0) ? -1 : x % y;
        }

        /// <summary>
        /// Operação quadrado.
        /// </summary>
        /// <returns>Retorna o quadrado de um número.</returns>
        public static int Quadrado(int x)
        {
            return x * x;
        }

        /// <summary>
        /// Operação cubo.
        /// </summary>
        /// <returns>Retorna o cubo de um número.</returns>
        public static int Cubo(int x)
        {
            return x * x * x;
        }
    }
}
