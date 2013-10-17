using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_multiple_numbers : given_a_calculator
    {
        Because of =
            () => _result = _calculator.Calculate("2+3+4");

        It should_return_the_expected_value =
            () => _result.ShouldEqual(9);
    }
}