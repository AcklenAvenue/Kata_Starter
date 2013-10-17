using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_5 : given_string_calculator_context
    {

        Because of = () => { Result = Calculator.Calculate("3+5"); };

        It should_return_8 = () => Result.ShouldEqual(8);
    }
}