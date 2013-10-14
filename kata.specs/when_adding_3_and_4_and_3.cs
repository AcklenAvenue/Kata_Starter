using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_and_4_and_3 : given_a_string_calculator_context
    {

        Because of = () => { Result = StringCalculator.Calculate("3+4+3"); };

        It should_should = () => Result.ShouldEqual(10);
    }

    public class when_substracting_1_and_2 : given_a_string_calculator_context
    {
        private Because of = () =>
        {
            StringCalculator.Calculate("2-1");
        };

        It should_should = () => { Result.ShouldEqual(1); };
    }

}