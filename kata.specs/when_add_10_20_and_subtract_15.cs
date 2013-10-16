using Machine.Specifications;

namespace kata.specs
{
    public class when_add_10_20_and_subtract_15 : given_context
    {
        static int _result;

        Because of =
            () => _result = _calculator.Calculate("10+20-15");

        It should_return_15 =
            () => _result.ShouldEqual(15);
    }
}