using EncryptionSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionSampleTestProject
{

    [TestClass]
    public class ParkhidCryptoTests
    {
        [TestMethod]
        public void TestEncryption()
        {
            ParkhidCrypto tc = new ParkhidCrypto("abc");
            string expected = "cba";
            string actual = tc.Encrypt();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDecryption()
        {
            ParkhidCrypto tc = new ParkhidCrypto("cba");
            string expected = "abc";
            string actual = tc.Decrypt();

            Assert.AreEqual(expected, actual);
        }
    }
}
