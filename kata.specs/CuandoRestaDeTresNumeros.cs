using Machine.Specifications;

namespace kata.specs
{
    public class CuandoRestaDeTresNumeros : dado_un_contexto_de_calculadora
    {
        static int _result;

        It deberia_retornar_100 =
            () => _result.ShouldEqual(100);

        Because ocurrio =
            () => _result = _calculator.Calculate("200-50-50");
    }
}