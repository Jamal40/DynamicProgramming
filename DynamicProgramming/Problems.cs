﻿namespace DynamicProgramming;
public static class Problems
{
    #region Fib

    #region classic

    public static int FibSumRecursiveClassic(int n, int prev = 0, int secondPrev = 1, int count = 1)
    {
        if (count == n)
            return prev + secondPrev;
        var res = prev + secondPrev;
        return res + FibSumRecursiveClassic(n, res, prev, count + 1);
    }

    public static long FibRecursiveClassic(long n, long prev = 0, long secondPrev = 1, long count = 1)
    {
        if (count == n)
            return prev + secondPrev;
        var res = prev + secondPrev;
        return FibRecursiveClassic(n, res, prev, count + 1);
    }

    #endregion

    #region DP

    public static long FibRecursive(long n, Dictionary<long, long> memo = null)
    {
        memo ??= new();

        if (memo.ContainsKey(n))
            return memo[n];

        if (n <= 2)
            return 1;

        memo[n] = FibRecursive(n - 1, memo) + FibRecursive(n - 2, memo);
        return memo[n];
    }

    #endregion

    #endregion

    #region GridTraveler

    public static long GetAllPathsToTravelGrid(int rows, int columns, Dictionary<(int r, int c), long> memo = null)
    {
        memo ??= new();

        if (memo.ContainsKey((rows, columns)))
            return memo[(rows, columns)];
        if (memo.ContainsKey((columns, rows)))
            return memo[(columns, rows)];

        if (rows == 0 || columns == 0)
            return 0;
        if (rows == 1 && columns == 1)
            return 1;

        memo[(rows, columns)] = GetAllPathsToTravelGrid(rows - 1, columns, memo) + GetAllPathsToTravelGrid(rows, columns - 1, memo);
        return memo[(rows, columns)];
    }

    #endregion

    #region CanSum

    public static bool CanSum(int sum, int[] numbers, Dictionary<int, bool> memo = null)
    {
        memo ??= new();

        if (memo.ContainsKey(sum))
            return memo[sum];
        if (sum == 0)
            return true;
        if (sum < 0)
            return false;

        for (int i = 0; i < numbers.Length; i++)
        {
            var newSum = sum - numbers[i];
            memo[sum] = CanSum(newSum, numbers, memo);
            if (memo[sum])
                return true;
        }
        return false;
    }

    #endregion

    #region HowSum

    public static List<int> HowSum(int sum, int[] numbers)
    {
        var result = new List<int>();
        HowSumHelper(sum, numbers, result);
        return result;
    }

    private static bool HowSumHelper(int sum, int[] numbers, List<int> result, Dictionary<int, bool> memo = null)
    {
        memo ??= new();

        if (memo.ContainsKey(sum))
            return memo[sum];
        if (sum == 0)
            return true;
        if (sum < 0)
            return false;

        for (int i = 0; i < numbers.Length; i++)
        {
            int newSum = sum - numbers[i];
            memo[sum] = HowSumHelper(newSum, numbers, result, memo);
            if (memo[sum])
            {
                result.Add(numbers[i]);
                return true;
            }
        }

        return false;
    }
    public static List<int> HowSum2(int sum, int[] numbers, Dictionary<int, List<int>> memo = null)
    {
        memo ??= new();

        if (memo.ContainsKey(sum))
            return memo[sum];
        if (sum == 0)
            return new List<int>();
        if (sum < 0)
            return null;

        for (int i = 0; i < numbers.Length; i++)
        {
            int newSum = sum - numbers[i];
            memo[sum] = CreateList(HowSum2(newSum, numbers, memo));
            if (memo[sum] is not null)
            {
                memo[sum].Add(numbers[i]);
                return memo[sum];
            }
        }

        return null;
    }

    #endregion

    #region BestSum

    public static List<int> BestSum(int sum, int[] numbers, Dictionary<int, List<int>> memo = null)
    {
        memo ??= new();

        if (memo.ContainsKey(sum))
            return memo[sum];
        if (sum == 0)
            return new List<int>();
        if (sum < 0)
            return null;
        var resultSum = new List<List<int>>();
        for (int i = 0; i < numbers.Length; i++)
        {
            int newSum = sum - numbers[i];
            memo[sum] = CreateList(BestSum(newSum, numbers, memo));
            if (memo[sum] is not null)
            {
                memo[sum].Add(numbers[i]);
                resultSum.Add(memo[sum]);
            }
        }

        return resultSum.Any() ? GetShortestList(resultSum) : null;
    }

    #endregion

    #region Helpers

    private static List<int> CreateList(List<int> list)
    {
        if (list is not null)
            return new List<int>(list);
        return list;
    }

    private static List<int> GetShortestList(List<List<int>> allLists)
    {
        var shortestList = allLists[0];

        foreach (var list in allLists)
        {
            shortestList = list.Count < shortestList.Count ? list : shortestList;
        }

        return shortestList;

    }
    #endregion
}

