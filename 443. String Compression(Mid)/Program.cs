

using System.Text;

char[] chars = ['b', 'a', 'a', 'a', 'a'];
//a3b3c3

var test = Compress(chars);
Console.WriteLine();
int Compress(char[] chars)
{
    int count = 0;
	var writingIndex = 0;
	for (int i = 0; i <= chars.Length; i++)
    {
        count++;
        if (i + 1 < chars.Length && chars[i] != chars[i + 1] || i == chars.Length - 1)
		{
			chars[writingIndex++] = chars[i];

            if (count > 1)
			{
				foreach (var item in count.ToString())
				{
					chars[writingIndex++] = item;
                }
            }

            count = 0;
        }
    }

    return writingIndex;
}

/* 
	iterate through char
	count++
	if current char is not equal to last char
	stop counting
			If the group's length is 1, append the character to s.
		Otherwise, append the character followed by the group's length.
 */