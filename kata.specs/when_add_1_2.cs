using Machine.Specifications;

namespace kata.specs
{
    public class when_add_1_2: given_context
    {
        static int _result;

        Because of =
            () => _result = _strincCal.Calculate("1+2");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}