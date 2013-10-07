using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_multiple_numbers
    {
        Establish context =
            () => { _calculator = new StringCalculator(); };

        Because of =
            () => _result = _calculator.Calculate("2+1+3");

        It should_return_correct_result =
            () => _result.ShouldEqual(6);

        static StringCalculator _calculator;
        static int _result;
    }
}