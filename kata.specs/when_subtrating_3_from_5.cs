using Machine.Specifications;

namespace kata.specs
{
    public class when_subtrating_3_from_5 : given_a_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("5-3");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}