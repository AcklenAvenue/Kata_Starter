using Machine.Specifications;

namespace kata.specs
{
    public class when_substraction_1_and_2_from_6:given_a_context
    {
        Because of =
            () => _result = _stringCalculator.Calculate("6-2-1");

        It should_return_3 =
            () => _result.ShouldEqual(3);

        static int _result;
    }
}