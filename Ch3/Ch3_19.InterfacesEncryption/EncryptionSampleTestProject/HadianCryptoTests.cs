using EncryptionSample;

namespace EncryptionSampleTestProject
{
    [TestClass]
    public class HadianCryptoTests
    {
        [TestMethod]
        public void TestEncryption()
        {
            HadianCrypto hc = new HadianCrypto("abc");
            string expected = "bcd";
            string actual = hc.Encrypt();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDecryption()
        {
            HadianCrypto hc = new HadianCrypto("bcd");
            string expected = "abc";
            string actual = hc.Decrypt();
            Assert.AreEqual(expected, actual);
        }
    }
}
