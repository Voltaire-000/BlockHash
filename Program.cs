using System;
using System.Text;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        //Console.Write("Enter a string: ");
        //string input = Console.ReadLine();
        string input = "hello";
        string hash = ComputeSha256Hash(input);
        Console.WriteLine($"The SHA256 hash of '{input}' is: {hash}");
    }

    static string ComputeSha256Hash(string rawData)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}

