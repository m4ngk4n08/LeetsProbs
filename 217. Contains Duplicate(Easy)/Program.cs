


var tests = ContainsDuplicate(new int[] { 1, 2, 3, 4 });
Console.WriteLine();

bool ContainsDuplicate(int[] nums)
{
    return nums.GroupBy(j => j).Where(j => j.Count() >= 2).Select(j => j.Key).ToList().Any();
}