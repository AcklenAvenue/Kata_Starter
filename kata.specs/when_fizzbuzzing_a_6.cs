using Machine.Specifications;

namespace kata.specs
{
    public class when_fizzbuzzing_a_6 : given_a_fizzbuzzer_context
    {
        static string _result;

        Because of =
            () => _result = _fizzbuzzer.GetValue(6);

        It should_return_fizz =
            () => _result.ShouldEqual("Fizz");
    }
}