using Machine.Specifications;

namespace kata.specs
{
    public class when_sum_1_2 : given_a_string_calcultor_context
    {
        static int _result;

        Because of =
            () => _result = StringCalculator.Calculate("1+2");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}