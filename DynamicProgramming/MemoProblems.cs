namespace DynamicProgramming;
public static class MemoProblems
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
            var currentList = CreateList(BestSum(newSum, numbers, memo));
            if (currentList is not null)
            {
                currentList.Add(numbers[i]);
                resultSum.Add(currentList);
            }
        }

        memo[sum] = resultSum.Any() ? GetShortestList(resultSum) : null;
        return memo[sum];
    }

    #endregion

    #region CanConstruct

    public static bool CanConstruct(string target, string[] wordBank, Dictionary<string, bool> memo = null)
    {
        memo ??= new();

        if (memo.ContainsKey(target))
            return memo[target];

        if (string.IsNullOrWhiteSpace(target))
            return true;

        for (int i = 0; i < wordBank.Length; i++)
        {
            if (!CheckPrefix(target, wordBank[i]))
                continue;

            var newTarget = RemovePrefix(target, wordBank[i]);
            if (CanConstruct(newTarget, wordBank, memo))
            {
                memo[target] = true;
                return memo[target];
            }

        }

        memo[target] = false;
        return memo[target];
    }

    #endregion

    #region CountConstruct

    public static int CountConstruct(string target, string[] wordBank, Dictionary<string, int> memo = null)
    {
        memo ??= new();

        if (memo.ContainsKey(target))
            return memo[target];

        if (string.IsNullOrWhiteSpace(target))
            return 1;

        int counter = 0;
        for (int i = 0; i < wordBank.Length; i++)
        {
            if (!CheckPrefix(target, wordBank[i]))
                continue;

            string newTarget = RemovePrefix(target, wordBank[i]);
            memo[target] = CountConstruct(newTarget, wordBank, memo);
            counter += memo[target];
        }

        memo[target] = counter;
        return memo[target];
    }

    #endregion

    #region AllConstruct
    public static List<List<string>> AllConstruct(string target, string[] wordBank, Dictionary<string, List<List<string>>> memo = null)
    {
        memo ??= new();

        if (memo.ContainsKey(target))
            return memo[target];

        if (string.IsNullOrWhiteSpace(target))
            return new List<List<string>> { new List<string>() };

        List<List<string>> result = new();
        for (int i = 0; i < wordBank.Length; i++)
        {
            if (!CheckPrefix(target, wordBank[i]))
                continue;
            var newTarget = RemovePrefix(target, wordBank[i]);
            var currentResult = AllConstruct(newTarget, wordBank, memo).Select(l => l.ToList()).ToList();
            currentResult.ForEach(list => list.Add(wordBank[i]));
            result.AddRange(currentResult);
        }
        memo[target] = result;
        return result;
    }
    #endregion

    #region Trib

    public static int Trib(int n, Dictionary<int, int> memo = null)
    {
        memo ??= new();
        if (memo.ContainsKey(n))
            return memo[n];

        if (n == 0 || n == 1)
            return 0;
        if (n == 2)
            return 1;

        memo[n] = Trib(n - 1, memo) + Trib(n - 2, memo) + Trib(n - 3, memo);
        return memo[n];
    }

    #endregion

    #region MaxNonAjdacentSum

    public static int MaxNonAjdacentSum(List<int> numbers, int i = 0, Dictionary<int, int> memo = null)
    {
        memo ??= new();

        if (memo.ContainsKey(i))
            return memo[i];

        if (i >= numbers.Count)
            return 0;
        var num1 = numbers[i] + MaxNonAjdacentSum(numbers, i + 2, memo);
        var num2 = MaxNonAjdacentSum(numbers, i + 1, memo);

        memo[i] = Math.Max(num1, num2);
        return memo[i];
    }

    #endregion

    #region SummingSquares

    public static int SummingSquares(int n, Dictionary<int, int> memo = null)
    {
        var squares = GeneratePerfectSquares(n);
        memo ??= new();

        if (memo.ContainsKey(n))
            return memo[n];
        if (n == 0)
            return 0;

        int shortest = n;
        foreach (var square in squares)
        {
            var current = 1 + SummingSquares(n - square, memo);
            shortest = current < shortest ? current : shortest;
        }

        memo[n] = shortest;
        return memo[n];
    }

    #endregion

    #region ArrayStepper

    public static bool ArrayStepper(int[] numbers, int index = 0, HashSet<int> memo = null)
    {
        memo ??= new();

        if (memo.Contains(index))
            return false;
        if (index >= numbers.Length - 1)
            return true;
        if (numbers[index] == 0)
            return false;

        for (int j = 1; j <= numbers[index]; j++)
        {
            if (ArrayStepper(numbers, index + j, memo))
                return true;
        }

        memo.Add(index);
        return false;
    }

    #endregion

    #region LongestPalin

    public static int GetLongestPalin(string str, int start = 0, int end = -2,
        Dictionary<(int start, int end), int> memo = null)
    {
        memo ??= new();

        end = end == -2 ? str.Length - 1 : end;

        if (memo.ContainsKey((start, end)))
            return memo[(start, end)];
        if (end-start < 0 || start>=str.Length)
            return 0;
        if (end == start)
            return 1;

        if (str[start] == str[end])
        {
            memo[(start, end)] = 2 + GetLongestPalin(str, start + 1, end - 1, memo);
            return memo[(start, end)];
        }


        memo[(start, end)] = Math.Max(GetLongestPalin(str, start + 1, end, memo),
            GetLongestPalin(str, start, end - 1, memo));
        return memo[(start, end)];
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

    private static string RemovePrefix(string word, string prefix)
    {
        if (!CheckPrefix(word, prefix))
            return word;
        return word.Substring(prefix.Length);
    }

    private static bool CheckPrefix(string word, string prefix)
    {
        for (int i = 0; i < prefix.Length; i++)
        {
            if (prefix[i] != word[i])
                return false;
        }
        return true;
    }

    private static List<int> GeneratePerfectSquares(int n)
    {
        var result = new List<int>();
        var num = 1;
        while (num * num <= n)
        {
            result.Add(num * num);
            num++;
        }
        return result;
    }

    #endregion
}

