using Machine.Specifications;

namespace kata.specs
{
    public class when_subtracting_20_30_60 : given_a_calculator_context
    {
        
        Because of =
            () => _result = _calculator.Calculate("60-30-20");

        It should_return_10 =
            () => _result.ShouldEqual(10);
    }
}