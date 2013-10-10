using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace kata.specs
{
    class Class10
    {
        public class CuandoRestaDeTresNumeros : dado_un_contexto_de_calculadora
        {
            Because ocurrio =
                () => _result = _calculator.Calculate("200-50-50");

            It deberia_retornar_100 =
                () => { _result.ShouldEqual(100); };

            static int _result;
        }
    }
}
