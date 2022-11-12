using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NappiSite.HashAnalyzer.Tests
{
    [TestClass]
    public class HasherTester
    {
        [TestMethod]  
        public void ComputeHash_Generates_Correct()
        {
            // Arrange
            const string STRING_VALUE = "some random bunch of text";

            // Act
            var byteValue = Hasher.ComputeMd5Hash(STRING_VALUE);
            var stringHash = BitConverter.ToString(byteValue);

            // Assert
            Assert.AreEqual("2B-9B-01-ED-72-02-4B-1E-F7-70-59-E5-2F-FF-C9-84", stringHash);
        }
    }
}
