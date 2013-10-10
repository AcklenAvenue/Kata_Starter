using System;
using Machine.Specifications;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kata.specs
{
    class Resta_de_tres_numeros
    {
        static Calculadora calculadora;
        static int _resultado;
        Establish contexto = () =>
        {
            calculadora = new Calculadora();
        };
        Because of = () => _resultado = calculadora.Calcular("100-30-20");

        It deberia_retornar_50 = () => _resultado.ShouldEqual(50);
    }
}
