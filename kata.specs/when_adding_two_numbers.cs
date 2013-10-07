using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_two_numbers
    {
        Establish context = () =>
            {
                _calculator = new StringCalculator();
            };

        Because of = () => _result = _calculator.Calculate("2+1");

        It should_return_a_correct_result  = () => _result.ShouldEqual(3);
        static StringCalculator _calculator;
        static int _result;
    }
}