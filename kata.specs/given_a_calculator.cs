using Machine.Specifications;

namespace kata.specs
{
    public class given_a_calculator
    {
        Establish context =
            () => { _Calculator = new Calculator(); };

        protected static Calculator _Calculator;
        protected static int _result;
    }
}