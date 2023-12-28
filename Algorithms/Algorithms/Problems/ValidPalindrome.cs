using System.Text.RegularExpressions;

namespace Algorithms.Problems
{
    public class ValidPalindrome
    {
        // we acan also use deque or two sided queue
        // or we can compare it with reverse: s.Reverse
        public bool IsPalindrome(string s) {
            s = Regex.Replace(s, @"[^a-zA-Z0-9]", "").Replace(" ","").ToLower();
            
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
        
    }
}