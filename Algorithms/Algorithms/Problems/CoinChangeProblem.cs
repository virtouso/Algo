using System;

namespace Algorithms.Problems
{
    public class CoinChangeProblem
    {
        // You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.
      //  Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.
        public int CoinChange(int[] coins, int amount)
        {
            int[] neededCoins = new int[amount + 1];
            for (int i = 0; i < neededCoins.Length; i++)
            {
                neededCoins[i] = amount + 1; 
            }

            neededCoins[0] = 0;

            for (int currentAmount = 1; currentAmount <= amount; currentAmount++)
            {
                foreach (int coin in coins)
                {
                    if (coin <= currentAmount)
                    {
                        neededCoins[currentAmount] = Math.Min(neededCoins[currentAmount], neededCoins[currentAmount - coin] + 1);
                    }
                }
            }

            return neededCoins[amount] > amount ? -1 : neededCoins[amount];
        }
    }
}