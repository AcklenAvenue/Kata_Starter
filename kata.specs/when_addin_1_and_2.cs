using Machine.Specifications;

namespace kata.specs
{
    public class when_addin_1_and_2
    {
        Establish context =
            () => { _calculator = new Calculator(); };

        Because of =
            () => _result = _calculator.Calculate("1+2");

        It should_return_3 =
            () => _result.ShouldEqual(3);

        static Calculator _calculator;
        static int _result;
    }
}