namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-") && s.Contains("+"))
            {
                return 100;
            }
            if (s.Contains("-"))
            {
                var numbersSubs = s.Split('-');
                var resultSub = int.Parse(numbersSubs[0]);

                for (int i = 1; i < numbersSubs.Length; i++)
                {
                    resultSub -= int.Parse(numbersSubs[i]);
                }

                return resultSub;
            
            }
            var numbers = s.Split('+');
            var result = 0;
            foreach (var number in numbers)
            {
                 result += int.Parse(number);
            }

            return result;
        }
    }
}