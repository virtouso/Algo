namespace Algorithms.Problems
{
    public class LongestPalindromicSubstring
    {
        // other algorithm palindromic substrings
        
        public string LongestPalindrome(string s)
        {
            string result = "";
            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {

                // for odds length
                var l = i;
                var r = i;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if (r - l + 1 > res)
                    {
                        result = s.Substring(l, r - l + 1);
                        res = r - l + 1;
                    }

                    l--;
                    r++;
                }

                l = i;
                r = i + 1;

                while (l >= 0 && r < s.Length && s[r] == s[l])
                {
                    if (r - l + 1 > res)
                    {
                        result = s.Substring(l, r - l + 1);
                        res = r - l + 1;
                    }
                    l--;
                    r++;
                }

                
            }

            return result;
        }
    }
}