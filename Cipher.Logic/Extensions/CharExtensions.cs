namespace Cipher.Logic;

public static class CharExtensions
{
    public static char JumpLetter(this char letter, int a)
    {
        var position = Convert.ToInt32(letter);

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
