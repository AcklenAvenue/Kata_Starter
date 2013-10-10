using Machine.Specifications;

namespace kata.specs
{
    public class CuandoSumaDeDosNumeros : dado_un_contexto_de_calculadora
    {

        It deberia_retornar_60 =
            () => _result.ShouldEqual(60);

        Because ocurrio = 
            () => _result = _calculator.Calculate("30+30");

        static int _result;
    }
}