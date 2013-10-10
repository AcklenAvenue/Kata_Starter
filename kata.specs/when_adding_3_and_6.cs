using Machine.Specifications;

namespace kata.specs
{
    public class dado_un_contexto_de_calculadora
    {
        Establish context = () =>
        {
            _calculator = new StringCalculator();
        };

        protected static StringCalculator _calculator;
    }

    public class when_adding_3_and_6 : dado_un_contexto_de_calculadora
    {
        Because of = () => { _result = _calculator.Calculate("3+6"); };

        It should_return_9 = () => _result.ShouldEqual(9);
        static int _result;
    }
}