using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_two_number
    {
        Establish context = () =>
            {
                _calculator = new StringCalculator();
            };

        Because of = () => _result = _calculator.Calculate("4-1");

        It should_return_the_correct_result = () => _result.ShouldEqual(3);
        static StringCalculator _calculator;
        static int _result;
    }
}