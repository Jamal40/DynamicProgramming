namespace DynamicProgramming;

public class TabulationProblems
{
    #region Fib

    public static long Fib(long n)
    {
        var table = new long[n + 1];
        table[1] = 1;
        for (long i = 0; i < n; i++)
        {
            table[i + 1] += table[i];
            if (i < n - 1)
                table[i + 2] += table[i];
        }
        return table[n];
    }

    #endregion
}

