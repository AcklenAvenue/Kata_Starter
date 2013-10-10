using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_4_and_substracting_it_from_12 : given_a_string_calculator_context
    {

        Because of = () => { Result = StringCalculator.Calculate("12-2+4"); };

        It should_return_6 = () => Result.ShouldEqual(6);
    }
}