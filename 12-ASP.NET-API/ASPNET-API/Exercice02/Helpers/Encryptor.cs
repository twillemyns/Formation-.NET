using System.Security.Cryptography;

namespace Exercice02.Helpers;

public class Encryptor
{
    private const int SaltSize = 16;
    private const int KeySize = 32;
    private const int Iterations = 100;

    public string EncryptPassword(string password)
    {
        using var algorithm = new Rfc2898DeriveBytes(
            password,
            SaltSize,
            Iterations,
            HashAlgorithmName.SHA512
        );

        var key = Convert.ToBase64String(algorithm.GetBytes(KeySize));
        var salt = Convert.ToBase64String(algorithm.Salt);

        return $"{Iterations}.{salt}.{key}";
    }

    public bool Check(string userHashPassword, string loginPassword)
    {
        var parts = userHashPassword.Split('.', 3);

        if (parts.Length != 3)
            throw new FormatException("Format du hash inattendu.");

        var iterations = Convert.ToInt32(parts[0]);
        var salt = Convert.FromBase64String(parts[1]);
        var key = Convert.FromBase64String(parts[2]);

        using var algorithm = new Rfc2898DeriveBytes(
            loginPassword,
            salt,
            iterations,
            HashAlgorithmName.SHA512
        );

        var keyToCheck = algorithm.GetBytes(KeySize);

        var isVerified = keyToCheck.SequenceEqual(key);

        return isVerified;
    }
}