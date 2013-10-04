using Machine.Specifications;

namespace kata.specs
{
    public class when_fizzbuzzing_30 : given_a_fizzbuzzer_context
    {
        static string _result;

        Because of =
            () => _result = _fizzbuzzer.GetValue(30);

        It should_return_a_9 =
            () => _result.ShouldEqual("FizzBuzz");
    }
}