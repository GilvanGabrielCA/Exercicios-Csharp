using System;
using System.Globalization;

namespace ConversorMoedaPOO
{
    internal class ConversorDeMoedas
    {
        public static double Iof = 6.0;

        public static double ValorPago(double quantia, double cotacao)
        {
            double total = quantia * cotacao;

            return total + total * Iof / 100.0 ;
        }

    }
}
