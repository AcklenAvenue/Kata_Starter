using Machine.Specifications;

namespace kata.specs
{
    class Class7
    {
        public class cuando_resta_de_tres_numeros
        {
            static Calculadora _calculadora;
            static int _result;

            Establish context =
                () => { _calculadora = new Calculadora(); };

            It deberia_retornar_500 =
                () => _result.ShouldEqual(500);

            Because ocurrio =
                () => _result = _calculadora.Calcular("1000-300-200");
        }
    }
}