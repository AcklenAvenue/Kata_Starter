using Machine.Specifications;

namespace kata.specs
{
    class Class8
    {
        public class cuando_resta_de_cuatro_numeros
        {
            static Calculadora _calculadora;
            static int _result;

            Establish context =
                () => { _calculadora = new Calculadora(); };

            It deberia_retornar_200 =
                () => _result.ShouldEqual(200);

            Because ocurrio =
                () => _result = _calculadora.Calcular("500-100-100-100");
        }
    }
}