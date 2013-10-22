using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_3
    {
        Establish context =
            () => { _calculator = new Calculator(); };

        Because of =
            () => _result = _calculator.Calculate("2+3");

        It should_do_something =
            () => _result.ShouldEqual(5);

        static Calculator _calculator;
        static int _result;
    }
}