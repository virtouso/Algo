using System.Text;

namespace Algorithms.Problems
{
    public class CompressStringProblem
    {
        public string CompressString(string input)
        {
            int count = 1;

            StringBuilder compressed = new StringBuilder();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    compressed.Append(input[i - 1]).Append(count);
                    count = 1;
                }
            }

            compressed.Append(input[input.Length-2]).Append(count);

            return compressed.ToString();
        }
    }
}