using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_3_4
    {
        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("3+4");

        It should_return_7 =
            () => _result.ShouldEqual(7);

        static StringCalculator _stringCalculator;
        static int _result;
    }
}