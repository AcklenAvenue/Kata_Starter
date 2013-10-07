using Machine.Specifications;

namespace kata.specs
{
    public class when_string_is_empty
    {
        static StringCalculator _stringCalculator;
        static int _result;

        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("");

        It should_do_something =
            () => _result.ShouldEqual(0);
    }
}