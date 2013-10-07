using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_and_subtracting_multiple_numbers : given_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("50-10+5-20-1");

        It should_return_24 =
            () => _result.ShouldEqual(24);
    }
}