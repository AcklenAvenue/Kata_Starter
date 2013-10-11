using Machine.Specifications;

namespace kata.specs
{
    public class when_substracting_100_from_200 : given_a_calc
    {
        
        Because of = () => _result = _stringCalculator.Calculate("200-100");

        It should_return_100 = () => _result.ShouldEqual(100);
        static int _result;
    }
}