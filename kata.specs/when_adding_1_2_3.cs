using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_2_3 : given_a_string_calculator_context
    {
        Because of =
            () => _result = _stringCalculator.Calculate("1+2+3");

        It should_do_something =
            () => _result.ShouldEqual(6);
    }
}