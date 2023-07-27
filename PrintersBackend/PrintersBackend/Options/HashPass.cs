using System;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace PrintersBackend.Options
{
    public class HashPass
    {
        public string getHash(string password)
        {
            byte[] salt = new byte[16] { 0xa5, 0x64, 0x7f, 0x59, 0x13, 0x93, 0x63, 0x61, 0x54, 0x2d, 0x9e, 0x72, 0x91, 0xb6, 0x78, 0x9e };

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8)
            );
            return hashed;
        }
    }
}
