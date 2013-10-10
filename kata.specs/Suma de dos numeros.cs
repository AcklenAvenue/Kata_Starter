using System;
using Machine.Specifications;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kata.specs
{
    class Suma_de_dos_numeros
    {
        static Calculadora calculadora;
        static int _resultado;
        Establish contexto = () =>
        {
            calculadora = new Calculadora();
        };
        Because of = () => _resultado = calculadora.Calcular("20+30");

        It deberia_retornar_50 = () => _resultado.ShouldEqual(50);
    }
}
