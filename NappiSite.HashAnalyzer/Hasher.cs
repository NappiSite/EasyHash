using System;
using System.Security.Cryptography;
using System.Text;

namespace NappiSite.HashAnalyzer
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
                default:
                    throw new ArgumentException("Unknown hashtype");
            }

            return FormatHash(result);
        }
        private static string FormatHash(byte[] output)
        {
            return BitConverter.ToString(output).Replace("-", string.Empty).ToLowerInvariant();
        }
        private static byte[] ComputeMd5Hash(string value)
        {
            var fpBytes = Encoding.ASCII.GetBytes(value);

            using (var md5 = MD5.Create())
            {
                var fpHash = md5.ComputeHash(fpBytes);

                return fpHash;
            }
        }
        private static byte[] ComputeSha1Hash(string email)
        {
            var input = Encoding.ASCII.GetBytes(email);

            using (var sha = SHA1.Create())
            {
                var output = sha.ComputeHash(input);

                return output;
            }
        }
        private static byte[] ComputeSha256Hash(string email)
        {
            var input = Encoding.ASCII.GetBytes(email);

            using (var sha = SHA256.Create())
            {
                var output = sha.ComputeHash(input);

                return output;
            }
        }
    }
}
