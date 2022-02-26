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

#region Trib

Console.WriteLine("--------Trib-------");
Console.WriteLine(MemoProblems.Trib(5));

#endregion

#region MaxNonAdjacent

Console.WriteLine("-----------Max Non Ajdacent Sum-------------");
Console.WriteLine(MemoProblems.MaxNonAjdacentSum(new List<int> { 12 }));
Console.WriteLine(MemoProblems.MaxNonAjdacentSum(new List<int> { 12, 7 }));
Console.WriteLine(MemoProblems.MaxNonAjdacentSum(new List<int> { 2, 4, 5, 12, 7 }));
Console.WriteLine(MemoProblems.MaxNonAjdacentSum(new List<int> {
  72, 62, 10,  6, 20, 19, 42, 46, 24, 78,
  30, 41, 75, 38, 23, 28, 66, 55, 12, 17,
  83, 80, 56, 68,  6, 22, 56, 96, 77, 98,
  61, 20,  0, 76, 53, 74,  8, 22, 92, 37,
  30, 41, 75, 38, 23, 28, 66, 55, 12, 17,
  72, 62, 10,  6, 20, 19, 42, 46, 24, 78,
  42 }));

#endregion

#region SummingSquares

Console.WriteLine("----------------Summing Squares---------------");
Console.WriteLine(MemoProblems.SummingSquares(3));
Console.WriteLine(MemoProblems.SummingSquares(8));
Console.WriteLine(MemoProblems.SummingSquares(9));
Console.WriteLine(MemoProblems.SummingSquares(12));
Console.WriteLine(MemoProblems.SummingSquares(1));
Console.WriteLine(MemoProblems.SummingSquares(31));
Console.WriteLine(MemoProblems.SummingSquares(50));
Console.WriteLine(MemoProblems.SummingSquares(68));
Console.WriteLine(MemoProblems.SummingSquares(87));

#endregion

#region ArrayStepper 

Console.WriteLine("-----------Array Stepper-----------");
Console.WriteLine(MemoProblems.ArrayStepper(new int[] { 2, 4, 2, 0, 0, 1 }));
Console.WriteLine(MemoProblems.ArrayStepper(new int[] { 2, 3, 2, 0, 0, 1 }));
Console.WriteLine(MemoProblems.ArrayStepper(new int[] { 3, 1, 3, 1, 0, 1 }));
Console.WriteLine(MemoProblems.ArrayStepper(new int[] { 4, 1, 5, 1, 1, 1, 0, 4 }));
Console.WriteLine(MemoProblems.ArrayStepper(new int[] { 4, 1, 2, 1, 1, 1, 0, 4 }));
Console.WriteLine(MemoProblems.ArrayStepper(new int[] { 1, 1, 1, 1, 1, 0 }));
Console.WriteLine(MemoProblems.ArrayStepper(new int[] { 1, 1, 1, 1, 0, 0 }));
Console.WriteLine(MemoProblems.ArrayStepper(new int[] {   31, 30, 29, 28, 27,
  26, 25, 24, 23, 22,
  21, 20, 19, 18, 17,
  16, 15, 14, 13, 12,
  11, 10, 9, 8, 7, 6,
  5, 3, 2, 1, 0, 0, 0 }));

#endregion

#region LongestPalin

Console.WriteLine("-------------Longest Palin------------");
Console.WriteLine(MemoProblems.GetLongestPalin("bb")); //2
Console.WriteLine(MemoProblems.GetLongestPalin("lul")); //3
Console.WriteLine(MemoProblems.GetLongestPalin("luwxult")); //5
Console.WriteLine(MemoProblems.GetLongestPalin("xyzaxxzy")); //6
Console.WriteLine(MemoProblems.GetLongestPalin("lol")); //3
Console.WriteLine(MemoProblems.GetLongestPalin("boabcdefop")); //3
Console.WriteLine(MemoProblems.GetLongestPalin("z")); //1
Console.WriteLine(MemoProblems.GetLongestPalin("chartreusepugvicefree")); //7
Console.WriteLine(MemoProblems.GetLongestPalin("qwueoiuahsdjnweuueueunasdnmnqweuzqwerty")); //15
Console.WriteLine(MemoProblems.GetLongestPalin("enamelpinportlandtildecoldpressedironyflannelsemioticsedisonbulbfashionaxe")); //31

