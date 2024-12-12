using System.Security.Cryptography;
using System.Text;

namespace projektas_2_bankomatas
{
    public class Hashing
    {
        public static byte[] Salt;
        public static string SaltBase64;
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
                SaltBase64 = Convert.ToBase64String(salt);
                return Salt = salt;                
            }           
        }
        public static bool CheckIfPasswordIsCorrect(string enteredPassword, string storedHash, string storedSalt)
        {
            byte[] salt = Convert.FromBase64String(storedSalt);
            string hashOfEnteredPassword = HashPasswordWithSalt(enteredPassword, salt);
            return storedHash == hashOfEnteredPassword;
        }
        public static (string Salt, string HashedPassword) HashPassword(string password)
        {
            byte[] salt = GenerateSalt(16);
            string hashedPassword = HashPasswordWithSalt(password, salt);
            string saltBase64 = Convert.ToBase64String(salt);
            return (saltBase64, hashedPassword);

        }
        public static string HashPasswordWithSalt(string s, byte[] salt)
        {
            using (var pbkdf2 = new PasswordDeriveBytes(s, salt))
            {
                byte[] hash = pbkdf2.GetBytes(32); 
                return Convert.ToBase64String(hash);
            }
        }
    }
}
