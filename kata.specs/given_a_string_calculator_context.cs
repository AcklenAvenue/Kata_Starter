using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calculator_context
    {
        Establish context =
            () =>
                {
                    Calculator = new StringCalculator();
                };

        protected static StringCalculator Calculator;
    }
}