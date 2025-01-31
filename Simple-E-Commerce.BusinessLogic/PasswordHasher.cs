using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            using(HMACSHA256 HMAC = new HMACSHA256())
            {
                byte[] Salt = new byte[16];
                RandomNumberGenerator RNG = RandomNumberGenerator.Create();
                RNG.GetBytes(Salt);

                byte[] PasswordBytes = Encoding.UTF8.GetBytes(InputPassword);
                byte[] SaltedPassword = new byte[PasswordBytes.Length + Salt.Length];

                Array.Copy(PasswordBytes, 0, SaltedPassword, 0, PasswordBytes.Length);
                Array.Copy(Salt, 0, SaltedPassword, PasswordBytes.Length, Salt.Length);

                byte[] Hash = HMAC.ComputeHash(SaltedPassword);

                return(Convert.ToBase64String(Hash), Convert.ToBase64String(Salt));
            }
        }

        public static bool VerifyPassword(string InputPassword, string StoredHash, string StoredSalt)
        {
            byte[] HashBytes = Convert.FromBase64String(StoredHash);
            byte[] SaltBytes = Convert.FromBase64String(StoredSalt);
            byte[] InputPasswordBytes = Encoding.UTF8.GetBytes(InputPassword);

            using (HMACSHA256 HMAC = new HMACSHA256())
            {
                byte[] SaltedPassword = new byte[HashBytes.Length + SaltBytes.Length];
                Array.Copy(InputPasswordBytes, 0, SaltedPassword, 0, InputPasswordBytes.Length);
                Array.Copy(SaltBytes, 0, SaltedPassword, InputPasswordBytes.Length, SaltBytes.Length);

                byte[] CompareHash = HMAC.ComputeHash(SaltedPassword);

                for(int i =  0; i < HashBytes.Length; i++)
                {
                    if (StoredHash[i] != CompareHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
