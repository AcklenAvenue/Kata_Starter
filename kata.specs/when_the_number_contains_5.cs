using Machine.Specifications;

namespace kata.specs
{
    public class when_the_number_contains_5 : given_a_fizz_buzzer_context
    {
        static string _result;

        Because of =
            () => _result = FizzBuzzer.Play(52);

        It should_return_the_word_buzz =
            () => _result.ShouldEqual("buzz");
    }
}