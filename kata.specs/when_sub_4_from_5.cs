using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_4_from_5: given_context
    {

        Because of =
            () => _result = _strincCal.Calculate("5-4");

        It should_return_1 =
            () => _result.ShouldEqual(1);

        static int _result;
    }
}