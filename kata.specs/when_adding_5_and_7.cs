using Machine.Specifications;

namespace kata.specs
{
    class when_adding_5_and_7 : given_a_string_calcultor_context
    {
        Because of = () => { Result = Calculator.Calculate("5+7"); };

        It should_return_12 = () => Result.ShouldEqual(12);
    }

    class when_subtracting_7_from_10 : given_a_string_calcultor_context
    {

        Because of = () => { Result = Calculator.Calculate("10-7"); };

        It should_return_3 = () => Result.ShouldEqual(3);
    }
}