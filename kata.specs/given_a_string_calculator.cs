using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calculator
    {
        protected static StringCalculator _stringCalculator;
        protected static int _result;

        Establish context =
            () => { _stringCalculator = new StringCalculator(); };
    }
}