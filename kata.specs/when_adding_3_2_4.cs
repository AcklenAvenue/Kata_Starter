using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_2_4:given_a_string_calculator
    {
        Because of =
            () => _result = _stringCalculator.Calculate("3+2+4") ;

        It should_return_9 =
            () => _result.ShouldEqual(9);
    }
}