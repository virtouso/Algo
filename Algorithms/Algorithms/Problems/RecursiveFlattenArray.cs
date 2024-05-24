using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class RecursiveFlattenArray
    {
        public List<object> MakeFlat(List<object> input)
        {
            var result = new List<object>(2);
            Recurs(input, result);

            return result;
        }


        public void Recurs(List<object> input, List<object> res)
        {
            if (input == null) return;

            foreach (var item in input)
            {
                if (item is int castInt)
                {
                    res.Add(castInt);
                }
                else if (item is List<object> castList)
                {
                    Recurs(castList, res);
                }
            }
        }
    }
}