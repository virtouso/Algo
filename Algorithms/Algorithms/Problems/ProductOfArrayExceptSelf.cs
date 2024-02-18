namespace Algorithms.Problems
{
    public class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var inorder = new int[nums.Length];
            var prev = new int[nums.Length];

            int inMul = 1;
            int prevMul = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                inorder[i] = inMul * nums[i];
                inMul *= nums[i];

                prev[nums.Length - 1 - i] = prevMul * nums[nums.Length - 1 - i];
                prevMul *= nums[nums.Length - 1 - i];

            }

            var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                    result[i] = prev[i + 1];
                else if (i == nums.Length - 1)
                    result[i] = inorder[i - 1];
                else
                    result[i] = inorder[i - 1] * prev[i + 1];

            }

            return result;
        }
    }
}