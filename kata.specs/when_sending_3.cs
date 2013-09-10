using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_3
    {
        static FizzBuzz _fizzBuzz;
        static string _result;

        Establish context =
            () => { _fizzBuzz = new FizzBuzz(); };

        Because of =
            () => _result = _fizzBuzz.Send("3");

        It should_return_the_word_fizz =
            () => _result.ShouldEqual("Fizz");
    }
}