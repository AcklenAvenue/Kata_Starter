using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_1_and_2_from_10 :given_a_string_calculator
    {
        Because of =
            () => _result = _stringCalculator.Calculate("10-2-1");

        It should_return_7 =
            () => _result.ShouldEqual(7);
    }
}