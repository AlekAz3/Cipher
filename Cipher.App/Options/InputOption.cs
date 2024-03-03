using CommandLine;

namespace Cipher.Logic;

/// <summary>
/// Входные параментры
/// </summary>
public class InputOption
{
    [Option('c', "cipher", Required = true)]
    public Cipher InputType { get; set; }

    [Option('m', "mode", Required = true)] public Mode Mode { get; set; }

    [Option('t', "text", Required = true)] public  IEnumerable<string> InputText { get; set; }

    [Option('k', "key", Required = true)] public string? Key { get; set; }
}
