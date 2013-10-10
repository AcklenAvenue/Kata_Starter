using Machine.Specifications;

namespace kata.specs
{
    class Class1
    {
        public class CuandoEnvioUnaCadenaVacia
        {
            static Calculadora _calculadora;
            static object _result;

            Establish context =
                () => { _calculadora = new Calculadora(); };

            It deberia_retornar_0 =
                () => _result.ShouldEqual(0);

            Because ocurrio =
                () => _result = _calculadora.Calcular("");
        }
    }
}