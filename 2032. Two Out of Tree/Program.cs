



var test = TwoOutOfThree(new int[] { 1,1,3,2 }, new int[] { 2,3 }, new int[] { 1,3,5 }, new int[] { 5, 5 });

Console.WriteLine();

IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
{
    var distinctNums1 = nums1.Distinct().ToList();
    var distinctNums2 = nums2.Distinct().ToList();
    var distinctNums3 = nums3.Distinct().ToList();
    var distinctNums4 = nums3.Distinct().ToList();

    var newList = new List<List<int>>() { distinctNums1, distinctNums2, distinctNums3, distinctNums4 };
    var newDict = new Dictionary<int, int>();
    for (int i = 0; i < newList.Count; i++)
    {
        for (int j = 0; j < newList[i].Count; j++)
        {
            var key = newList[i][j];
            Console.Write(key);
            if (newDict.ContainsKey(key))
            {
                newDict[key]++;
            }
            else
            {
                newDict[key] = 1;
            }
        }
        Console.WriteLine();
    }

    return newDict.Where(j => j.Value >= 2).Select(j => j.Key).ToList();
}

