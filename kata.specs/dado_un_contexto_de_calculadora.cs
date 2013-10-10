using Machine.Specifications;

namespace kata.specs
{
    public class dado_un_contexto_de_calculadora
    {
        Establish context = () =>
            {
                _calculator = new StringCalculator();
            };

        protected static StringCalculator _calculator;
    }
}