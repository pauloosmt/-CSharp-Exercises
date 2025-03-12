using System;

namespace Exericio030
{
    class CurrencyConverter
    {
        public static double Dollar;
        
        public static double Converter(double quant)
        {
            return Dollar * quant * 1.06;

        }
    }
}
