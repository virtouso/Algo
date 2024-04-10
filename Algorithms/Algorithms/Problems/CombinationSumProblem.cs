using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class CombinationSumProblem
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            //Array.Sort(candidates); // to avoid duplicates. you can remove to test
            GenerateCombination(0,candidates, target, new List<int>(), result);

            return result;
        }


        private void GenerateCombination(int start, int[] candidates, int target, List<int> current, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                var element = candidates[i];
                if (element > target) continue;
                current.Add(element);
                GenerateCombination(i,candidates, target - element, new List<int>(current), result);
                     current.RemoveAt(current.Count - 1);
            }
        }


        public void Run()
        {
            int[] data = new[] { 2, 7, 6, 3 };
            int target = 7;

            var result = CombinationSum(data, target);
        }
    }
}