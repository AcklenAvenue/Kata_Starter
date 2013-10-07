using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_multiple_numbers
    {
        Establish context =
            () => { _calculator = new StringCalculator(); };

        Because of =
            () => _result = _calculator.Calculate("4-1-2");

        It should_return_the_expected_value =
            () => _result.ShouldEqual(1);

        static StringCalculator _calculator;
        static int _result;
    }
}