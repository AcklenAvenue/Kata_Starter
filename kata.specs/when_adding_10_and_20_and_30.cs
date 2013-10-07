using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_10_and_20_and_30 : given_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("10+20+30");

        It should_return_60 =
            () => _result.ShouldEqual(60);
    }
}