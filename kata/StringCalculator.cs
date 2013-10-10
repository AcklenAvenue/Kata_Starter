using System;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string cadena)
        {
            if(cadena.Contains("-"))
                return 0;

            var sumandos = cadena.Split('+');
            var suma = 0;
            foreach (var sumando in sumandos)
            {
                suma += Convert.ToInt32(sumando);
            }
            return suma;
        }
    }
}