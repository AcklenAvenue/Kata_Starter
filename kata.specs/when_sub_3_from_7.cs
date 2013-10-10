using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_3_from_7 : given_context
    {

        Because of =
            () => _result = _stringCalculator.Calculate("7-3");

        It should_return_4 =
            () => _result.ShouldEqual(4);

        static int _result;
    }
}