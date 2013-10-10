using Machine.Specifications;

namespace kata.specs
{
    class Class2
    {
        public class CuandoSumaSeDosNumeros
        {
            static Calculadora _calculadora;
            static int _result;

            Establish context =
                () => { _calculadora = new Calculadora(); };

            It deberia_retornar_100 =
                () => _result.ShouldEqual(100);

            Because ocurrio =
                () => _result = _calculadora.Calcular("50+50");
        }
    }
}