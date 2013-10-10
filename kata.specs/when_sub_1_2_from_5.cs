using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_1_2_from_5 : given_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("5-2-1");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}