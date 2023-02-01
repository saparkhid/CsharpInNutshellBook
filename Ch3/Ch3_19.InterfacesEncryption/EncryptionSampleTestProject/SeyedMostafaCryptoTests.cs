using EncryptionSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionSampleTestProject
{

    [TestClass]
    public class SeyedMostafaCryptoTests
    {
        [TestMethod]
        public void TestEncryption()
        {
            SeyedMostafaCrypto tc = new SeyedMostafaCrypto("abc");
            string expected = "abc";
            string actual = tc.Encrypt();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDecryption()
        {
            SeyedMostafaCrypto tc = new SeyedMostafaCrypto("abc");
            string expected = "abc";
            string actual = tc.Decrypt();

            Assert.AreEqual(expected, actual);
        }
    }
}
