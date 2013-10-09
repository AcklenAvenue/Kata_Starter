using Machine.Specifications;

namespace kata.specs
{
    public class when_subtract_10_from_20 : given_a_string_calcultor_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("20-10");

        It should_return_10 =
            () => _result.ShouldEqual(10);
    }
}