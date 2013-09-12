using Machine.Specifications;

namespace kata.specs
{
    public class when_fizz_buzzing_1 : given_a_fizzbuzz_context
    {
        static string _result;

        Because of =
            () => _result = _fizzbuzzer.GetValue(1);

        It should_return_1 =
            () => _result.ShouldEqual("1");
    }
}