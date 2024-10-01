namespace LeetCodeEasy.Tasks01102024;

public class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        var asString = x.ToString();
        var i = 0;
        var j = asString.Length - 1;
        while (i < j)
        {
            if (asString[i] != asString[j])
            {
                return false;
            }

            i++;
            j--;
        }
        return true;
    }
}