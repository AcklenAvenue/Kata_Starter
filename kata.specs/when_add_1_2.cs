using Machine.Specifications;

namespace kata.specs
{
    public class when_add_1_2
    {
        static StrinCalc _stringCalc;
        static int _result;

        Establish context =
            () => { _stringCalc = new StrinCalc(); };

        Because of =
            () => _result = _stringCalc.Calculate("1+2");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}