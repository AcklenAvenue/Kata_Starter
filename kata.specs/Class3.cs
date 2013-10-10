using Machine.Specifications;

namespace kata.specs
{
    class Class3
    {
        public class CuandoSumaDeTresNumeros
        {
            static Calculadora _calculadora;
            static int _result;

            Establish context =
                () => { _calculadora = new Calculadora(); };

            It deberia_retornar_500 =
                () => { };

            Because ocurrio =
                () => _result = _calculadora.Calcular("100+100+300");
        }
    }
}