using Machine.Specifications;

namespace kata.specs
{
    class Class6
    {
        public class cuando_resta_de_dos_numeros
        {
            static Calculadora _calculadora;
            static int _result;

            Establish context =
                () => { _calculadora = new Calculadora(); };

            It deberia_retornar_400 =
                () => _result.ShouldEqual(400);

            Because ocurrio =
                () => _result = _calculadora.Calcular("500-100");
        }
    }
}