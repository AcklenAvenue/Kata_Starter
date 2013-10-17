using Machine.Specifications;

namespace kata.specs
{
    class when_adding_and_subtracting_10_5_and_3 : given_a_string_calcultor_context
    {
        Because of = () => { Result = Calculator.Calculate("10+5-3"); };

        It should_return_12 = () => Result.ShouldEqual(12);
    }
}