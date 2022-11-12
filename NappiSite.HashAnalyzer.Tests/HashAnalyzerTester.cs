using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NappiSite.HashAnalyzer.Tests
{
    [TestClass]
    public class HashAnalyzerTester
    {
        [DataTestMethod]
        [DataRow("", HashType.Unknown)]
        [DataRow("5f4dcc3b5aa765d61d8327deb882cf99", HashType.Md5)]
        [DataRow("8743b52063cd84097a65d1633f5c74f5", HashType.Md5)]
        [DataRow("01dfae6e5d4d90d9892622325959afbe", HashType.Md5)]
        [DataRow("f0fda58630310a6dd91a7d8f0a4ceda2", HashType.Md5)]
        [DataRow("b89eaac7e61417341b710b727768294d0e6a277b", HashType.Sha1)]
        [DataRow("2fc5a684737ce1bf7b3b239df432416e0dd07357", HashType.Sha1)]
        [DataRow("5baa61e4c9b93f3f0682250b6cf8331b7ee68fd8", HashType.Sha1)]
        [DataRow("cac35ec206d868b7d7cb0b55f31d9425b075082b", HashType.Sha1)]
        [DataRow("5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", HashType.Sha256)]
        [DataRow("127e6fbfe24a750e72930c220a8e138275656b8e5d8f48a98c3c92df2caba935", HashType.Sha256)]
        [DataRow("eb368a2dfd38b405f014118c7d9747fcc97f4f0ee75c05963cd9da6ee65ef498", HashType.Sha256)]
        public void AnalyzeHashType_Generates_Correct(string value, HashType expected)
        {
            // Arrange

            // Act
            var result = HashAnalyzer.AnalyzeHashType(value);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
