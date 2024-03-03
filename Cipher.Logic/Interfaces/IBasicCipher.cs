namespace Cipher.Logic;

/// <summary>
/// Интерфейс для шифровки и дешифровкиы
/// </summary>
public interface IBasicCipher
{
    /// <summary>
    /// Зашифровать
    /// </summary>
    /// <param name="options">настройки</param>
    /// <returns>Зашифрованный текст</returns>
    public string Encrypt(InputParameters options);

    /// <summary>
    /// Рассшифровать
    /// </summary>
    /// <param name="options">настройки</param>
    /// <returns>Рассшифрованный текст</returns>
    public string Decrypt(InputParameters options);
}
