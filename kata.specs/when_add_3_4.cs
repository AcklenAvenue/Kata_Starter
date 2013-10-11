using Machine.Specifications;

namespace kata.specs
{
    public class when_add_3_4 : given_context
    {
        static int _result;

        Because of =
            () => _result = _strincCal.Calculate("3+4");

        It should_return_7 =
            () => _result.ShouldEqual(7);
    }
}