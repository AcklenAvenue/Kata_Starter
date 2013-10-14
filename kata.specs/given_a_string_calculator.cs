using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calculator
    {
        Establish context =
            () => { _stringCalculator= new StringCalculator(); };

        protected static int _result;
        protected static StringCalculator _stringCalculator;
    }
}