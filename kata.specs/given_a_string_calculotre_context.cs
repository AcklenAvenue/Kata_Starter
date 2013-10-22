using Machine.Specifications;

namespace kata.specs
{
    public class given_a_string_calculotre_context
    {
        protected static Calculator Calculator;
        protected static int Result;

        Establish context =
            () => { Calculator = new Calculator(); };
    }
}