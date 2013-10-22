using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_2_from_6: given_context
    {
        Because of =
            () => _result = _stringCalculator.Calculate("6-2");

        It should_return_4 =
            () => _result.ShouldEqual(4);

        static int _result;
    }
}