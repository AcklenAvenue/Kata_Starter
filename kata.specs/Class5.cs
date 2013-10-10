using Machine.Specifications;

namespace kata.specs
{
    class Class5
    {
        public class CuandoRestaDeDosNumeros
        {
            static Calculadora _calculadora;
            static int _result;

            Establish context =
                () => { _calculadora = new Calculadora(); };

            It deberia_retornar_50 =
                () => _result.ShouldEqual(50);

            Because ocurrio =
                () => _result = _calculadora.Calcular("100-50");
        }
    }
}