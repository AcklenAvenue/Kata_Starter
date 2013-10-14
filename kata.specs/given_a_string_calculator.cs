using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calculator
    {
        protected static int Result;
        protected static StringCalculator StringCalculator;

        Establish context =
            () => { StringCalculator = new StringCalculator(); };
    }
}