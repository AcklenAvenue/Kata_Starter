using Machine.Specifications;

namespace kata.specs
{
    public class cuando_suma_10_y_5_y_le_resta_3 : dado_un_contexto_de_calculadora
    {
        static int _result;
        Because of = () => { _result = _calculator.Calculate("10+15-3"); };

        It should_return_12 = () => _result.ShouldEqual(12);
    }
}