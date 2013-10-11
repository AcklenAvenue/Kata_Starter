using Machine.Specifications;

namespace kata.specs
{
    public class when_add_1_2
    {
        static StringCal _strinCal;
        static int _result;

        Establish context =
            () => { _strinCal = new StringCal(); };

        Because of =
            () => _result = _strinCal.Calculate("1+2");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}