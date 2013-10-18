using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calculator_conext
    {
        protected static StringCalculator StringCalculator;
        protected static int Result;

        Establish context =
            () => { StringCalculator = new StringCalculator(); };
    }
}