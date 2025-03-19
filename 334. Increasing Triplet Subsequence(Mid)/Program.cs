

int[] nums = [3, 4, 1, 5];
//int[] nums = [20, 100, 10, 12, 5, 13];
bool returnBool = false;
var test = IncreasingTriplet(nums);
Console.WriteLine(test);
/*
 1,5,0,4,1,3
 */
bool IncreasingTriplet(int[] nums)
{
    int left = 0;
    int right = 0;
    bool isBOol = false;
    for (int i = 1; i < nums.Length; i++)
    {
        if (left < right)
        {
            isBOol = true;
        }

        if (isBOol && nums[right] < nums[i])
        {
            return true;
        }

        if (nums[left] < nums[i])
        {
            right = i;
        }

        if (nums[right] > nums[i])
        {
            left = i;
        }
    }
    return false;
}
