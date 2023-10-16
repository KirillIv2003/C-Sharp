using System.Security.Cryptography;
using System.Text;

class PasswordGenerator
{
    public static List<string> GeneratePasswords(int count, int length, bool useDigits = true, bool useLowercase = true, bool useUppercase = true, bool useSpecialChars = true, string customChars = "")
    {
        if (count <= 0 || length <= 0)
        {
            throw new ArgumentException("Число и длина должны быть больше нуля.");
        }

        if (!useDigits && !useLowercase && !useUppercase && !useSpecialChars && string.IsNullOrEmpty(customChars))
        {
            throw new ArgumentException("Должен быть включен хотя бы один набор символов (цифры, строчные и прописные буквы, специальные символы, пользовательские символы).");
        }

        string chars = "";

        if (useDigits)
        {
            chars += "0123456789";
        }

        if (useLowercase)
        {
            chars += "abcdefghijklmnopqrstuvwxyz";
        }

        if (useUppercase)
        {
            chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        if (useSpecialChars)
        {
            chars += "!@#$%^&*()-_=+[]{}|;:'\",.<>?";
        }

        chars += customChars;

        List<string> passwords = new List<string>();

        using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
        {
            for (int i = 0; i < count; i++)
            {
                byte[] randomBytes = new byte[length];
                rng.GetBytes(randomBytes);

                StringBuilder passwordBuilder = new StringBuilder(length);
                foreach (byte b in randomBytes)
                {
                    passwordBuilder.Append(chars[b % chars.Length]);
                }

                passwords.Add(passwordBuilder.ToString() + customChars);
            }
            
        }

        return passwords;
    }

    static void Main()
    {
        List<string> passwords1 = GeneratePasswords(5, 10);
        List<string> passwords2 = GeneratePasswords(3, 12, true, true, true, false, "");
        List<string> passwords3 = GeneratePasswords(2, 8, true, false, false, true, "@$");

        Console.WriteLine("Generated Passwords 1:");
        foreach (string password in passwords1)
        {
            Console.WriteLine(password);
        }

        Console.WriteLine("\nGenerated Passwords 2:");
        foreach (string password in passwords2)
        {
            Console.WriteLine(password);
        }

        Console.WriteLine("\nGenerated Passwords 3:");
        foreach (string password in passwords3)
        {
            Console.WriteLine(password);
        }
    }
}
