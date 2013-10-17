using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_10_20_and_subtracting_15 : given_a_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("10+20-15");

        It should_return_15 =
            () => _result.ShouldEqual(15);
    }
}