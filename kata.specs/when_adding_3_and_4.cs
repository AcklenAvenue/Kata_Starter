using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_and_4
    {
        Establish context =
            () => { _Calculator = new Calculator(); };

        Because of =
            () => _result = _Calculator.Calculate("3+4");

        It should_return_7 =
            () => _result.ShouldEqual(7);

        static Calculator _Calculator;
        static int _result;
    }
}