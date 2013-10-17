using Machine.Specifications;

namespace kata.specs
{
    public class given_string_calculator_context
    {
        protected static int Result;
        protected static StringCalculator Calculator;

        Establish context =
            () => { Calculator = new StringCalculator(); };
    }
}