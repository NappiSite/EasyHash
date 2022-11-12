using System;
using System.Security.Cryptography;
using System.Text;

namespace NappiSite.HashAnalyzer
{
    public static class Hasher
    {
        public static string ComputeMd5HashString(string value)
        {
            return FormatHash(ComputeMd5Hash(value));
        }
        public static string ComputeSha1HashString(string value)
        {
            return FormatHash(ComputeSha1Hash(value));
        }

        public static string ComputeSha256HashString(string value)
        {
            return FormatHash(ComputeSha256Hash(value));
        }

        public static string FormatHash(byte[] output)
        {
            return BitConverter.ToString(output).Replace("-", string.Empty).ToLowerInvariant();
        }

        public static byte[] ComputeMd5Hash(string value)
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
