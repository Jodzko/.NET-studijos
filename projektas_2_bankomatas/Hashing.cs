using System.Security.Cryptography;
using System.Text;

namespace projektas_2_bankomatas
{
    public class Hashing
    {
        public static byte[] Salt;
        public static string ToSHA256(string s)
        {            
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static byte[] GenerateSalt(int size = 16)
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] salt = new byte[size];
                rng.GetBytes(salt);
                return Salt = salt;                
            }

        }

        public static string HashPasswordWithSalt(string s)
        {
            
            using (var sha256 = SHA256.Create())
            {               
                byte[] passwordBytes = Encoding.UTF8.GetBytes(s);
                byte[] saltedPassword = new byte[passwordBytes.Length + Salt.Length];
                Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                Buffer.BlockCopy(Salt, 0, saltedPassword, passwordBytes.Length, Salt.Length);

                byte[] hashedBytes = sha256.ComputeHash(saltedPassword);
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
