using Machine.Specifications;

namespace kata.specs
{
    public class cuando_resta_6_y_2 : dado_un_contexto_de_calculadora
    {
        static int _result;

        Because of = () => { _result = _calculator.Calculate("6-2"); };

        It debe_retornar_4 = () => _result.ShouldEqual(4);
        
    }
}