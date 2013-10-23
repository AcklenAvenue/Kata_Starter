using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_a_1_and_2 : given_a_string_calculator
    {
        Because of =
            () => _result = _stringCalculator.Calculate("1+2");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}