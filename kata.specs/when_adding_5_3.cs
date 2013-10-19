using Machine.Specifications;
using kata;

namespace kata.specs{
    

    public class when_adding_5_3 : given_calculator_context
    {
        Because of =
            () => _result = _calculator.Calculate("5+3");

        It should_return_8 =
            () => _result.ShouldEqual(8);

        static int _result;
    }
}