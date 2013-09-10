using Machine.Specifications;

namespace kata.specs
{
    public class when_the_number_is_11 : given_a_fizz_buzzer_context
    {
        
        Because of =
            () => _result = FizzBuzzer.Play(11);

        It should_return_the_number_11 =
            () => _result.ShouldEqual("11");

        static string _result;
    }
}