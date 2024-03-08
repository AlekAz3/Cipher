namespace Cipher.Logic;

public class VigenereCipher : IBasicCipher
{
    public string Encrypt(InputParameters options)
    {
        string key = options.Key.ToLowerInvariant();
        var keys = key.Select(x => Convert.ToInt32(x) - 96 - 1).ToList();

        for (int i = 0; i < (options.InputText.Length / key.Length) + 1; i++)
        {
            keys.AddRange(keys);
        }

        var result = new List<char>();
        int cor = 0;

        for (int i = 0; i < options.InputText.Length; i++)
        {
            if (!options.InputText[i].IsLetter())
            {
                cor++;
            }

            result.Add(options.InputText[i].JumpLetter(keys[i-cor]));
        }

        return new string(result.ToArray());
    }

    public string Decrypt(InputParameters options)
    {
        string key = options.Key.ToLowerInvariant();
        var keys = key.Select(x => -1 * (Convert.ToInt32(x) - 96 - 1)).ToList();

        for (int i = 0; i < (options.InputText.Length / key.Length) + 1; i++)
        {
            keys.AddRange(keys);
        }

        var result = new List<char>();
        int cor = 0;

        for (int i = 0; i < options.InputText.Length; i++)
        {
            if (!options.InputText[i].IsLetter())
            {
                cor++;
            }

            result.Add(options.InputText[i].JumpLetter(keys[i-cor]));
        }

        return new string(result.ToArray());
    }
}
