using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_and_substracting_multiple_numbers
    {
        Establish context = () => { _calculator = new StringCalculator(); };

        Because of = () => _result = _calculator.Calculate("1+2-1");

        It should_return_the_correct_result = () =>_result.ShouldEqual(2);
        static StringCalculator _calculator;
        static int _result;
    }
}