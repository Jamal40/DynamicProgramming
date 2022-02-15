namespace DynamicProgramming;
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
            memo[newSum] = CanSum(newSum, numbers, memo);
            if (memo[newSum])
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
            memo[newSum] = HowSumHelper(newSum, numbers, result, memo);
            if (memo[newSum])
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
            return new List<int> ();
        if (sum < 0)
            return null;

        for (int i = 0; i < numbers.Length; i++)
        {
            int newSum = sum - numbers[i];
            memo[newSum] = HowSum2(newSum, numbers, memo);
            if (memo[newSum] is not null)
            {
                memo[newSum].Add(numbers[i]);
                return memo[newSum];
            }
        }

        return null;
    }

    #endregion
}

