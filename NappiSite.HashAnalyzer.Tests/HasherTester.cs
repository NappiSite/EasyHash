using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NappiSite.EasyHash.Tests
{
    [TestClass]
    public class HasherTester
    {
        [DataTestMethod]
        [DataRow(HashType.Md5, "2b9b01ed72024b1ef77059e52fffc984")]
        [DataRow(HashType.Sha1, "549fb3ed27123b985d4efe2ac67ed9f25e92b1a2")]
        [DataRow(HashType.Sha256, "ead067b8ee76159c8fb96428fc1c9b5124fa05947c838348c216c0601d7fd0fd")]
        public void ComputeHash_Generates_Correct(HashType hashType, string expected)
        {
            // Arrange
            const string STRING_VALUE = "some random bunch of text";

            // Act
            var result = Hasher.GenerateHash(STRING_VALUE, hashType);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ComputeHash_InvalidType_ThrowsException()
        {
            // Arrange
            const string STRING_VALUE = "some random bunch of text";

            // Act
            Assert.ThrowsException<ArgumentException>(() => Hasher.GenerateHash(STRING_VALUE, HashType.Unknown));

            // Assert       
        }

        [TestMethod]
        public void ComputeHash_Null_ThrowsException()
        {
            // Arrange
            const string STRING_VALUE = null;

            // Act
            Assert.ThrowsException<ArgumentNullException>(() => Hasher.GenerateHash(STRING_VALUE, HashType.Md5));

            // Assert       
        }
    }
}
