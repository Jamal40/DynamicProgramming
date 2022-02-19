using DynamicProgramming;

#region Testing 

#region Memoization

#region Fib

Console.WriteLine("----------Fib-----------");
Console.WriteLine(MemoProblems.FibSumRecursiveClassic(8));
Console.WriteLine(MemoProblems.FibRecursiveClassic(8));
Console.WriteLine(MemoProblems.FibRecursiveClassic(50));
Console.WriteLine(MemoProblems.FibRecursive(50));

#endregion

#region Grid Traveler

Console.WriteLine("---------Grid Traveler---------");
Console.WriteLine(MemoProblems.GetAllPathsToTravelGrid(40, 40));
Console.WriteLine(MemoProblems.GetAllPathsToTravelGrid(3, 3));
Console.WriteLine(MemoProblems.GetAllPathsToTravelGrid(18, 18));
Console.WriteLine(MemoProblems.GetAllPathsToTravelGrid(2, 1));
Console.WriteLine(MemoProblems.GetAllPathsToTravelGrid(1, 2));

#endregion

#region CanSum

Console.WriteLine(MemoProblems.CanSum(7, new int[] { 4, 2 })); // false
Console.WriteLine(MemoProblems.CanSum(7, new int[] { 3, 2 })); // true
Console.WriteLine(MemoProblems.CanSum(7, new int[] { 5, 4, 3, 2 })); // true
Console.WriteLine(MemoProblems.CanSum(8, new int[] { 2, 5, 3 })); // true
Console.WriteLine(MemoProblems.CanSum(5000, new int[] { 7, 14 })); // false

#endregion

#region HowSum

PrintCollection(MemoProblems.HowSum2(7, new int[] { 4, 2 }));
PrintCollection(MemoProblems.HowSum2(7, new int[] { 3, 2 }));
PrintCollection(MemoProblems.HowSum2(7, new int[] { 5, 4, 3, 2 }));
PrintCollection(MemoProblems.HowSum2(8, new int[] { 2, 5, 3 }));
PrintCollection(MemoProblems.HowSum2(300, new int[] { 7, 14 }));

#endregion

#region BestSum

PrintCollection(MemoProblems.BestSum(7, new int[] { 5, 3, 4, 7 })); // 7
PrintCollection(MemoProblems.BestSum(8, new int[] { 5, 3, 2 })); // 3,5
PrintCollection(MemoProblems.BestSum(8, new int[] { 1, 4, 5 })); //4, 4
PrintCollection(MemoProblems.BestSum(100, new int[] { 1, 2, 5, 25 }));

#endregion

#region CanConstruct

Console.WriteLine(MemoProblems.CanConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })); //true
Console.WriteLine(MemoProblems.CanConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); //false
Console.WriteLine(MemoProblems.CanConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); //true
Console.WriteLine(MemoProblems.CanConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })); //false

#endregion

#region CountConstruct

Console.WriteLine(MemoProblems.CountConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })); //1
Console.WriteLine(MemoProblems.CountConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); //0
Console.WriteLine(MemoProblems.CountConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); //4
Console.WriteLine(MemoProblems.CountConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" })); //2
Console.WriteLine(MemoProblems.CountConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })); //0

#endregion

#region AllConstruct

// Test by watching in debug mode.
var t1 = MemoProblems.AllConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }); //1
var t2 = MemoProblems.AllConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }); //0
var t3 = MemoProblems.AllConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }); //4
var t4 = MemoProblems.AllConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" }); //2
var t5 = MemoProblems.AllConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }); //0

#endregion

#endregion

#region Tabulation

#region Fib

Console.WriteLine(TabulationProblems.Fib(6));
Console.WriteLine(TabulationProblems.Fib(7));
Console.WriteLine(TabulationProblems.Fib(50));

#endregion

#region Grid Traveler

Console.WriteLine("---------Grid Traveler---------");
Console.WriteLine(TabulationProblems.GetAllPathsToTravelGrid(40, 40));
Console.WriteLine(TabulationProblems.GetAllPathsToTravelGrid(3, 3));
Console.WriteLine(TabulationProblems.GetAllPathsToTravelGrid(18, 18));
Console.WriteLine(TabulationProblems.GetAllPathsToTravelGrid(2, 1));
Console.WriteLine(TabulationProblems.GetAllPathsToTravelGrid(1, 2));
Console.WriteLine(TabulationProblems.GetAllPathsToTravelGrid(2, 3));
Console.WriteLine(TabulationProblems.GetAllPathsToTravelGrid(3, 2));

#endregion

#region CanSum

Console.WriteLine("----------CanSum Tabulation-----------");
Console.WriteLine(TabulationProblems.CanSum(7, new int[] { 4, 2 })); // false
Console.WriteLine(TabulationProblems.CanSum(7, new int[] { 3, 2 })); // true
Console.WriteLine(TabulationProblems.CanSum(7, new int[] { 5, 4, 3, 2 })); // true
Console.WriteLine(TabulationProblems.CanSum(8, new int[] { 2, 5, 3 })); // true
Console.WriteLine(TabulationProblems.CanSum(5000, new int[] { 7, 14 })); // false

#endregion

#region HowSum

Console.WriteLine("-------------HowSum Tabulation--------------");
PrintCollection(TabulationProblems.HowSum(7, new int[] { 4, 2 }));
PrintCollection(TabulationProblems.HowSum(7, new int[] { 3, 2 }));
PrintCollection(TabulationProblems.HowSum(7, new int[] { 5, 4, 3, 2 }));
PrintCollection(TabulationProblems.HowSum(8, new int[] { 2, 5, 3 }));
PrintCollection(TabulationProblems.HowSum(300, new int[] { 7, 14 }));

#endregion

#endregion

#endregion

#region Helpers

void PrintCollection<T>(ICollection<T> collection, string text = "")
{
    if (collection is null || !collection.Any())
        return;
    Console.WriteLine($"------------Start_{text}-----------");
    foreach (var item in collection)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine($"------------End_{text}-----------");
}

#endregion