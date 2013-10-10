using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_and_subtracting_multiple_numbers :given_an_calculator_context
    {
        Because of =
            () => _result = _stringCalculator.Calculate("-5+4-2");

        It should_return_the_expected_value =
            () => _result.ShouldEqual(-3);

        static int _result;
    }
}