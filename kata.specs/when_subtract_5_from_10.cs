using Machine.Specifications;

namespace kata.specs
{
    public class when_subtract_5_from_10 : given_a_string_calcultor_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("10-5");

        It should_return_5 =
            () => _result.ShouldEqual(5);
    }
}