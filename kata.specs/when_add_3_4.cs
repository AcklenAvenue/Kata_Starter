using Machine.Specifications;

namespace kata.specs
{
    public class when_add_3_4
    {
        Establish context =
            () => { _strincCal = new StringCal(); };

        Because of =
            () => _result = _strincCal.Calculate("3+4");

        It should_return_7 =
            () => _result.ShouldEqual(7);

        static StringCal _strincCal;
        static int _result;
    }
}