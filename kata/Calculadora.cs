using System;
using System.Linq;

namespace kata
{
    public class Calculadora
    {
        public int Calcular(string cadena)
        {
            if (cadena == "")
                return 0;
            var resultado = 0;
            var lista = cadena.Split('+');

            foreach (var numeroDeListaPrincipalQueTalvezLlevaMenos in lista)
            {
                if (numeroDeListaPrincipalQueTalvezLlevaMenos.Contains('-'))
                {
                    var listDeNumerosDeSplitDeMenos = numeroDeListaPrincipalQueTalvezLlevaMenos.Split('-');
                    var restado = Convert.ToInt32(listDeNumerosDeSplitDeMenos[0]);
                    for (int i = 1; i < listDeNumerosDeSplitDeMenos.Length; i++)
                    {

                        restado -= Convert.ToInt32(listDeNumerosDeSplitDeMenos[i]);
                    }
                    resultado += restado;
                }
                else
                    resultado += Convert.ToInt32(numeroDeListaPrincipalQueTalvezLlevaMenos);
            }
            return resultado;
        }
    }
}