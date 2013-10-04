using Machine.Specifications;

namespace kata.specs
{
    public class when_fizzbuzzing_a_2 : given_a_fizzbuzzer_context
    {
        static string _result;

        Because of =
            () => _result = _fizzbuzzer.GetValue(2);

        It should_return_a_2 =
            () => _result.ShouldEqual("2");
    }
}