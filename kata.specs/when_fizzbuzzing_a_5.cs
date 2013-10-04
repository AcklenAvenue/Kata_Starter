using Machine.Specifications;

namespace kata.specs
{
    public class when_fizzbuzzing_a_5 : given_a_fizzbuzzer_context
    {

        Because of =
            () => _result = _fizzbuzzer.GetValue(5);

        It should_return_a_buzz =
            () => { _result.ShouldEqual("Buzz"); };

        static string _result;
    }
}