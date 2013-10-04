using Machine.Specifications;

namespace kata.specs
{
    public class when_fizzbuzzing_a_4 : given_a_fizzbuzzer_context
    {
        static string _result;

        Because of =
            () => _result = _fizzbuzzer.GetValue(4);

        It should_return_a_4 =
            () => _result.ShouldEqual("4");
    }
}