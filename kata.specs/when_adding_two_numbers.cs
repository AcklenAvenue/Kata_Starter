using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_two_numbers
    {
        static StringCalculator _stringCalculator;
        static int _result;

        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("1+2");

        It should_do_something =
            () => _result.ShouldEqual(3);
    }
}