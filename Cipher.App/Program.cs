using CommandLine;

namespace Cipher.Model;

class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<InputOption>(args)
            .WithParsed(Start);
    }

    static void Start(InputOption option)
    {

    }
}
