using Machine.Specifications;

namespace kata.specs
{
    class Class4
    {
        public class CuandoSumaDeCuatroNumeros
        {
            static Calculadora _calculadora;
            static int _result;

            Establish context =
                () => { _calculadora = new Calculadora(); };

            It deberia_retornar_1000 =
                () => _result.ShouldEqual(1000);

            Because ocurrio =
                () => _result = _calculadora.Calcular("200+200+300+300");
        }
    }
}