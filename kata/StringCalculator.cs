using System;

namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string cadena)
        {
            if (cadena.Contains("-") && cadena.Contains("+"))
                return 0;
            var resultado = 0;
            if (cadena.Contains("-"))
            {
                var elementos = cadena.Split('-');
                resultado = Convert.ToInt32(elementos[0]);
                for (var i = 1; i < elementos.Length; i++)
                {
                    resultado -= Convert.ToInt32(elementos[i]);
                }
            }
            else
            {
                var sumandos = cadena.Split('+');
                resultado = 0;
                foreach (var sumando in sumandos)
                {
                    resultado += Convert.ToInt32(sumando);
                }
            }
            return resultado;
        }
    }
}