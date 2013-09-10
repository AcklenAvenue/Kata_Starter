using Machine.Specifications;

namespace kata.specs
{
    public class when_the_number_contains_3 : given_a_fizz_buzzer_context
    {
        static string _result;

        Because of = () => _result = FizzBuzzer.Play(13);

        It should_return_the_word_fizz = () => _result.ShouldEqual("fizz");
    }
}