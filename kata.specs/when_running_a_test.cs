using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_3
    {
        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("2+3");

        It should_return_5  =
            () => _result.ShouldEqual(5);

        static StringCalculator _stringCalculator;
        static int _result;
    }
}