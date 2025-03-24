

int[] testNums = [1, 2, 3];
int maxNum = testNums.Min();
int maxIdx = Array.IndexOf(testNums, maxNum);
var outList = new List<int>();

for (int i = 0; i <= testNums.Length; i++)
{
    var left = (maxIdx - i + testNums.Length) % testNums.Length;
    var right = (i + maxIdx) % testNums.Length;
    Console.WriteLine(right);
}

Console.WriteLine();


var test = LongestSubarray([0, 1, 1, 1, 0, 1, 1, 0, 1]);

int LongestSubarray(int[] nums)
{

    int count = 0;
    int maxCount = 0;
    int zeroCount = 0;
    int left = 0;

    for (int i = 0; i < nums.Length; i++)
	{
        count++;
        if (nums[i] == 0)
            zeroCount++;

        while (zeroCount > 1)
        {
            if (nums[left] == 0)
                zeroCount--;
            count--;
            left++;
        }

        maxCount = Math.Max(maxCount, count - 1);
    }

    return maxCount;
}




static void BubbleSort(int[] arr, int n)
{
    bool swapped;
    for (int outter = 0; outter < n - 1; outter++)
    {
        swapped = false;
        for (int inner = 0; inner < n - outter - 1; inner++)
        {
            if (arr[inner] > arr[inner + 1])
            {
                (arr[inner], arr[inner + 1]) = (arr[inner + 1], arr[inner]);
                swapped = true;
            }
        }
        if (!swapped)
        {
            break;
        }
    }
}