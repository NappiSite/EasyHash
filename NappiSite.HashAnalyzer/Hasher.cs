using System;
using System.Security.Cryptography;
using System.Text;

namespace NappiSite.EasyHash
{
    public static class Hasher
    {
        public static string GenerateHash(string value, HashType hashType)
        {
            byte[] result;

            switch (hashType)
            {
                case HashType.Md5:
                    result = ComputeMd5Hash(value);
                    break;
                case HashType.Sha1:
                    result = ComputeSha1Hash(value);
                    break;
                case HashType.Sha256:
                    result = ComputeSha256Hash(value);
                    break;
                case HashType.Unknown:
                default:
                    throw new ArgumentException("Unknown HashType");
            }

            return FormatHash(result);
        }
        private static string FormatHash(byte[] output)
        {
            return BitConverter.ToString(output).Replace("-", string.Empty).ToLowerInvariant();
        }
        private static byte[] ComputeMd5Hash(string value)
        {
            var input = GetBytes(value);

            using (var algorithm = MD5.Create())
            {
                return algorithm.ComputeHash(input);
            }
        }
        private static byte[] GetBytes(string value)
        {
            return Encoding.ASCII.GetBytes(value);
        }
        private static byte[] ComputeSha1Hash(string value)
        {
            var input = GetBytes(value);

            using (var algorithm = SHA1.Create())
            {
                return algorithm.ComputeHash(input);
            }
        }
        private static byte[] ComputeSha256Hash(string value)
        {
            var input = GetBytes(value);

            using (var algorithm = SHA256.Create())
            {
                return algorithm.ComputeHash(input);
            }
        }
    }
}
