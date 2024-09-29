public static class Solution
{
    public static int RomanToInteger(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        //MCMXCIV - 1994

        int total = 0;
        int i = 0;
        while (i < s.Length)
        { //7
            char currentChar = s[i]; //M
            int currentValue = dic[currentChar]; //1000

            if (i + 1 < s.Length)
            {
                char nextChar = s[i + 1]; //C
                int nextValue = dic[nextChar]; //100

                if (currentValue >= nextValue)
                {
                    total = total + currentValue;
                    i++;
                }
                else
                {
                    total = total + (nextValue - currentValue);
                    i += 2;
                }
            }
            else
            {
                total = total + currentValue;
                i += 1;
            }
        }
        return total;
    }

    public static void Main(string[] args)
    {
        string romanNumbers = "MMMCMXCIX"; //Output = 3999

        try
        {
            int result = RomanToInteger(romanNumbers);
            Console.WriteLine($"Result is = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}