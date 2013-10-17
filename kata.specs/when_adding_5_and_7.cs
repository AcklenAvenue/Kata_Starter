using Machine.Specifications;

namespace kata.specs
{
    class when_adding_5_and_7 : given_a_string_calcultor_context
    {
        Because of = () => { Result = Calculator.Calculate("5+7"); };

        It should_return_12 = () => Result.ShouldEqual(12);
    }
}