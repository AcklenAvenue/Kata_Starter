using Machine.Specifications;

namespace kata.specs
{
    public class when_add_1_2_3 : given_context
    {
        static int _result;

        Because of =
            () => _result = _strincCal.Calculate("1+2+3");

        It should_return_6 =
            () => _result.ShouldEqual(6);
    }
}