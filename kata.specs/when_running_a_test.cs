using Machine.Specifications;

namespace kata.specs
{
    public class when_sending_1
    {
        static FizzBuzz _fizzBuzz;
        static string _result;

        Establish context =
            () => { _fizzBuzz = new FizzBuzz(); };

        Because of =
            () => _result = _fizzBuzz.Send(1);

        It should_return_1 =
            () => _result.ShouldEqual("1");
    }
}