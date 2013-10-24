using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_3_and_subtracting_4 : given_a_calculator
    {
        Because of =
            () => _result = _calculator.Calculate("2+3-4");

        It should_return_1 =
            () => _result.ShouldEqual(1);
    }
}