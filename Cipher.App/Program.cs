using CommandLine;

namespace Cipher.Logic;

class Program
{
    private static IBasicCipher _cipher;

    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<InputOption>(args)
            .WithParsed(Start);
    }

    static void Start(InputOption option)
    {


        var input = new InputParameters { InputText = string.Join(' ', option.InputText.ToArray()) , Key = option.Key };

        _cipher = option.InputType switch
        {
            Cipher.Caesar => new CaesarCipher(),
            Cipher.A1Z26 => new A1Z26Cipher(),
            Cipher.Morse => new MorseCipher(),
            Cipher.Vigenere => new VigenereCipher(),
            Cipher.Xor => new XorCipher(),
            _ => throw new NotImplementedException()
        };

        string outPutValue = option.Mode switch
        {
            Mode.Encrypt => _cipher.Encrypt(input),
            Mode.Decrypt => _cipher.Decrypt(input),
            _ => throw new NotImplementedException()
        };

        Console.WriteLine(outPutValue);
    }
}
