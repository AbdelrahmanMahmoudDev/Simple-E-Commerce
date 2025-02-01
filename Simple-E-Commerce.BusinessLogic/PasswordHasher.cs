using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Simple_E_Commerce.BusinessLogic
{
    public static class PasswordHasher
    {
        public static (string HashString, string SaltString) HashPassword(string InputPassword)
        {
            using (HMACSHA256 HMAC = new HMACSHA256())
            {
                // Generate a random salt
                byte[] Salt = new byte[16];
                RandomNumberGenerator RNG = RandomNumberGenerator.Create();
                RNG.GetBytes(Salt);

                // Combine the password and salt
                byte[] PasswordBytes = Encoding.UTF8.GetBytes(InputPassword);
                byte[] SaltedPassword = new byte[PasswordBytes.Length + Salt.Length];

                Array.Copy(PasswordBytes, 0, SaltedPassword, 0, PasswordBytes.Length);
                Array.Copy(Salt, 0, SaltedPassword, PasswordBytes.Length, Salt.Length);

                // Initialize HMAC with the salt as the key
                HMAC.Key = Salt;

                // Compute the hash of the salted password
                byte[] Hash = HMAC.ComputeHash(SaltedPassword);

                // Return the hash and the salt (base64 encoded)
                return (Convert.ToBase64String(Hash), Convert.ToBase64String(Salt));
            }
        }

        public static bool VerifyPassword(string InputPassword, string StoredHash, string StoredSalt)
        {
            // Decode the stored hash and salt from Base64 to byte arrays
            byte[] StoredHashBytes = Convert.FromBase64String(StoredHash);
            byte[] StoredSaltBytes = Convert.FromBase64String(StoredSalt);

            // Convert the input password to a byte array
            byte[] InputPasswordBytes = Encoding.UTF8.GetBytes(InputPassword);

            // Combine the input password and salt
            byte[] SaltedPassword = new byte[InputPasswordBytes.Length + StoredSaltBytes.Length];
            Array.Copy(InputPasswordBytes, 0, SaltedPassword, 0, InputPasswordBytes.Length);
            Array.Copy(StoredSaltBytes, 0, SaltedPassword, InputPasswordBytes.Length, StoredSaltBytes.Length);

            // Initialize HMAC with the stored salt as the key
            using (HMACSHA256 hmac = new HMACSHA256())
            {
                hmac.Key = StoredSaltBytes;  // Set the key to the stored salt

                // Compute the hash of the salted password
                byte[] computedHashBytes = hmac.ComputeHash(SaltedPassword);

                // Compare the computed hash with the stored hash
                return StoredHashBytes.SequenceEqual(computedHashBytes);
            }
        }

    }
}
