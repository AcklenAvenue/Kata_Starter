using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_4_and_5 : given_string_calculator_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("4+5");

        It should_return_9 =
            () => _result.ShouldEqual(9);
    }
}