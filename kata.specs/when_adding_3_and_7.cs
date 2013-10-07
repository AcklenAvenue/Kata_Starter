using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_and_7 : given_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("3+7");

        It should_return_10 =
            () => _result.ShouldEqual(10);
    }
}