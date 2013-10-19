using Machine.Specifications;

namespace kata.specs
{
    public class when_running_a_test
    {
        static string _result;

        Because of =
            () => _result = "hello".ToUpper();

        It should_pass =
            () => _result.ShouldEqual("HELLO");
    }

    public class when_adding_5_3
    {
        static StringCalculator _calculator;
        static int _result;

        Establish context =
            () => { _calculator = new StringCalculator(); };

        Because of =
            () => _result = _calculator.Calculate("5+3");

        It should_return_8 =
            () => _result.ShouldEqual(8);

    }

    class StringCalculator
    {
        public int Calculate(string s)
        {
            return 0;
        }
    }
}