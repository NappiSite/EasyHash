using System.Linq;

namespace NappiSite.EasyHash
{
    public class HashAnalyzer
    {
        public static HashType AnalyzeHashType(string value)
        {
            var hashType = HashType.Unknown;

            if (IsSha256(value))
            {
                hashType = HashType.Sha256;
            }
            else if (IsSha1(value))
            {
                hashType = HashType.Sha1;
            }
            else if (IsMd5(value))
            {
                hashType = HashType.Md5;
            }

            return hashType;
        }

        private static bool IsMd5(string value)
        {
            return IsHash(value, 32);
        }

        private static bool IsSha1(string value)
        {
            return IsHash(value, 40);
        }

        private static bool IsSha256(string value)
        {
            return IsHash(value, 64);
        }

        private static bool IsHash(string value, int length)
        {     
            return value.Length == length && value.All(c => ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F')));
        }
    }
}
