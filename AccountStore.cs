using System.Security.Cryptography;
using System.Text;

namespace CLAVIOMICA_INVENTORY
{
    internal static class AccountStore
    {
        private static string? username;
        private static byte[]? passwordHash;

        static AccountStore()
        {
            Register("mc1234", "mc123");
        }

        public static bool HasAccount => username is not null && passwordHash is not null;

        public static void Register(string newUsername, string password)
        {
            username = newUsername.Trim();
            passwordHash = HashPassword(password);
        }

        public static bool Validate(string enteredUsername, string password)
        {
            if (!HasAccount || !string.Equals(username, enteredUsername.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            byte[] enteredHash = HashPassword(password);
            return CryptographicOperations.FixedTimeEquals(passwordHash!, enteredHash);
        }

        private static byte[] HashPassword(string password)
        {
            return SHA256.HashData(Encoding.UTF8.GetBytes(password));
        }
    }
}
