using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_two_numbers
    {
        Establish context = () => { _calculator = new StringCalculator(); };

        Because of = () => _result = _calculator.Calculate("1+2");

        It should_return_3 = () => _result.ShouldEqual(3);
        static StringCalculator _calculator;
        static int _result;
    }
}