#endregion

#endregion

#region Tabulation

Console.WriteLine("Tabulation Starts");

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

#region BestSum

Console.WriteLine("------------Best Sum Tabulation-----------");
PrintCollection(TabulationProblems.BestSum(7, new int[] { 5, 3, 4, 7 })); // 7
PrintCollection(TabulationProblems.BestSum(8, new int[] { 5, 3, 2 })); // 3,5
PrintCollection(TabulationProblems.BestSum(8, new int[] { 1, 4, 5 })); //4, 4
PrintCollection(TabulationProblems.BestSum(100, new int[] { 1, 2, 5, 25 }));

#endregion

#region CanConstruct

Console.WriteLine(TabulationProblems.CanConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })); //true
Console.WriteLine(TabulationProblems.CanConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); //false
Console.WriteLine(TabulationProblems.CanConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); //true
Console.WriteLine(TabulationProblems.CanConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })); //false

#endregion

#region CountConstruct

Console.WriteLine(TabulationProblems.CountConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })); //1
Console.WriteLine(TabulationProblems.CountConstruct("cool", new string[] { "co", "o", "c", "l" })); //1
Console.WriteLine(TabulationProblems.CountConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); //0
Console.WriteLine(TabulationProblems.CountConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); //4
Console.WriteLine(TabulationProblems.CountConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" })); //2
Console.WriteLine(TabulationProblems.CountConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" })); //0

#endregion

#region AllConstruct

// Test by watching in debug mode.
var ta1 = TabulationProblems.AllConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }); //1
var ta2 = TabulationProblems.AllConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }); //0
var ta3 = TabulationProblems.AllConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }); //4
var ta4 = TabulationProblems.AllConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" }); //2
//var ta5 = TabulationProblems.AllConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }); //0

#endregion

#region Trib

Console.WriteLine("--------Trib-------");
Console.WriteLine(MemoProblems.Trib(5));

#endregion

#region MaxNonAdjacent

Console.WriteLine("-----------Max Non Ajdacent Sum-------------");
Console.WriteLine(TabulationProblems.MaxNonAjdacentSum(new List<int> { 12 }));
Console.WriteLine(TabulationProblems.MaxNonAjdacentSum(new List<int> { 12, 7 }));
Console.WriteLine(TabulationProblems.MaxNonAjdacentSum(new List<int> { 2, 4, 5, 12, 7 }));
Console.WriteLine(TabulationProblems.MaxNonAjdacentSum(new List<int> {
  72, 62, 10,  6, 20, 19, 42, 46, 24, 78,
  30, 41, 75, 38, 23, 28, 66, 55, 12, 17,
  83, 80, 56, 68,  6, 22, 56, 96, 77, 98,
  61, 20,  0, 76, 53, 74,  8, 22, 92, 37,
  30, 41, 75, 38, 23, 28, 66, 55, 12, 17,
  72, 62, 10,  6, 20, 19, 42, 46, 24, 78,
  42 }));

#endregion

#region SummingSquares

Console.WriteLine("----------------Summing Squares---------------");
Console.WriteLine(TabulationProblems.SummingSquares(3));
Console.WriteLine(TabulationProblems.SummingSquares(8));
Console.WriteLine(TabulationProblems.SummingSquares(9));
Console.WriteLine(TabulationProblems.SummingSquares(12));
Console.WriteLine(TabulationProblems.SummingSquares(1));
Console.WriteLine(TabulationProblems.SummingSquares(31));
Console.WriteLine(TabulationProblems.SummingSquares(50));
Console.WriteLine(TabulationProblems.SummingSquares(68));
Console.WriteLine(TabulationProblems.SummingSquares(87));

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