using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_and_3_from_6 : given_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("6-3-2");

        It should_return_1 =
            () => _result.ShouldEqual(1);
    }
}