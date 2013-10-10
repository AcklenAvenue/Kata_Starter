using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_and_6 : dado_un_contexto_de_calculadora
    {
        static int _result;
        Because of = () => { _result = _calculator.Calculate("3+6"); };

        It should_return_9 = () => _result.ShouldEqual(9);
    }
}