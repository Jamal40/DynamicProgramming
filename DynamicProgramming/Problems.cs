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

        if (rows == 0 || columns == 0)
            return 0;
        if (rows == 1 && columns == 1)
            return 1;

        memo[(rows, columns)] = GetAllPathsToTravelGrid(rows - 1, columns, memo) + GetAllPathsToTravelGrid(rows, columns - 1, memo);
        return memo[(rows, columns)];
    }

    #endregion
}

