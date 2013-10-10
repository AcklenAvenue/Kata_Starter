using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_4_from_8 : given_an_calculator_context
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("8-4");

        It should_do_something =
            () => _result.ShouldEqual(4);
    }
}