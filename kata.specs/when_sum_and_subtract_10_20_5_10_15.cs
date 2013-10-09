using Machine.Specifications;

namespace kata.specs
{
    public class when_sum_and_subtract_10_20_5_10_15 : given_a_string_calcultor_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("10+20-5-10+15");

        It should_return_30 =
            () => _result.ShouldEqual(30);
    }
}