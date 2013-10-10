using System;

namespace kata.specs
{
    class Calculadora
    {
        public int Calcular(string cadena)
        {
            if (cadena == "")
                return 0;

            int resultado = 0;
            string[] lista = cadena.Split('+');
            foreach (string numeroDeSplitDeMas in lista)
            {
                if (numeroDeSplitDeMas.Contains("-"))
                {
                    string[] numeroDeSplitDeMenos = numeroDeSplitDeMas.Split('-');
                    int restado = Convert.ToInt32(numeroDeSplitDeMenos[0]);
                    for (int i = 1; i < numeroDeSplitDeMenos.Length; i++)
                    {
                        restado -= Convert.ToInt32(numeroDeSplitDeMenos[i]);
                    }
                    resultado += restado;
                }
                else
                    resultado += Convert.ToInt32(numeroDeSplitDeMas);
            }
            return resultado;
        }
    }
}