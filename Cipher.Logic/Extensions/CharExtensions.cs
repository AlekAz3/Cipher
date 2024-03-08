namespace Cipher.Logic;

public static class CharExtensions
{
    public static bool IsLetter(this char a)
    {
        int position = Convert.ToInt32(a);

        return (position is >= 65 and <= 90 or >= 97 and <= 122);
    }


    public static char JumpLetter(this char letter, int a)
    {
        int position = Convert.ToInt32(letter);

        if (position is >= 65 and <= 90)
        {
            position += a;
            if (position <= 65 )
            {
                position += 26;
            }
            else if (position>=90)
            {
                position -= 26;
            }
        }

        if (position is >= 97 and <= 122)
        {
            position += a;
            if (position <= 97 )
            {
                position += 26;
            }
            else if (position>=122)
            {
                position -= 26;
            }
        }

        return Convert.ToChar(position);
    }
}
