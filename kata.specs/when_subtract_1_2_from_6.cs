using Machine.Specifications;

namespace kata.specs
{
    public class when_subtract_1_2_from_6 : given_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("6-2-1");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}