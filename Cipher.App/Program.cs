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
        var input = new InputParameters { InputText = option.InputText, Key = option.Key };

        switch (option.InputType)
        {
            case Cipher.Caesar:
                _cipher = new CaesarCipher();
                break;
            case Cipher.A1Z26:
                _cipher = new A1Z26Cipher();
                break;
            case Cipher.Morse:
                _cipher = new MorseCipher();
                break;
            case Cipher.Vigenere:
                _cipher = new VigenereCipher();
                break;
            case Cipher.Xor:
                _cipher = new XorCipher();
                break;
            default:
                throw new NotImplementedException();
        }

        string outPutValue;

        switch (option.Mode)
        {
            case Mode.Encrypt:
                outPutValue = _cipher.Encrypt(input);
                break;
            case Mode.Decrypt:
                outPutValue = _cipher.Decrypt(input);
                break;
            default:
                throw new NotImplementedException();
        }

        Console.WriteLine(outPutValue);
    }
}
