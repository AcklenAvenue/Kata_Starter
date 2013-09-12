using Machine.Specifications;

namespace kata.specs
{
    public class when_fizzbuzzing_a_3 : given_a_fizzbuzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzbuzzer.GetValue(3);

        It should_return_a_fizz =
            () => _result.ShouldEqual("fizz");
    }
}