using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_5 : given_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("5-2");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}