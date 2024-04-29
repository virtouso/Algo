using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class RomanToIntegerConverter
    {
        private static Dictionary<char, int> romanNumerals = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        public  int RomanToInt(string roman)
        {
            int result = 0;
            int prevValue = 0;

            for (int i = roman.Length - 1; i >= 0; i--)
            {
                int currentValue = romanNumerals[roman[i]];

                if (currentValue < prevValue)
                    result -= currentValue;
                else
                    result += currentValue;

                prevValue = currentValue;
            }

            return result;
        }
    }
}