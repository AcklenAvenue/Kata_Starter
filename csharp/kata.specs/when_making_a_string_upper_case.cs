using Machine.Specifications;

namespace kata.specs
{
    public class when_making_a_string_upper_case
    {
        static string _result;

        Because of =
            () => _result = "hello".ToUpper();

        It should_convert_all_characters_to_their_upper_case_form =
            () => _result.ShouldEqual("HELLO");
    }
}