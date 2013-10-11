using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_5_1_from_8 : given_context
    {
        static int _result;

        Because of =
            () => _result = _strincCal.Calculate("8-5-1");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}