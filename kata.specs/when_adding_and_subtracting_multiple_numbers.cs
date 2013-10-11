using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_and_subtracting_multiple_numbers : given_a_calc
    {
        static int _result;

        Because of =
            () => _result = _stringCalculator.Calculate("-5+6-10+100-1000");

        It should_return_the_sum_of_all =
            () => _result.ShouldEqual(909);
    }
}