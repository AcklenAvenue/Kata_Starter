using Machine.Specifications;

namespace kata.specs
{
    public class when_adding_2_and_5
    {
        static StringCalculator _stringCalculator;
        static int _result;

        Establish context =
            () => { _stringCalculator = new StringCalculator(); };

        Because of =
            () => _result = _stringCalculator.Calculate("2+5");

        It should_return_7 =
            () => _result.ShouldEqual(7);
    }

    public class when_adding_2_and_2
    {
        private Establish context = () =>
        {
             _stringCalculator = new StringCalculator();
        };

        private Because of = () => { _result = _stringCalculator.Calculate("2+2"); };

        It should_return_4 = () => { _result.ShouldEqual(4); };
        private static StringCalculator _stringCalculator;
        private static int _result;
    }

}