using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_3_and_subtracting_1:given_a_calculator
    {
        Because of =
            () => _result = _calculator.Calculate("2+3-1");

        It should_return_4 =
            () => _result.ShouldEqual(4);
    }
}