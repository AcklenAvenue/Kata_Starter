using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_4_from_9 : given_a_string_calc_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("9-4");

        It should_do_something =
            () => _result.ShouldEqual(5);
    }
}