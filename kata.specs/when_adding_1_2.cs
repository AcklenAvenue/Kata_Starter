using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_1_2
    {
        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("1+2");

        It should_return_3 =
            () => _result.ShouldEqual(3);

        static StringCalculator _stringCalculator;
        static int _result;
    }
}