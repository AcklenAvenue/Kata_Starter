using Machine.Specifications;

namespace kata.specs
{
    public class when_sum_3_5 : given_a_string_calcultor_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("3+5");

        It should_return_8 =
            () => _result.ShouldEqual(8);
    }
}