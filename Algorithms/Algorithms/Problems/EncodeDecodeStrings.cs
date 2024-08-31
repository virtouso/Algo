using System.Collections.Generic;
using System.Text;

namespace Algorithms.Problems
{


    public class EncodeDecodeStrings
    {

        private const char Delimiter = '#'; // Delimiter to separate length and string

        // Encodes a list of strings to a single string

        public string encode(IList<string> strs)
        {
            var sb = new StringBuilder();
            foreach (var str in strs)
            {
                sb.Append(str.Length).Append(Delimiter).Append(str);
            }

            return sb.ToString();
        }

        // Decodes a single string to a list of strings
        public IList<string> decode(string s)
        {
            var result = new List<string>();
            int i = 0;

            while (i < s.Length)
            {
                // Find the delimiter
                int delimiterIndex = s.IndexOf(Delimiter, i);

                // Get the length of the next string
                int length = int.Parse(s.Substring(i, delimiterIndex - i));

                // Move past the delimiter
                i = delimiterIndex + 1;

                // Extract the string of the given length
                string str = s.Substring(i, length);
                result.Add(str);

                // Move the index to the next part
                i += length;
            }

            return result;
        }
    }
}