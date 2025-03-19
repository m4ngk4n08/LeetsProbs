

var test = FindLHS([1]);

int FindLHS(int[] nums)
{
    var numsDict = new Dictionary<int, int>();
    foreach (var num in nums)
    {
        numsDict.TryAdd(num, 0);
        numsDict[num]++;
    }

    int maxFrequency = 0;

    var sortedDict = numsDict.Keys.OrderBy(j => j).ToList();

    for (int i = 0; i < numsDict.Count - 1; i++)
    {
        int currentKey = sortedDict[i];
        int nextKey = sortedDict[i + 1];
        if (Math.Abs(currentKey - nextKey) == 1)
        {
            maxFrequency = Math.Max(maxFrequency, numsDict[currentKey] + numsDict[nextKey]);
        }
    }

    return maxFrequency;
}