namespace kata.specs
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            var _result = 0;
            if (s.Contains("-") && s.Contains("+"))
            {
                
                var nums = s.Split('+');
             
                foreach (var num in nums)
                {
                    if (num.Contains("-"))
                    {
                        _result += Resultsub(num);
                    }
                    else
                    {
                        _result += int.Parse(num);
                    }
                }
                return _result;
              
            }

            if (s.Contains("-"))
            {
                var resultsub = Resultsub(s);
                return resultsub;
                
            }

            int result = 0;

            if (s.Contains("+"))
            {
                var number = s.Split('+');
                foreach (var num in number)
                {
                    result += int.Parse(num);
                }

                return result;
            }

         

            return _result;

        }

        static int Resultsub(string s)
        {
            var numsub = s.Split('-');
            int resultsub = int.Parse(numsub[0]);
            for (int i = 1; i < numsub.Length; i++)
            {
                resultsub -= int.Parse(numsub[i]);
            }
            return resultsub;
        }
    }
}