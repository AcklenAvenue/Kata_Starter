using Machine.Specifications;

namespace kata.specs
{
    public class when_sum_1_1
    {
        static StringCalculator _stringCalculator;
        static int _result;

        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("1+1");

        It should_return_2 =
            () => _result.ShouldEqual(2);
    }
}