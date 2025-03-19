
var test = MaxOperations([2, 5, 4, 4, 1, 3, 4, 4, 1, 4, 4, 1, 2, 1, 2, 2, 3, 2, 4, 2], 3);

//var test = MaxOperations([3, 1, 3, 4, 3], 6);
int MaxOperations(int[] nums, int k)
{
    int count = 0;
    var numsDict = new Dictionary<int, int>();

    foreach (var num in nums)
    {
        int kNum = k - num;

        if (numsDict.ContainsKey(kNum) && numsDict[kNum] > 0)
        {
            numsDict[kNum]--;
            count++;
        }
        else
        {
            if (!numsDict.ContainsKey(num))
                numsDict[num] = 0;
            numsDict[num]++;

        }
    }

    return count;
}
