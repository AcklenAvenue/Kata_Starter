using Machine.Specifications;

namespace kata.specs
{
    public class when_subtract_3_from_6 : given_context_string_calculator
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("6-3");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}