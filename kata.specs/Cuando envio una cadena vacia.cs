using System;
using Machine.Specifications;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kata.specs
{
    class Cuando_envio_una_cadena_vacia
    {
        static Calculadora calculadora;
        static int _resulatdo;
        Establish coontexto = () => 
        {
            calculadora = new Calculadora();
        };
        Because of = () => _resulatdo = calculadora.Calcular("");

        It deberia_retornar_0 = () => _resulatdo.ShouldEqual(0);
    }
}
