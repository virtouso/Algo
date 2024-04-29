namespace Algorithms.Problems
{
    public class ValidMountainArray
    {
        public  bool IsValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
                return false;

            int i = 0;

            // Ascend to the peak
            while (i < arr.Length - 1 && arr[i] < arr[i + 1])
                i++;

            // Peak can't be the first or last element
            if (i == 0 || i == arr.Length - 1)
                return false;

            // Descend from the peak
            while (i < arr.Length - 1 && arr[i] > arr[i + 1])
                i++;

            return i == arr.Length - 1;
        }

    }
}