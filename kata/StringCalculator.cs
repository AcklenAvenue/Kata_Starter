namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var numbers = s.Split('+');
            var resul = 0;
            foreach (var number in numbers)
            {
                if (number.Contains("-"))
                {
                   resul += Substract(number);
                }
                else
                {
                   resul += Add(number);
                }
            }

            return resul;
        }

        static int Add(string s)
        {
            int sum = 0;
            string[] elements = s.Split('+');
            foreach (string element in elements)
            {
                sum += int.Parse(element);
            }
            return sum;
        }

        static int Substract(string s)
        {
            var elements = s.Split('-');
            var rest = int.Parse(elements[0]);
            for (int i = 1; i < elements.Length; i++)
            {
                rest -= int.Parse(elements[i]);
            }
            return rest;
        }
    }
}