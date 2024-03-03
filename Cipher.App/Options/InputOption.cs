using CommandLine;

namespace Cipher.Model;

/// <summary>
/// Входные параментры
/// </summary>
public class InputOption
{
    [Option('c', "cipher", Required = true)]
    public Cipher InputType { get; set; }

    [Option('m', "mode", Required = true)]
    public bool Mode { get; set; }

    [Option('t', "text", Required = true)]
    public string? InputText { get; set; }

    [Option('k', "key", Required = true)]
    public string? Key { get; set; }
}
