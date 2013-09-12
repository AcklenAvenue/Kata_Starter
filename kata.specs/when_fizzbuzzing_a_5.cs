using Machine.Specifications;

namespace kata.specs
{
    public class when_fizzbuzzing_a_5 : given_a_fizzbuzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzbuzzer.GetValue(5);

        It should_return_a_buzz =
            () => _result.ShouldEqual("buzz");
    }
}