using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_9_and_6
    {
        Establish context = () => { _calculator = new StringCalculator(); };

        Because of = () => _result = _calculator.Calculate("9+6");

        It should_return_15 = () => _result.ShouldEqual(15);
        static StringCalculator _calculator;
        static int _result;
    }
}