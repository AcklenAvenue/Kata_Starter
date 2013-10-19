using Machine.Specifications;

namespace kata.specs
{
    public class given_calculator_context
    {
       public static StringCalculator _calculator;

        Establish context =
            () => { _calculator = new StringCalculator(); };
    }
}