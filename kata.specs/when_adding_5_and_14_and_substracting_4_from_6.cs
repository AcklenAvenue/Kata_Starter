using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_5_and_14_and_substracting_4_from_6 : given_a_string_calc_context
    {

        Because of =
            () => _result = _stringCalculator.Calculate("5+14+6-4");

        It should_do_something =
            () => _result.ShouldEqual(21);

        static int _result;
    }
}