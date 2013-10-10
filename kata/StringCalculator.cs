namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if(s.Contains("-") && s.Contains("+"))
            {
                return -10123091;
            }
            if (s.Contains("-"))
            {
                var numbersSub = s.Split('-');
                var resultSub = int.Parse(numbersSub[0]);
                for (int i = 1; i < numbersSub.Length; i++)
                {
                    resultSub -= int.Parse(numbersSub[i]);
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