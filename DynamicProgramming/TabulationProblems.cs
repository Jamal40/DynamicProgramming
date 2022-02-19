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

    #region GridTraveler

    public static long GetAllPathsToTravelGrid(int rows, int columns)
    {
        var table = new long[rows + 1, columns + 1];
        table[1, 1] = 1;

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                if (i < table.GetLength(0) - 1)
                    table[i + 1, j] += table[i, j];
                if (j < table.GetLength(1) - 1)
                    table[i, j + 1] += table[i, j];
            }
        }

        return table[rows, columns];
    }

    #endregion

    #region CanSum

    public static bool CanSum(int sum, int[] numbers)
    {
        var table = new bool[sum + 1];
        table[0] = true;



        for (int i = 0; i < table.Length; i++)
        {
            foreach (var number in numbers)
            {
                if (table[i] && number + i < table.Length)
                    table[number + i] = true;
            }
        }

        return table[sum];
    }

    #endregion
}

