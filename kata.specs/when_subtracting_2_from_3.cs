using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_2_from_3 : given_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("3-2");

        It should_return_1 =
            () => _result.ShouldEqual(1);
    }
}