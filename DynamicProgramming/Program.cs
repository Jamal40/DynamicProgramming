using DynamicProgramming;

#region Testing 

#region Fib

Console.WriteLine("----------Fib-----------");
Console.WriteLine(Problems.FibSumRecursiveClassic(8));
Console.WriteLine(Problems.FibRecursiveClassic(8));
Console.WriteLine(Problems.FibRecursiveClassic(50));
Console.WriteLine(Problems.FibRecursive(50));

#endregion

#region Grid Traveler

Console.WriteLine("---------Grid Traveler---------");
Console.WriteLine(Problems.GetAllPathsToTravelGrid(40, 40));
Console.WriteLine(Problems.GetAllPathsToTravelGrid(3, 3));
Console.WriteLine(Problems.GetAllPathsToTravelGrid(18, 18));
Console.WriteLine(Problems.GetAllPathsToTravelGrid(2, 1));
Console.WriteLine(Problems.GetAllPathsToTravelGrid(1, 2));

#endregion

#region CanSum

Console.WriteLine(Problems.CanSum(7, new int[] { 4, 2 })); // false
Console.WriteLine(Problems.CanSum(7, new int[] { 3, 2 })); // true
Console.WriteLine(Problems.CanSum(7, new int[] { 5, 4, 3, 2 })); // true
Console.WriteLine(Problems.CanSum(8, new int[] { 2, 5, 3 })); // true
Console.WriteLine(Problems.CanSum(5000, new int[] { 7, 14 })); // false

#endregion

#region HowSum

PrintCollection(Problems.HowSum2(7, new int[] { 4, 2 }));
PrintCollection(Problems.HowSum2(7, new int[] { 3, 2 }));
PrintCollection(Problems.HowSum2(7, new int[] { 5, 4, 3, 2 }));
PrintCollection(Problems.HowSum2(8, new int[] { 2, 5, 3 }));
PrintCollection(Problems.HowSum2(300, new int[] { 7, 14 }));

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