namespace Cipher.Logic;

public class CaesarCipher : IBasicCipher
{
    public string Encrypt(InputParameters options)
    {
        if (options.Key is null)
        {
            throw new ArgumentNullException(options.Key);
        }

        if (options.InputText is null)
        {
            throw new ArgumentNullException(options.InputText);
        }

        var key = Convert.ToInt32(options.Key);

        var result = new List<char>();

        result.AddRange(options.InputText.ToList().Select(cac => cac.JumpLetter(key)));
        return new string(result.ToArray());
    }

    public string Decrypt(InputParameters options)
    {
        if (options.Key is null)
        {
            throw new ArgumentNullException(options.Key);
        }

        if (options.InputText is null)
        {
            throw new ArgumentNullException(options.InputText);
        }

        var key = Convert.ToInt32(options.Key) * -1;

        var result = new List<char>();

        result.AddRange(options.InputText.ToList().Select(cac => cac.JumpLetter(key)));
        return new string(result.ToArray());
    }
}
