namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var result = 0;
            if (s.Contains("-") && s.Contains("+"))
            {
                var number = s.Split('+');
                var sub = number[0];
                var numsub = sub.Split('-');
                var first = int.Parse(numsub[0]);
                for (int i = 1; i < numsub.Length; i++)
                {
                    first -= int.Parse(numsub[i]);
                }

                result = first + int.Parse(number[1]);
                return result;
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
            foreach (var number in numbers)
            {
                result += int.Parse(number);
            }

            return result;


          
        }

    }
}