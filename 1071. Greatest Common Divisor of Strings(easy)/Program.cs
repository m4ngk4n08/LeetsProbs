
using System.Text;

var test = GcdOfStrings("LEET", "CODE");
Console.WriteLine(test);


string GcdOfStrings(string str1, string str2)
{
    int str1Len = str1.Length;
    int str2Len = str2.Length;
    var gcd = GCD(str1Len, str2Len);

    if (str1 + str2 != str2 + str1) return string.Empty;

    return str1.Substring(0, gcd);
}

int GCD(int a, int b)
{

    while (a != 0 && b != 0)
    {
        if (a > b)
        {
            a %= b;
        }
        else
        {
            b %= a;
        }
    }

    return a | b;
}