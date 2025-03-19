
var test = MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);

int MaxArea(int[] height)
{
	int right = height.Length - 1;
	int maxArea = 0;
	for (int left = 0; left < height.Length && left != right; left++)
    {
        maxArea = Math.Max(maxArea, Math.Abs(left - right) * Math.Min(height[left], height[right]));
        if (height[left] > height[right])
        {
            right--;
            left--;
        }
    }

    return maxArea;
}