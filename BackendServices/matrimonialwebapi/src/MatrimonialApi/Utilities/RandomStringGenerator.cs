using System;
using System.Security.Cryptography;
using System.Text;

namespace MatrimonialApi.Utilities
{
    public static class RandomStringGenerator
    {
        private static readonly char[] _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
        private static readonly int _size = 6;

        public static string GenerateRandomString()
        {
            byte[] data = new byte[_size];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(data);
            }

            StringBuilder result = new StringBuilder(_size);
            foreach (byte b in data)
            {
                result.Append(_chars[b % _chars.Length]);
            }

            return result.ToString();
        }
    }
}