using Machine.Specifications;

namespace kata.specs
{
    public class when_sub_and_add_multiple_number : given_calculator_context
    {

        Because of =
            () => _result = _calculator.Calculate("100-100+25+25");

        It should_return_50 =
            () => _result.ShouldEqual(50);

        static int _result;
    }
}