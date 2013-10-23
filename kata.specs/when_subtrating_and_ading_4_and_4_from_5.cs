using Machine.Specifications;

namespace kata.specs
{
    public class when_subtrating_and_ading_4_and_4_from_5:given_a_string_calculator
    {
        Because of =
            () => _result = _stringCalculator.Calculate("4+4-5");

        It should_return_3 =
            () => _result.ShouldEqual(3);
    }
}