using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_3
    {
        static int _result;
        static StringCalculator Calculator;

        Establish context =
            () => { Calculator = new StringCalculator(); };

        Because of =
            () => _result = Calculator.Calculate("2+3");

        It should_return_5 =
            () => _result.ShouldEqual(5);
    }
}