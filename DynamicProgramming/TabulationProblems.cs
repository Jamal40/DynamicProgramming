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
            if (table[i])
            {
                foreach (var number in numbers)
                {
                    if (number + i < table.Length)
                        table[number + i] = true;
                }
            }
        }
        return table[sum];
    }

    #endregion

    #region HowSum

    public static List<int> HowSum(int sum, int[] numbers)
    {
        var table = new List<int>[sum + 1];
        table[0] = new();

        for (int i = 0; i < table.Length; i++)
        {
            if (table[i] is not null)
            {
                foreach (var number in numbers)
                {
                    if (number + i >= table.Length || table[number + i] is not null)
                        continue;

                    table[number + i] = new(table[i]) { number };
                }
            }
        }

        return table[sum];
    }

    #endregion

    #region BestSum

    public static List<int> BestSum(int sum, int[] numbers)
    {
        var table = new List<int>[sum + 1];
        table[0] = new List<int>();

        for (int i = 0; i < table.Length; i++)
        {
            if (table[i] is not null)
            {
                foreach (var number in numbers)
                {
                    if (number + i >= table.Length)
                        continue;

                    if (table[number + i] is null)
                    {
                        table[number + i] = new List<int>(table[i]) { number };
                        continue;
                    }

                    table[number + i] = table[number + i].Count < table[i].Count + 1 ?
                        table[number + i] :
                        new(table[i]) { number };
                }
            }
        }

        return table[sum];
    }

    #endregion

    #region CanConstruct

    public static bool CanConstruct(string target, string[] wordBank)
    {
        var table = new bool[target.Length + 1];
        table[0] = true;

        for (int i = 0; i < table.Length; i++)
        {
            if (table[i])
            {
                foreach (var word in wordBank)
                {
                    var newTarget = target.Substring(i);
                    if (CheckPrefix(newTarget, word))
                        table[i + word.Length] = true;
                }
            }
        }

        return table[target.Length];
    }

    #endregion

    #region CountConstruct

    public static int CountConstruct(string target, string[] wordBank)
    {
        var table = new int[target.Length + 1];
        table[0] = 1;

        for (int i = 0; i < table.Length; i++)
        {
            if (table[i] > 0)
            {
                foreach (var word in wordBank)
                {
                    var newTarget = target.Substring(i);
                    if (CheckPrefix(newTarget, word))
                    {
                        table[i + word.Length] += table[i];
                    }
                }
            }
        }

        return table[target.Length];
    }

    #endregion

    #region AllConstruct

    public static List<List<string>> AllConstruct(string target, string[] wordBank)
    {
        var table = new List<List<string>>[target.Length + 1];
        table[0] = new List<List<string>>() { new List<string>() };

        for (int i = 0; i < table.Length; i++)
        {
            if (table[i] is not null)
            {
                foreach (var word in wordBank)
                {
                    var newTarget = target.Substring(i);
                    if (CheckPrefix(newTarget, word))
                    {
                        var newList = table[i].Select(l => l.ToList()).ToList();
                        newList.ForEach(l => l.Add(word));
                        if (table[i + word.Length] is null)
                        {
                            table[i + word.Length] = newList;
                            continue;
                        }

                        table[i + word.Length].AddRange(newList);
                    }
                }
            }
        }

        return table[target.Length];
    }

    #endregion

    #region Trib

    public static int Trib(int n)
    {
        var table = new int[n + 1];
        table[2] = 1;
        for (int i = 2; i < table.Length; i++)
        {
            table[i] = table[i - 1] + table[i - 2] + table[i - 3];
        }
        return table[n];
    }

    #endregion

    #region MaxNonAjdacentSum

    public static int MaxNonAjdacentSum(List<int> numbers)
    {
        if (numbers.Count == 0)
            return 0;
        if (numbers.Count == 1)
            return numbers[0];

        var table = new int[numbers.Count];
        table[0] = numbers[0];
        table[1] = numbers[1];

        for (int i = 1; i < table.Length; i++)
        {
            var prev_prev = table[i - 2];
            var prev = table[i - 1];

            table[i] = Math.Max(prev_prev + numbers[i], prev);
        }

        return table[table.Length - 1];
    }

    #endregion

    #region Helpers

    private static bool CheckPrefix(string word, string prefix)
    {
        if (prefix.Length > word.Length)
            return false;

        for (int i = 0; i < prefix.Length; i++)
        {
            if (prefix[i] != word[i])
                return false;
        }
        return true;
    }

    #endregion
}

