namespace kata
{
    public class StringCalculator
    {
        public int Calculate(string s)
        {
            if (s.Contains("-") && s.Contains("+"))
                return 0;
            if (s.Contains("-"))
            {
                var elements = s.Split('-');
                var rest = int.Parse(elements[0]);
                for (int i = 1; i < elements.Length; i++)
                {
                    rest -= int.Parse(elements[i]);
                }
                return rest;
            }else
            {
                int sum = 0;
                string[] elements = s.Split('+');
                foreach (string element in elements)
                {
                    sum += int.Parse(element);
                }
                return sum;
            }
                
        }
    }
}