using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_multiple_numbers : given_a_calculator_context 
    {
        Because of =
            () => _result = _calculator.Calculate("2+1+3");

        It should_return_6 =
            () => _result.ShouldEqual(6);
    }
}