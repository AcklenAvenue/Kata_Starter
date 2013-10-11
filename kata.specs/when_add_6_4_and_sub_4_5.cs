using Machine.Specifications;

namespace kata.specs
{
    public class when_add_6_4_and_sub_4_5 :given_context
    {
        Because of =
            () => _result = _strincCal.Calculate("6+4-5-4");

        It should_return_1 =
            () => _result.ShouldEqual(1);

        static int _result;
    }
}