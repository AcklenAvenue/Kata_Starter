using Machine.Specifications;

namespace kata.specs
{
    public class when_subtract_1_and_2_from_5 : given_a_string_calcultor_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("5-2-1");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}