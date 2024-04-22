namespace Algorithms.Problems
{
    public class CheckIsPrime
    {
        public static bool IsPrime(int number)
        {
            // If the number is less than 2, it's not prime
            if (number < 2)
                return false;

            // Check divisibility by numbers up to the square root of the number
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false; // Number is divisible by i, so it's not prime
            }

            return true; // Number is not divisible by any smaller number, so it's prime
        }
    }
}