using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_3_and_substracting_it_from_10_and_substracting_from_20 : given_a_string_calculator_context
    {

        Because of = () => { Result = StringCalculator.Calculate("20-10-2+3"); };

        It should_return_11 = () => Result.ShouldEqual(11);
    }
}